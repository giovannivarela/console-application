public class FindStrategy : MenuOptionsStrategy
{
    PrinterHelper print = new PrinterHelper();

    public override void Act(Dictionary<string, EnergyCompany> cache)
    {
        Console.WriteLine("\nEnter the serial number: ");
        var serialNumber = Console.ReadLine() ?? "";
        EnergyCompany? objectToInsert;
        bool found = cache.TryGetValue(serialNumber, out objectToInsert);
        if (!found)
        {
            Console.WriteLine("\nSerial number not found.");
            return;
        }

        Console.WriteLine("\nSerial number found: ");
        print.PrintEnergyCompany(objectToInsert);
    }
}