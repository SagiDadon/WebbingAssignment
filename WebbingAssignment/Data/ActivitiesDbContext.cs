using Microsoft.EntityFrameworkCore;
using WebbingAssignment.Data.ActivityModels;

namespace WebbingAssignment.Data
{
    public class ActivitiesDbContext : DbContext
    {
        public ActivitiesDbContext(DbContextOptions<ActivitiesDbContext> options) : base(options) { }

        // DbSet for your Activities models
        public DbSet<PlanChangeActivity> PlanChangeActivity { get; set; }
        public DbSet<ExportActivity> ExportActivity { get; set; }
    }
}
