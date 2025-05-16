using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string Genre { get; set; }

        public int PublishedYear { get; set; }
    }
}
