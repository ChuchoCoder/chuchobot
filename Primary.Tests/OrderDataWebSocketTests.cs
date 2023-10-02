using System;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Primary.Data;
using Primary.Data.Orders;

namespace Primary.Tests
{
    [TestFixture]
    internal class OrderDataWebSocketTests
    {
        [OneTimeSetUp]
        public async Task Login()
        {
            _api = new Api(Api.DemoEndpoint);
            await _api.Login(Api.DemoUsername, Api.DemoPassword);
        }

        private Api _api;

        [Test]
        [Timeout(10000)]
        public async Task SubscriptionToOrdersDataCanBeCreated()
        {
            // Subscribe to demo account
            using var socket = _api.CreateOrderDataSocket(new[] { Api.DemoAccount });
            
            OrderStatus retrievedData = null;
            socket.OnData = ( (api, orderData) => retrievedData = orderData.OrderReport );
            await socket.Start();

            // Send order
            Order order = Build.AnOrder(_api);
            await _api.SubmitOrder(Api.DemoAccount, order);

            // Wait until data arrives
            while (retrievedData == null)
            {
                Thread.Sleep(100);
            }

            Assert.That(retrievedData.Account.Id, Is.EqualTo(Api.DemoAccount));
            Assert.That(retrievedData.Instrument.Symbol, Is.EqualTo(order.Instrument.Symbol));
            Assert.That(retrievedData.Instrument.Market, Is.EqualTo(order.Instrument.Market));
            Assert.That(retrievedData.Price, Is.EqualTo(order.Price));
            Assert.That(retrievedData.TransactionTime, Is.Not.EqualTo(default(long)));
        }

        [Test]
        [Timeout(10000)]
        public async Task SubscriptionToOrdersDataCanBeCancelled()
        {
            // Used to cancel the task
            using var cancellationSource = new CancellationTokenSource();

            // Create and start the web socket
            using var socket = _api.CreateOrderDataSocket(new[] { Api.DemoAccount }, cancellationSource.Token);
            Assert.That(!socket.IsRunning);

            var socketTask = await socket.Start();

            // Wait until it is running
            while (!socket.IsRunning)
            {
                Thread.Sleep(10);
            }

            cancellationSource.Cancel();

            try
            {
                await socketTask;
                Assert.Fail();
            }
            catch (OperationCanceledException)
            {
                Assert.That(!socket.IsRunning);
            }
        }
    }
}
