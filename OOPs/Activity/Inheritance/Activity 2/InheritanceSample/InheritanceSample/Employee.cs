using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    internal class Employee : Person
    {
        public int? Id {  get; set; }
        public string? Position { get; set; }

        public string GetEmployee()
        {
            //Console.WriteLine("ID : {0}",Id);
            //Console.WriteLine("FirstName : {0}", FirstName);
            //Console.WriteLine("Last Name :{0}", LastName);
            //Console.WriteLine("Position : {0}", Position);
            //Console.WriteLine("Age : {0}", Age);
            return $"ID:{Id} FullName:{FirstName} {LastName} Position:{Position} Age:{Age}";
            
        }

        public Employee() : base()
        {
            Id = 001;
            Position = "Java Developer";
        }

        public Employee(string firstName, string lastName, int age, int id, string position) : base(firstName,lastName,age)
        
            {
                
                Id = id;
                Position = position;

            }
        
    }
}
