using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirstWithFK.Model
{
    internal class Mark
    {
        [Key]
        public int MarkId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        //Navigation property to the Student associated with these marks.
        public Student Student { get; set; }

        public int M1 { get; set; }
        public int M2 { get; set; }
        public int M3 { get; set; }

    }
}
