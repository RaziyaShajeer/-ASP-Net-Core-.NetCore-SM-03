using PhoneNumberValidation.Exception;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            ValidatePhoneNumber(phoneNumber);
            Console.WriteLine("Phone number is valid.");
        }
        //catch (InvalidPhoneNumberException ex)
        //{
        //    Console.WriteLine($"Error: {ex.Message}");
        //}
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    public static void ValidatePhoneNumber(string phoneNumber)
    {
        // Regular expression pattern for a valid phone number (basic validation)
        string pattern = @"^\+?[1-9]\d{9,14}$"; // Allows international format
        if (!Regex.IsMatch(phoneNumber, pattern))
        {
            throw new InvalidPhoneNumberException("Invalid phone number format.");
        }
    }
}