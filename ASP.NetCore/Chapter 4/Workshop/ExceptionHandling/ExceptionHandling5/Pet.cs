using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling5
{
    internal class Pet
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public string Breed {  get; set; }
        public string Age {  get; set; }
        public Pet() { }
        public Pet(string id, string name, string breed, string age)
        {
            Id = id;
            Name = name;
            Breed = breed;
            Age = age;
        }
    }
}
