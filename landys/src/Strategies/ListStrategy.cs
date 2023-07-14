public class ListStrategy : MenuOptionsStrategy
{
    PrinterHelper print = new PrinterHelper();

    public override void Act(Dictionary<string, EnergyCompany> cache)
    {
        cache.Values.ToList().ForEach(value =>
        {
            print.PrintEnergyCompany(value);
        });
    }
}