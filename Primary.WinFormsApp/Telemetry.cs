using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace ChuchoBot.WinFormsApp;

internal class Telemetry
{
    // Global static instance for App Insights
    private static TelemetryClient AppInsights;

    // The actual logging instance used to write entries
    private static IOperationHolder<RequestTelemetry> AppRunTelemetry;

    public static bool AppInsightsEnabled { get; private set; }

    public static readonly AssemblyName AssemblyName = Assembly.GetExecutingAssembly().GetName();
    public static readonly string AppName = AssemblyName.Name;
    public static readonly string Version = AssemblyName.Version.ToString();
    public static readonly string SessionId = Guid.NewGuid().ToString();

    /// <summary>
    /// Starts the Application Insights logging functionality
    /// Note: this should be set on application startup *once*
    /// </summary>
    public static void InitializeLogging()
    {
        try
        {
            var connectionString = ChuchoBot.WinFormsApp.Properties.Settings.Default.AppInsightsConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                AppInsightsEnabled = false;
                return;
            }

            if (AppInsights == null)  // make sure doesn't run more than once!
            {
                AppInsightsEnabled = true;
                var config = new TelemetryConfiguration()
                {
                    // `Telemetry.Key` is a secret key in a static value loaded
                    //  from secure storage (from Azure Portal)
                    ConnectionString = connectionString
                };

                // Initialize App Insights
                AppInsights = new TelemetryClient(config);
                AppInsights.Context.Session.Id = SessionId;
                AppInsights.Context.Component.Version = Version;
                AppInsights.Context.User.AuthenticatedUserId = Environment.UserName;
                AppInsights.Context.Device.OperatingSystem = Environment.OSVersion.ToString();

                // Create the actual logging instance that will be used to log 
                AppRunTelemetry = AppInsights.StartOperation<RequestTelemetry>($"{AppName} - {Version}");
                AppRunTelemetry.Telemetry.Start();
            }
        }
        catch (Exception ex)
        {
            AppInsightsEnabled = false;
            LogLocal("Application Insights initialization failure: " +
                     ex.GetBaseException().Message, ex);
        }
    }

    /// <summary>
    /// Shuts down the Application Insights Logging functionality
    /// and flushes any pending requests.
    ///
    /// This handles start and stop times and the application lifetime
    /// log entry that logs duration of operation.
    /// </summary>
    public static void ShutdownLogging()
    {
        if (AppInsights != null && AppInsightsEnabled)
        {
            var t = AppRunTelemetry.Telemetry;

            t.Properties.Add("culture", CultureInfo.CurrentUICulture.IetfLanguageTag);
            t.Stop();

            try
            {
                AppInsights.StopOperation(AppRunTelemetry);
            }
            catch (Exception ex)
            {
                LogLocal("Failed to Stop Telemetry Client: " + ex.GetBaseException().Message, ex);
            }

            AppInsights.Flush();
            AppInsights = null;
            AppRunTelemetry.Dispose();
        }
    }

    private class TelemetryTimeTracker : IDisposable
    {
        private readonly Stopwatch _stopwatch;
        private readonly string _message;

        public TelemetryTimeTracker(string message)
        {
            _stopwatch = Stopwatch.StartNew();
            _message = message;
            LogInformation("Start " + message);
        }

        public void Dispose()
        {
            _stopwatch.Stop();
            LogInformation("Completed " + _message + " time elapsed: " + _stopwatch.ElapsedMilliseconds);
        }
    }

    public static IDisposable TrackTime(string msg)
    {
        return new TelemetryTimeTracker(msg);
    }

    public static void LogInformation(string msg)
    {
        Log(msg, logLevel: LogLevel.Information);
    }

    public static void LogWarning(string msg, Exception ex = null)
    {
        Log(msg, ex, false, LogLevel.Warning);
    }

    public static void LogError(string msg, Exception ex = null,
                           bool unhandledException = true)
    {
        Log(msg, ex, unhandledException, LogLevel.Error);
    }

    /// <summary>
    /// Logs messages to the standard log output for Markdown Monster:
    /// 
    /// * Application Insights
    /// * Local Log File
    /// 
    /// </summary>
    /// <param name="msg"></param>
    public static void Log(string msg, Exception ex = null,
                           bool unhandledException = false,
                           LogLevel logLevel = LogLevel.Error)
    {
        string winVersion = null;

        if (AppInsightsEnabled && AppRunTelemetry?.Telemetry != null)
        {
            var secs = (int)DateTimeOffset.UtcNow.Subtract(AppRunTelemetry.Telemetry.Timestamp).TotalSeconds;

            if (ex != null)
            {
                AppRunTelemetry.Telemetry.Success = false;
                AppInsights.TrackException(ex,
                    new Dictionary<string, string>
                    {
                        {"msg", msg},
                        {"exmsg", ex.Message},
                        {"exbasemsg", ex.GetBaseException().Message},
                        {"exsource", ex.Source},
                        {"extrace", ex.StackTrace},
                        {"extype", ex.GetType().ToString()},
                        {"severity", unhandledException ? "unhandled" : ""},
                        {"version", Version},
                        {"winversion", winVersion},
                        {"machine", Environment.MachineName },
                        {"culture", CultureInfo.CurrentCulture.IetfLanguageTag},
                        {"uiculture", CultureInfo.CurrentUICulture.IetfLanguageTag},
                        {"seconds", secs.ToString() },
                        {"level", ((int) logLevel).ToString() + " - " + logLevel.ToString()}
                    });

            }
            else
            {
                // message only
                var props = new Dictionary<string, string>()
                {
                    {"msg", msg},
                    {"version", Version},
                    {"culture", CultureInfo.CurrentCulture.IetfLanguageTag},
                    {"uiculture", CultureInfo.CurrentUICulture.IetfLanguageTag},
                    {"seconds", secs.ToString() },
                    {"level", ((int) logLevel).ToString() + " - " + logLevel.ToString() }
                };
                AppInsights.TrackTrace(msg, props);
            }
        }

        // also log to the local error log
        LogLocal(msg, ex);
    }

    public static void LogLocal(string message, Exception ex)
    {
        Console.Error.WriteLine(message, ex);
    }
}

public enum LogLevel
{
    Error,
    Information,
    Warning,
    Debug
}
