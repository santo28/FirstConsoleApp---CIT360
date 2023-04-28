// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Marvin Santos";
        string location = "Peru";

        Console.WriteLine($"My Name is {name}");

        Console.WriteLine($"I am from {location}");

        // Print the Current Date
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("MM/dd/yyyy");
        Console.WriteLine(formattedDate);


        DateTime christmasDay = new DateTime(DateTime.Now.Year, 12, 25);
        TimeSpan timeUntilChristmas = christmasDay - DateTime.Now;
        int daysUntilChristmas = (int)timeUntilChristmas.TotalDays;

        Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");



        double width, height, woodLength, glassArea;

        string widthString, heightString;

        Console.WriteLine("Please Enter the width: ");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.WriteLine("Please Enter the height: ");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);


        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " +
        woodLength + " feet");

        Console.WriteLine("The area of the glass is " +
        glassArea + " square meters");

        Console.WriteLine("To exit the program press any Key");
        Console.ReadKey();

    }
}




