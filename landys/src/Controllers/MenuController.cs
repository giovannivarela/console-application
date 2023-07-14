public class MenuController : IMenuController
{
    MenuService service;

    public MenuController()
    {
        service = new MenuService();
    }

    public MenuOptions ShowMenu()
    {
        try
        {
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("Hello. Please type an option:");
            Console.WriteLine("1 - Insert");
            Console.WriteLine("2 - Edit");
            Console.WriteLine("3 - Delete");
            Console.WriteLine("4 - List");
            Console.WriteLine("5 - Find");
            Console.WriteLine("6 - Exit");
            var input = Console.ReadLine() ?? "";
            service.ValidateMenuInput(input);
            MenuOptions processedInput = service.ProcessMenuInput(input);
            Console.WriteLine($"Your input was: {processedInput}");
            return processedInput;
        }
        catch (Exception)
        {
            throw;
        }
    }
}