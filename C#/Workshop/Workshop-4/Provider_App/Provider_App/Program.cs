
namespace Provider_App // Note: actual namespace depends on the project name.
{
    public class Program
    {
        struct JobProvider
        {
            public string CompanyName;
            public string Email;
            public string Phone;
            public string Password;
            public string JobRole;
            public string Salary;
            public int ExperienceRequired;
        }

        static JobProvider[] jobprovider = new JobProvider[5];
        static JobProvider loggedinUser;
        static int userCount = 0;
        static void Main(string[] args)
        {


            string ch;
            do
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("Choose the option you want to from below:");
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register as a new JobProvider");
                Console.WriteLine("****************************************");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Login();
                        break;

                    case "2":
                        Register();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Do you want to continue (Y/N)");
                ch = Console.ReadLine();
            }
            while (ch == "y" || ch == "Y");

            }


        static void Login()
        {
            Console.WriteLine("****************************************");

            Console.WriteLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("****************************************");

            bool loginSuccessfull = false;

            foreach (JobProvider jp in jobprovider)
            {
                if (jp.Email == email && jp.Password == password)
                {
                    loginSuccessfull = true;
                    loggedinUser = jp;

                    Console.WriteLine("Login Successfull");
                    Console.WriteLine();
                    Console.WriteLine("Here are your details:");
                    Console.WriteLine("CompanyName:{0}", loggedinUser.CompanyName);
                    Console.WriteLine("Email:{0}", loggedinUser.Email);
                    Console.WriteLine("Password:{0}", loggedinUser.Password);
                    Console.WriteLine("Salary:{0}", jp.Salary);
                    Console.WriteLine("ExperienceRequired:{0}", jp.ExperienceRequired);
                    Console.WriteLine("JobRole:{0}", jp.JobRole);
                    Console.WriteLine("Phone:{0}", loggedinUser.Phone);
                    Console.WriteLine();

                }
                /*    else
                    {
                        Console.WriteLine("Login Error!");
                    }*/
            }

        }
        static void Register()
        {
            JobProvider jobProvider = new JobProvider();

            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.WriteLine("Enter CompanyName:");
            jobProvider.CompanyName = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            jobProvider.Email = Console.ReadLine();

            Console.WriteLine("Enter Phone:");
            jobProvider.Phone = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            jobProvider.Password = Console.ReadLine();



            Console.WriteLine("Enter JobRole:");
            jobProvider.JobRole = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            jobProvider.Salary = Console.ReadLine();

            Console.WriteLine("Enter ExperienceRequired:");
            jobProvider.ExperienceRequired = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("****************************************");

            jobprovider[userCount] = jobProvider;
            userCount++;
        }
    }
}
