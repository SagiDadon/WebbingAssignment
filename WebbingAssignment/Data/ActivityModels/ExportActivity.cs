namespace WebbingAssignment.Data.ActivityModels
{
    [Serializable]
    public class ExportActivity : ActivityBaseModel
    {
        public string exportId { get; set; }
        public string exportName { get; set; }

        //add more props if needed
    }
}
