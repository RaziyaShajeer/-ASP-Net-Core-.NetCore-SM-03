using ExceptionHandling5.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling5.Category
{
    public class Dog
    {
        List<Pet> dogs=new List<Pet>();
        public void   DisplayMenu()
        {
            try
            {
                Console.WriteLine("Enter your choice\n1.Add Pet\n2.List Pet");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddPet();
                        DisplayMenu();
                        break;
                    case 2:
                        ListPet();
                        DisplayMenu();
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                DisplayMenu();
            }
        }
        public void AddPet()
        {
            try
            {
                Console.WriteLine("Enter Pet Id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Pet Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Breed:");
                string breed = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                string age = Console.ReadLine();

                Pet newPet = new Pet
                {
                    Id = id,
                    Name = name,
                    Breed = breed,
                    Age = age,

                };
                if(dogs.Any(p=>p.Id==newPet.Id))
                { 
                throw new PetAlreadyExistsException();
                }
                dogs.Add(newPet);
            }
            catch (Exception PetAlreadyExistsException) 
            {
                Console.WriteLine(PetAlreadyExistsException.Message);
            }

        }
        public  void ListPet() 
        {
            Console.WriteLine("PetList");
            foreach(var pet in dogs)
            {

                Console.WriteLine($"ID: {pet.Id}, Name: {pet.Name}, Age: {pet.Age}, Breed: {pet.Breed}");

            }

        }
       
       
    }
}
