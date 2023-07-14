public class MenuOptionService : IMenuOptionService
{
    private Dictionary<MenuOptions, MenuOptionsStrategy> strategies = new Dictionary<MenuOptions, MenuOptionsStrategy>() {
        {MenuOptions.Insert, new InsertStrategy()},
        {MenuOptions.Edit, new EditStrategy()},
        {MenuOptions.Delete, new DeleteStrategy()},
        {MenuOptions.List, new ListStrategy()},
        {MenuOptions.Find, new FindStrategy()}
    };

    public void Act(MenuOptions userInput, Dictionary<string, EnergyCompany> Cache)
    {
        strategies[userInput].Act(Cache);
    }
}