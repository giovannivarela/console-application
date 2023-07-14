public class EditStrategy : MenuOptionsStrategy
{
    PrinterHelper print = new PrinterHelper();
    UserInputValidator InputValidator = new UserInputValidator();

    public override void Act(Dictionary<string, EnergyCompany> cache)
    {
        Console.WriteLine("\nEnter the serial number: ");
        var serialNumber = Console.ReadLine() ?? "";
        EnergyCompany? oldObject;
        bool found = cache.TryGetValue(serialNumber, out oldObject);
        if (!found)
        {
            Console.WriteLine("\nSerial number not found.");
            return;
        }

        Console.WriteLine("\nSerial number found: ");
        print.PrintEnergyCompany(oldObject);

        Console.WriteLine("\nEnter the switch status: ");
        Console.WriteLine("1 - Disconnected");
        Console.WriteLine("2 - Connected");
        Console.WriteLine("3 - Armed");
        var newSwitchStatus = InputValidator.ValidateSwitchStatus(Console.ReadLine() ?? "");

        EnergyCompany newObject = new EnergyCompany(oldObject.EndpointSerialNumber, oldObject.MeterModelId, oldObject.MeterNumber, oldObject.MeterFirmwareVersion, newSwitchStatus);
        cache.Add(serialNumber, newObject);

        Console.WriteLine($"\nEdited energy company with the serial number: {newObject.EndpointSerialNumber}");
        print.PrintEnergyCompany(newObject);
    }
}