using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirstWithFK.Model
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string MobileNo { get; set; }

        /* Navigation property that holds a collection of Mark objects 
         related to the student. It's initialized as an empty list to 
        ensure it doesn't become null.*/
        public ICollection<Mark> Marks { get; set; } = new List<Mark>();

    }
}
/*This setup models a one-to-many relationship between students and their
marks (a student can have multiple marks). The Mark class includes a foreign
key (StudentId) to represent that relationship.*/