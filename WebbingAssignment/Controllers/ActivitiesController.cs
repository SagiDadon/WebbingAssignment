using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using WebbingAssignment.Data;
using WebbingAssignment.Data.ActivityModels;
using WebbingAssignment.Log;
using WebbingAssignment.RequestObjects;

namespace WebbingAssignment.Controllers
{
    [ApiController]
    [Route("api/WebbingActivityLogger")]
    public class ActivitiesController : ControllerBase
    {
        private readonly ActivitiesDbContext _dbContext;
        private readonly LogWriter _logWriter;


        public ActivitiesController(ActivitiesDbContext dbContext, ILogger<ActivitiesController> logger)
        {
            _dbContext = dbContext;
            
            _dbContext.Database.EnsureCreated();

            _logWriter = new LogWriter(logger);
        }

        [HttpPost("/LogActivity")]
        public async Task<IActionResult> LogActivity(ActivityType activityType, [FromBody] object Activity)
        {

            if (ModelState.IsValid)
            {
                switch (activityType)
                {
                    case ActivityType.Export:

                        ExportActivity exportActivity = JsonConvert.DeserializeObject<ExportActivity>(Activity.ToString());
                        _dbContext.Add(exportActivity);
                        _logWriter.WriteLogMessage(exportActivity);
                        break;

                    case ActivityType.PlanChange:
                        PlanChangeActivity planChangeActivity = JsonConvert.DeserializeObject<PlanChangeActivity>(Activity.ToString());
                        _dbContext.Add(planChangeActivity);
                        _logWriter.WriteLogMessage(planChangeActivity);
                        break;

                    default:
                        return BadRequest();
                }

                _dbContext.SaveChangesAsync();

                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        

        
    }
}