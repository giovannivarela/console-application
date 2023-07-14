public class MenuService : IMenuService
{
    UserInputProcessor InputProcessor;
    UserInputValidator InputValidator;

    public MenuService()
    {
        InputProcessor = new UserInputProcessor();
        InputValidator = new UserInputValidator();
    }

    public void ValidateMenuInput(string input)
    {
        if (!InputValidator.ValidateIntInput(input))
        {
            Console.WriteLine("Your option is invalid.");
            throw new Exception("Invalid operation");
        }
    }

    public MenuOptions ProcessMenuInput(string input)
    {
        MenuOptions processedInput = InputProcessor.ProcessMenuInput(input);

        if (processedInput == MenuOptions.InvalidOption)
        {
            Console.WriteLine("Your option is invalid.");
            throw new Exception("Invalid operation");
        }

        return processedInput;
    }
}