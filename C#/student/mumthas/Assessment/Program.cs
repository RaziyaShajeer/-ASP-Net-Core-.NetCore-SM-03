internal class Program
{
    private static void Main(string[] args)
    {
        double[] temperatures = new double[7];
        Console.WriteLine("Enter the temperatures for the week(7 days)");
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Day{i + 1}:");
            temperatures[i] = Convert.ToDouble(Console.ReadLine());
        }
        double sum = 0;
        foreach (double temp in temperatures)
        {
            sum += temp;
        }
        double averagetemperature = sum / temperatures.Length;
        double highesttemperature = temperatures[0];
        double lowesttemperature = temperatures[0];
        foreach (double temp in temperatures)
        {
            if (temp > highesttemperature)
            {
                highesttemperature = temp;
                if (temp < lowesttemperature)

                    lowesttemperature = temp;
            }
        }
            Console.WriteLine($"Average temperature is:{averagetemperature}c");
            Console.WriteLine($"Highest temperature is:{highesttemperature}c");
            Console.WriteLine($"Lowest temperature is:{lowesttemperature}c");
        
       
    }
}