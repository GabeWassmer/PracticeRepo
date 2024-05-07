public class AgeCalculator
{
    public static int CalculateAgeInDays()
    {
        Console.WriteLine("Enter your birthday (YYYY-MM-DD):");
        DateTime birthday;
        while (!DateTime.TryParse(Console.ReadLine(), out birthday))
        {
            Console.WriteLine("Invalid date format. Please enter your birthday in the format YYYY-MM-DD:");
        }

        TimeSpan ageInDays = DateTime.Now - birthday;
        return ageInDays.Days;
    }

    public static void Main(string[] args)
    {
        int ageInDays = CalculateAgeInDays();
        Console.WriteLine($"Your age in days is: {ageInDays} days.");
    }
}
