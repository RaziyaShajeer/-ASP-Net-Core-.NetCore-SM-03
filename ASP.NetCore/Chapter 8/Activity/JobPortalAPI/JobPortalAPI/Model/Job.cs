using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Model
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Company { get; set; }

        public decimal Salary { get; set; }
        public string Location { get; set; }
        public DateTime PostedDate { get; set; } = DateTime.UtcNow;
    }
}
