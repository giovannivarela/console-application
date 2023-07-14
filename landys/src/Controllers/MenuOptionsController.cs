using System.Runtime.Caching;

public class MenuOptionController : IMenuOptionController
{
    private MenuOptionService service = new MenuOptionService();

    public void Act(MenuOptions userInput, Dictionary<string, EnergyCompany> Cache)
    {
        service.Act(userInput, Cache);
    }
}