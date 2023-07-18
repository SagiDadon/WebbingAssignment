namespace WebbingAssignment.Data.ActivityModels
{
    [Serializable]
    public class PlanChangeActivity : ActivityBaseModel
    {

        public string simId { get; set; }
        public string planName { get; set; }

        //add more props if needed
    }
}
