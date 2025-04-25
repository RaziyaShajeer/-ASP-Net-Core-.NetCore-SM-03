using EF_CodeFirst.Model;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("\nCRUD Operations:");
            Console.WriteLine("1. Create Student");
            Console.WriteLine("2. Read Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateStudent();
                    break;
                case "2":
                    ReadStudents();
                    break;
                case "3":
                    UpdateStudent();
                    break;
                case "4":
                    DeleteStudent();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid Option! Try again.");
                    break;
            }
        }
    }

    static void CreateStudent()
    {
         var context = new StudentAppDbContext();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        var student = new Student { Name = name, Age = age };
        context.Students.Add(student);
        context.SaveChanges();

        Console.WriteLine("Student Added Successfully!");
    }

    static void ReadStudents()
    {
         var context = new StudentAppDbContext();

        var students = context.Students.ToList();
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("Students List:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }

    static void UpdateStudent()
    {
         var context = new StudentAppDbContext();

        Console.Write("Enter Student ID to Update: ");
        int id = int.Parse(Console.ReadLine());

        var student = context.Students.Find(id);
        if (student == null)
        {
            Console.WriteLine("Student Not Found!");
            return;
        }

        Console.Write("Enter New Name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter New Age: ");
        student.Age = int.Parse(Console.ReadLine());

        context.SaveChanges();
        Console.WriteLine("Student Updated Successfully!");
    }

    static void DeleteStudent()
    {
         var context = new StudentAppDbContext();

        Console.Write("Enter Student ID to Delete: ");
        int id = int.Parse(Console.ReadLine());

        var student = context.Students.Find(id);
        if (student == null)
        {
            Console.WriteLine("Student Not Found!");
            return;
        }

        context.Students.Remove(student);
        context.SaveChanges();
        Console.WriteLine("Student Deleted Successfully!");
    }

}
