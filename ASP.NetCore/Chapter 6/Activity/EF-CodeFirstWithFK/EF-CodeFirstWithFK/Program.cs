using EF_CodeFirstWithFK.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        var context = new StudentAppDbContext();
        

            while (true)
            {
                Console.WriteLine("\nChoose Operation:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Add Marks");
                Console.WriteLine("6. View Marks");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddStudent(); break;
                    case 2: ViewStudents(); break;
                    case 3: UpdateStudent(); break;
                    case 4: DeleteStudent(); break;
                    case 5: AddMarks(); break;
                    case 6: ViewMarks(); break;
                    case 7: return;
                    default: Console.WriteLine("Invalid choice."); break;
                }
            }
        }
    

    static void AddStudent()
    {
        var context = new StudentAppDbContext();
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Mobile No: ");
            string mobile = Console.ReadLine();

            var student = new Student { Name = name, MobileNo = mobile };
            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine("Student Added Successfully!");
        }
    }

    static void ViewStudents()
    {
        var context = new StudentAppDbContext();
        {
            var students = context.Students.ToList();
            Console.WriteLine("\nStudents List:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Mobile: {student.MobileNo}");
            }
        }
    }

    static void UpdateStudent()
    {
        var context = new StudentAppDbContext();
        {
            Console.Write("Enter Student ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var student = context.Students.Find(id);

            if (student == null)
            {
                Console.WriteLine("Student Not Found!");
                return;
            }

            Console.Write("Enter New Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter New Mobile No: ");
            student.MobileNo = Console.ReadLine();

            context.SaveChanges();
            Console.WriteLine("Student Updated Successfully!");
        }
    }

    static void DeleteStudent()
    {
        var context = new StudentAppDbContext();
        {
            Console.Write("Enter Student ID to delete: ");
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

    static void AddMarks()
    {
        var context = new StudentAppDbContext();
        {
            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            var student = context.Students.Find(studentId);

            if (student == null)
            {
                Console.WriteLine("Student Not Found!");
                return;
            }

            Console.Write("Enter Mark1: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark2: ");
            int m2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Mark3: ");
            int m3 = int.Parse(Console.ReadLine());

            var mark = new Mark { StudentId = studentId, M1 = m1, M2 = m2, M3 = m3 };
            context.Marks.Add(mark);
            context.SaveChanges();
            Console.WriteLine("Marks Added Successfully!");
        }
    }

    static void ViewMarks()
    {
        var context = new StudentAppDbContext();
        {
            var marks = context.Marks.ToList();
            Console.WriteLine("\nMarks List:");
            foreach (var mark in marks)
            {
                Console.WriteLine($"Mark ID: {mark.MarkId}, Student ID: {mark.StudentId}, M1: {mark.M1}, M2: {mark.M2}, M3: {mark.M3}");
            }
        }
    }
}

   