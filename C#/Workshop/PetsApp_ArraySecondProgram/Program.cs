using PetsApp_ArraySecondProgram.Enums;
using System;
using System.Threading.Channels;

namespace PetsApp_ArraySecondProgram
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
            Pet[] pets=new Pet[10];
            Console.WriteLine("How many pet Names you want to add to the array");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Pet pet = new Pet();
                pet.id = i + 1;
                Console.WriteLine("Enter the name of {0}th Pet ", i + 1);
                pet.petName = Console.ReadLine();
                Console.WriteLine("Enter the  of {0}th Pet ", i + 1);
                int choice;
                bool chance = true;
                do
                {
                    Console.WriteLine("Choose a number Corresponding to Category from this  \n1.Dog\n2.Cat\n3.Bird\n4.Fish\n5.Reptile\n6.Other");
                    choice = Convert.ToInt32(Console.ReadLine());
                    chance = true;
                    switch (choice)
                    {
                        case 1: pet.petCategory = PetCategory.Dog; break;
                        case 2: pet.petCategory = PetCategory.Cat; break;
                        case 3: pet.petCategory = PetCategory.Bird; break;
                        case 4: pet.petCategory = PetCategory.Fish; break;
                        case 5: pet.petCategory = PetCategory.Reptile; break;
                        case 6: pet.petCategory = PetCategory.Other; break;
                        default: Console.WriteLine("Invalid Choice please renter the choice"); chance = false; break;
                    }

                } while (chance == false);
                pets[i] = pet;
            }
            Console.WriteLine("Pet Details are");
            foreach (var pet in pets)
            {
                if(pet.petName!=null)
                {
                    Console.WriteLine("--------------{0}-----------------", pet.petName);

                    Console.WriteLine("Pet Id:{0}",pet.id);
                    Console.WriteLine("Pet Name:{0}",pet.petName);
                    Console.WriteLine("Pet Category:{0}",pet.petCategory);
                }
                   
            }
            Console.ReadLine();
        }
    }
}