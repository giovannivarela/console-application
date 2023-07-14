public class UserInputProcessor : IUserInputProcessor
{
    public MenuOptions ProcessMenuInput(string input)
    {
        switch (int.Parse(input))
        {
            case 1:
                return MenuOptions.Insert;
            case 2:
                return MenuOptions.Edit;
            case 3:
                return MenuOptions.Delete;
            case 4:
                return MenuOptions.List;
            case 5:
                return MenuOptions.Find;
            case 6:
                return MenuOptions.Exit;
            default:
                return MenuOptions.InvalidOption;
        }
    }
}