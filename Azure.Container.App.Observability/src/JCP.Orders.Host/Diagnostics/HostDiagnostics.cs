namespace JCP.Orders.Host.Diagnostics
{
    public partial class HostDiagnostics
    {
        private const string Message = "Log data: {data} ";


        private readonly ILogger _logger;
        public HostDiagnostics(ILoggerFactory loggerFactory)
        {
            _ = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
            _logger = loggerFactory.CreateLogger("Host");
        }
 
        [LoggerMessage(Level = LogLevel.Information, Message = Message)]
        public partial void OnGetWeatherForecast(string data);
    }
}
