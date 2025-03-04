using System;
using UserAlreadyExist_Exception.Exception;
using UserAlreadyExist_Exception.Model;

namespace UserRegistrationLoginSystem
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an array to store up to 5 users
            User[] users = new User[5];
            int userCount = 0;

            while (true)
            {
                Console.WriteLine("Choose an option:\n1. Register\n2. Login\n3. Exit");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    // Registration process
                    try
                    {
                        if (userCount >= users.Length)
                        {
                            Console.WriteLine("User limit reached. Cannot register more users.");
                            continue;
                        }

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();

                        // Check if the email already exists
                        for (int i = 0; i < userCount; i++)
                        {
                            if (users[i].Email == email)
                            {
                                throw new EmailAlreadyExistsException("Email ID already exists. Please use a different one.");
                            }
                        }

                        Console.Write("Enter Age: ");
                        int age = int.Parse(Console.ReadLine());

                        // Check age using custom exception
                        if (age < 18)
                        {
                            throw new AgeException("You must be at least 18 years old to register.");
                        }

                        // Add user to the array
                        users[userCount] = new User { Name = name, Email = email, Age = age };
                        userCount++;

                        Console.WriteLine("Registration successful!");
                    }
                    catch (AgeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (EmailAlreadyExistsException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                   
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
                else if (option == "2")
                {
                    // Login process
                    Console.Write("Enter Email to Login: ");
                    string loginEmail = Console.ReadLine();

                    bool foundUser = false;

                    for (int i = 0; i < userCount; i++)
                    {
                        if (users[i].Email == loginEmail)
                        {
                            foundUser = true;
                            Console.WriteLine($"Login successful! Welcome, {users[i].Name}.");
                            break;
                        }
                    }

                    if (!foundUser)
                    {
                        Console.WriteLine("Email not found. Please register first.");
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                }
            }
        }
    }
}
