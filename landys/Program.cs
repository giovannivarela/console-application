internal class Program
{
    private static void Main()
    {
        Dictionary<string, EnergyCompany> cache = new Dictionary<string, EnergyCompany>();
        MenuController Menu = new MenuController();
        MenuOptionController Option = new MenuOptionController();

        Console.Clear();
        while (true)
        {
            try
            {
                MenuOptions menuOption = Menu.ShowMenu();
                if(menuOption == MenuOptions.Exit) break;
                Option.Act(menuOption, cache);
            }
            catch (Exception)
            {
                continue;
            }
        }
    }
}