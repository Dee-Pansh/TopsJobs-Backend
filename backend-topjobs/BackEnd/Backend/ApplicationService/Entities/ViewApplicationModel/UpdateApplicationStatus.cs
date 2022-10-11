namespace ApplicationService.Entities.ViewApplicationModel
{
    public class UpdateApplicationStatus
    {
        public int applicantId { get; set; }
        public int jobId { get; set; }
        public string status { get; set; }
    }
}
