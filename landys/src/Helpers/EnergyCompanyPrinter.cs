using Newtonsoft.Json;

public class PrinterHelper : IPrinterHelper
{
    public void PrintEnergyCompany(EnergyCompany company)
    {
        Console.WriteLine(JsonConvert.SerializeObject(company, Formatting.Indented));
    }
}
