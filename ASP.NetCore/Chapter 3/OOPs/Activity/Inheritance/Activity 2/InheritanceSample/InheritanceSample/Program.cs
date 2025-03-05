namespace InheritanceSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Linoy","Biju",34);
            Person person2 = new Person();
            Employee employee1 = new Employee("Megha","Raj",24,004, "Data Analyst");
            Employee employee2=new Employee();
            //Console.WriteLine($"FullName :{person1.GetFullName()}, Age:{person1.Age}");
            //Console.WriteLine($"FullName:{person2.GetFullName()}, Age : {person2.Age}");
            Console.WriteLine("FullName : {0} Age : {1}", person1.GetFullName(),person1.Age);
            Console.WriteLine("FullName : {0} Age : {1}", person2.GetFullName(), person2.Age);

            Console.WriteLine($"Employee Details : {employee1.GetEmployee()}");
            Console.WriteLine($"Employee Details : {employee2.GetEmployee()}");

            




        }
    }
}