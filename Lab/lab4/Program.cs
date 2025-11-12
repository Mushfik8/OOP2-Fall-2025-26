
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== House Details Input ===");
        Console.Write("Enter the year the house was built: ");
        int yearBuilt = int.Parse(Console.ReadLine());

        Console.Write("Enter the size of the house: ");
        double size = double.Parse(Console.ReadLine());

        House myHouse = new House(yearBuilt, size);

        Console.WriteLine("\n---- House Information ----");
        Console.WriteLine($"Year Built: {myHouse.YearBuilt}");
        Console.WriteLine($"Size: {myHouse.Size} sq. units");
        Console.WriteLine($"Can be sold: {myHouse.CanBeSold()}");
    }
}
public class House
{
    public int YearBuilt { get; set; }
    public double Size { get; set; }

    public House(int yearBuilt, double size)
    {
        YearBuilt = yearBuilt;
        Size = size;
    }

    private int HowOld()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - YearBuilt;
    }

    public bool CanBeSold()
    {
        return HowOld() > 15;
    }
}


