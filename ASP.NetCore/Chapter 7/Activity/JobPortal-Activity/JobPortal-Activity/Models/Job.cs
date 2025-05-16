namespace JobPortal_Activity.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public string Description { get; set; }
    }
}
