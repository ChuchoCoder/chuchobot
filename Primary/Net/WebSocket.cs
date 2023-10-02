using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Primary.Net
{
    public class WebSocket<TRequest, TResponse> : IDisposable
    {
        internal WebSocket(Api api, TRequest request, CancellationToken cancelToken)
        {
            _api = api;
            _request = request;
            CancelToken = cancelToken;

            var wsScheme = (_api.BaseUri.Scheme == "https" ? "wss" : "ws");
            var uriBuilder = new UriBuilder(_api.BaseUri) { Scheme = wsScheme };
            _uri = uriBuilder.Uri; 
        }
        
        public async Task<Task> Start()
        {
            _client.Options.SetRequestHeader("X-Auth-Token", _api.AccessToken);

            await _client.ConnectAsync(_uri, CancelToken);

            // Send data to request
            var jsonRequest = JsonConvert.SerializeObject(_request);

            var outputBuffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(jsonRequest));
            await _client.SendAsync(outputBuffer, WebSocketMessageType.Text, true, CancelToken);

            // Receive
            var socketTask = Task.Factory.StartNew(ProcessSocketData, CancelToken,
                                                   TaskCreationOptions.LongRunning,
                                                   TaskScheduler.Default
            );

            return socketTask.Unwrap();
        }
        
        public bool IsRunning { get; private set; }
        public CancellationToken CancelToken { get; }

        public Action<Api, TResponse> OnData { get; set; }
        
        #region IDisposable implementation

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _client.Dispose();
            }
        }

        #endregion

        private async Task ProcessSocketData()
        {
            IsRunning = true;
            
            // Buffers for received data
            var receivedMessage = new List<byte>();
            var buffer = new byte[9192];

            while (true)
            {
                try
                {
                    // Get data until the complete message is received
                    WebSocketReceiveResult response;
                    do
                    {
                        response = await _client.ReceiveAsync(new ArraySegment<byte>(buffer), CancelToken);
                        if(response.CloseStatus != null)
                        { 
                            throw new Exception(response.CloseStatusDescription);
                        }
                        var segment = new ArraySegment<byte>(buffer, 0, response.Count);
                        receivedMessage.AddRange(segment);

                    } while (!response.EndOfMessage);

                    // Decode the message
                    var messageJson = Encoding.ASCII.GetString( receivedMessage.ToArray() );
                    receivedMessage.Clear();

                    // Parse and notify subscriber
                    var data = JsonConvert.DeserializeObject<TResponse>(messageJson);
                    OnData(_api, data);
                }
                catch (OperationCanceledException) { }
                catch (WebSocketException wsEx)
                {
                    throw wsEx;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (CancelToken.IsCancellationRequested)
                {
                    IsRunning = false;
                    CancelToken.ThrowIfCancellationRequested();
                }
            }
        }

        private readonly ClientWebSocket _client = new ClientWebSocket();

        private readonly TRequest _request;
        private readonly Api _api;
        private readonly Uri _uri;
    }
}
