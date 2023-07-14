public interface IMenuService
{
    public void ValidateMenuInput(string input);
    public MenuOptions ProcessMenuInput(string input);
}