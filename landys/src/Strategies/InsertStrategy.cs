public class InsertStrategy : MenuOptionsStrategy
{
    UserInputValidator InputValidator = new UserInputValidator();
    PrinterHelper print = new PrinterHelper();

    public override void Act(Dictionary<string, EnergyCompany> cache)
    {
        Console.WriteLine("\nEnter the serial number: ");
        var serialNumber = Console.ReadLine() ?? "";
        EnergyCompany objectToInsert;
        bool found = cache.TryGetValue(serialNumber, out objectToInsert);
        if (found)
        {
            Console.WriteLine("\nAn energy company with the same serial number already exists.");
            return;
        }

        Console.WriteLine("\nEnter the meter model: ");
        Console.WriteLine("1 - NSX1P2W");
        Console.WriteLine("2 - NSX1P3W");
        Console.WriteLine("3 - NSX2P3W");
        Console.WriteLine("4 - NSX3P4W");
        var meterModel = InputValidator.ValidateMeterModelId(Console.ReadLine() ?? "");

        Console.WriteLine("\nEnter the meter number: ");
        var meterNumberInput = Console.ReadLine() ?? "";
        if (!InputValidator.ValidateIntInput(meterNumberInput))
        {
            Console.WriteLine("\nInvalid input;");
            return;
        }
        int meterNumber = int.Parse(meterNumberInput);

        Console.WriteLine("\nEnter the meter firmware version: ");
        var meterFirmwareVersion = Console.ReadLine() ?? "";

        Console.WriteLine("\nEnter the switch status: ");
        Console.WriteLine("1 - Disconnected");
        Console.WriteLine("2 - Connected");
        Console.WriteLine("3 - Armed");
        var switchStatus = InputValidator.ValidateSwitchStatus(Console.ReadLine() ?? "");

        objectToInsert = new EnergyCompany(serialNumber, meterModel, meterNumber, meterFirmwareVersion, switchStatus);
        cache.Add(serialNumber, objectToInsert);

        Console.WriteLine($"\nInserted new energy company with the serial number: {objectToInsert.EndpointSerialNumber}");
        print.PrintEnergyCompany(objectToInsert);
    }
}