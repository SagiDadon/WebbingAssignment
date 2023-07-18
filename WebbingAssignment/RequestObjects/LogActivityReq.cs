using WebbingAssignment.Data.ActivityModels;

namespace WebbingAssignment.RequestObjects
{
    public class LogActivityReq
    {
        public string simId { get; set;}
        public string user { get; set;}
        public object Activity { get; set;}
    }
}
