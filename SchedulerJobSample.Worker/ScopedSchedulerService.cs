using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SchedulerJobSample.Worker
{
    public interface IScopedSchedulerService
    {
        Task ExecuteAsync(CancellationToken cancellationToken);
    }

    public class ScopedSchedulerService : IScopedSchedulerService
    {
        private readonly ILogger<ScopedSchedulerService> _logger;

        public ScopedSchedulerService(ILogger<ScopedSchedulerService> logger)
        {
            _logger = logger;
        }

        public Task ExecuteAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            return Task.CompletedTask;
        }
    }
}