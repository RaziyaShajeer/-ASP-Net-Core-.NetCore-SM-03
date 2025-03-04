using EmailValidation;
using EmailValidation.Exception;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            EmailValidator.ValidateEmail(email);
            Console.WriteLine("Valid email.");
        }
        catch (InvalidEmailException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}