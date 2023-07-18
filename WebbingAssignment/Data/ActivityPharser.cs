using WebbingAssignment.Data.ActivityModels;

namespace WebbingAssignment.Data
{
    public static class ActivityPharser
    {

        public static ActivityBaseModel ParseActivity(ActivityType activityType, object reqData)
        {
            ActivityBaseModel activity;

            switch (activityType)
            {
                case ActivityType.PlanChange:
                    activity = new PlanChangeActivity();
                    break;
                case ActivityType.Export:
                    activity = new ExportActivity();
                    break;
                default: throw new ArgumentException("Invalid Activity type or data provided.");
            }


            


            throw new ArgumentException("Invalid Activity type or data provided.");
        }

    }
}
