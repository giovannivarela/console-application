using Microsoft.Extensions.Caching.Memory;

public class DeleteStrategy : MenuOptionsStrategy
{
    PrinterHelper print = new PrinterHelper();

    public override void Act(Dictionary<string, EnergyCompany> cache)
    {
        Console.WriteLine("\nEnter the serial number: ");
        var serialNumber = Console.ReadLine() ?? "";
        EnergyCompany? objectToDelete;
        bool found = cache.TryGetValue(serialNumber, out objectToDelete);
        if (!found)
        {
            Console.WriteLine("\nSerial number not found.");
            return;
        }

        Console.WriteLine("\nSerial number found. Should it be deleted? ");
        Console.WriteLine("1 - Yes");
        Console.WriteLine("2 - No");
        print.PrintEnergyCompany(objectToDelete);
        var confirmation = Console.ReadLine();

        if (confirmation == "1")
        {
            cache.Remove(serialNumber);
            Console.WriteLine("\nEnergy company deleted");
        }
        else
        {
            Console.WriteLine("\nOperation canceled. Energy company not deleted.");
        }
    }
}