using System;
using _00PS_Exercise.Enum;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _00PS_Exercise
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }

        public User(int id, string username, string email, string password, Role role)
        {
            Id = id;
            UserName = username;
            Email = email;
            Password = password;
            UserRole = role;
        }
        public User() { }
        public static User[] user = new User[10];
        static int usercount = 0;
        
        public Role roles;

        public void DisplayInfo()
        {
            while (true)
            {
                Console.WriteLine("1.Register");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Registeruser();
                        break;
                    case 2:
                        Loginuser();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            void Registeruser()
            {
                Console.WriteLine("User Registration...");
                User users = new User();
                int id = usercount++;
                Console.Write("Enter your name:");
                string name = Console.ReadLine();
                Console.Write("Enter your email:");
                string email = Console.ReadLine();
                Console.Write("Enter your password:");
                string password = Console.ReadLine();
                
                Console.Write("choose Role:");
                Console.WriteLine("1.Admin");
                Console.WriteLine("2.Public user");
                Console.WriteLine("Enter choice(1/2):");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                          roles = Role.Admin;
                        break;
                    case 2:
                         roles = Role.PublicUser;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }


                users= new User(id,name,email,password,roles);
                user[usercount] = users;
                usercount++;
                Console.WriteLine("user registered successfully!");

            }
            void Loginuser()
            {
                Console.Write("Enter your mail:");
                string mail = Console.ReadLine();
                Console.Write("Enter your password:");
                string password = Console.ReadLine();
                for(int i = 0; i < usercount; i++)
                {
                    if (user[i]!=null && user[i].Email == mail && user[i].Password == password)
                    {
                        Console.WriteLine($"Welcome,{user[i].UserName}");
                        Pet pet=new Pet();
                        pet.PublicUserMenu(user[i].Id);
                       
                    }
                }
               
            }
           
            }


        }
    }







        





    

    


