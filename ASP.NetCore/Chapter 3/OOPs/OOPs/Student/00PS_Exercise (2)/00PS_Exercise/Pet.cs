using System.ComponentModel;
using _00PS_Exercise.Enum;

namespace _00PS_Exercise
{
    public class Pet
    {


        public int id;
        public string petname;
        public int ownerId;
        public PetCategory Category;



        public Pet(int id, string petname, int ownerid, PetCategory category)
        {
            this.id = id;
            this.petname = petname;
            this.ownerId = ownerid;
            this.Category = category;

        }
        public Pet() { }
        public static Pet[] petsarray = new Pet[5];

        public int petCount = 0;
       static Pet[] favorite = new Pet[3];
        public int favoriteCount = 0;

        public object Petcategory { get; private set; }

        public void PublicUserMenu(int userid)
        {
            while (true)
            {
                Console.WriteLine("1. Post Pet");
                Console.WriteLine("2. List Pets");
                Console.WriteLine("3. Add to favorites");
                Console.WriteLine("4.Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PostPet();
                        break;
                    case 2:
                        ListPets();
                        break;
                    case 3:
                        Addtofavorites();
                        break;
                    case 4:

                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
            void PostPet()
            {
                Pet pets = new Pet(id, petname, ownerId, Category);
                pets.id = petCount;
                Console.WriteLine("Enter pet name:");
                pets.petname = Console.ReadLine();
                int choice;
                bool chance = true;

                do
                {
                    Console.WriteLine("Choose a number Corresponding to Category from this  1.Dog\r\n    2.Cat\r\n    3.Bird\r\n    4.Fish\r\n    5.Reptile\r\n    6.Other ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: pets.Category = PetCategory.Dog; break;
                        case 2: pets.Category = PetCategory.Cat; break;
                        case 3: pets.Category = PetCategory.Bird; break;
                        case 4: pets.Category = PetCategory.Fish; break;
                        case 5: pets.Category = PetCategory.Reptile; break;
                        case 6: pets.Category = PetCategory.Other; break;
                        default:
                            Console.WriteLine("Invalid Choice please enter the choice");
                            break;

                    }

                } while (chance == false);
                petsarray[petCount] = pets;
                petCount++;
                Console.WriteLine("pet posted successfully");



            }
        }
        void ListPets()
        {
            Console.WriteLine("List of pets");
            for (int i = 0; i < petCount; i++)
            {
                Console.WriteLine(petsarray[i].petname);
                Console.WriteLine(petsarray[i].Category);
                Console.WriteLine(petsarray[i].id);




            }

        }








        void Addtofavorites()
        {
            
            Console.WriteLine("enter id:");
            int id = Convert.ToInt32(Console.ReadLine());
            // Find the pet by ID
            Pet selectedPet = null;
            for (int i = 0; i < petCount; i++)
            {
                if (petsarray[i].id == id)
                {
                    selectedPet = petsarray[i];
                    break;
                }
            }

            if (selectedPet == null)
            {
                Console.WriteLine("Pet not found.");
                return;
            }

            // Check if the pet is already in favorites
            for (int i = 0; i < favoriteCount; i++)
            {
                if (favorite[i].id == selectedPet.id)
                {
                    Console.WriteLine("This pet is already in your favorites.");
                    return;
                }
            }

            // Add to favorites
            favorite[favoriteCount] = selectedPet;
            favoriteCount++;

            Console.WriteLine($"Pet '{selectedPet.petname}' added to favorites.");

            
        }
    }
    }




