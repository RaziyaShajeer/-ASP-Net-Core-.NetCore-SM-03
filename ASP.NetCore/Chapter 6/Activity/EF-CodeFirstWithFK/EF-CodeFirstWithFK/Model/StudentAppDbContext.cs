using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirstWithFK.Model
{
    internal class StudentAppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=AFRA;Initial Catalog=CodeFirstFK;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
