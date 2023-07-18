using WebbingAssignment.Controllers;
using WebbingAssignment.Data.ActivityModels;

namespace WebbingAssignment.Log
{
    public class LogWriter
    {
        private readonly ILogger<ActivitiesController> _logger;

        public LogWriter(ILogger<ActivitiesController> logger)
        {
            _logger = logger;
        }

        public void WriteLogMessage<T>(T Type)
        {
            switch (Type)
            {
                case ExportActivity exportActivity:
                    _logger.Log(LogLevel.Information, $"Export {exportActivity.exportId}  - {exportActivity.exportName}  has created by {exportActivity.user}");
                    break;
                case PlanChangeActivity planChangeActivity:
                    _logger.Log(LogLevel.Information, $"The plan {planChangeActivity.planName} for SIM with ID {planChangeActivity.simId}, has changed by {planChangeActivity.user} ");
                    break;

                default:
                    break;
            }

        }
    }
}
