using System.ComponentModel.DataAnnotations;

namespace WebbingAssignment.Data.ActivityModels
{
    public enum ActivityType
    {
        PlanChange,
        Export
    }

    public class ActivityBaseModel
    {
        public string Id { get; set; }
        public string user { get; set; }
    }
}

