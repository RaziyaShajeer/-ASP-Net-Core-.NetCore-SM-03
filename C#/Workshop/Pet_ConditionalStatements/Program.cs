using Pet_ConditionalStatements.Enums;
using System;
using System.Runtime.ExceptionServices;

namespace Pet_ConditionalStatements
{
    public class Program
    {
        public struct Pet
        {
            public int id;
            public string petName;
            public PetCategory petCategory;
        }
            static void Main(string[] args)
            {
                Pet ob1 = new Pet();
                bool   chance=true;
                Console.WriteLine("Enter the id of the Pet");
                ob1.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name of the Pet");
                ob1.petName = Console.ReadLine();
                int choice;
                do
                {
                    Console.WriteLine("Choose a number Corresponding to Category from this  1.Dog\r\n    2.Cat\r\n    3.Bird\r\n    4.Fish\r\n    5.Reptile\r\n    6.Other ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    chance = true;
                    switch (choice)
                    { 
                        case 1: ob1.petCategory = PetCategory.Dog; break;
                        case 2: ob1.petCategory = PetCategory.Cat; break;
                        case 3: ob1.petCategory = PetCategory.Bird; break;
                        case 4: ob1.petCategory = PetCategory.Fish; break;
                        case 5: ob1.petCategory = PetCategory.Reptile; break;
                        case 6: ob1.petCategory = PetCategory.Other; break;
                        default: Console.WriteLine("Invalid Choice please renter the choice"); chance = false; break;

                    }

                } while (chance == false);
                Console.WriteLine("Pet Details are");
                Console.WriteLine("Pet ID :{0}", ob1.id);
                Console.WriteLine("Pet Name :{0}", ob1.petName);
                Console.WriteLine("Pet Category :{0}", ob1.petCategory);
                Console.ReadLine();
                

            }


        }
    }
