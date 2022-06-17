namespace HostedService.HostedServices
{
    public class LogCurrentTimeHostedService : IHostedService
    {
        private readonly ILogger _logger;

        public LogCurrentTimeHostedService(ILogger<LogCurrentTimeHostedService> logger)
        {
            _logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{GetType().Name} is starting.");

            await Task.Delay(3000);
            _logger.LogInformation($"The current time is {DateTime.Now}.");

            _logger.LogInformation($"{GetType().Name} is finished doing its work in starting.");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{GetType().Name} is stopping.");

            await Task.Delay(3000);
            _logger.LogInformation($"The current time is {DateTime.Now}.");

            _logger.LogInformation($"{GetType().Name} is finished doing its work in stopping.");
        }
    }
}
