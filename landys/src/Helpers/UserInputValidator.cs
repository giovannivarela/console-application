public class UserInputValidator : IUserInputValidator
{
    public bool ValidateIntInput(string input)
    {
        int option;
        return int.TryParse(input, out option);
    }

    public MeterModelId ValidateMeterModelId(string ModelId)
    {
        if (!ValidateIntInput(ModelId))
        {
            Console.WriteLine("Invalis input.");
            throw new Exception("Invalid input");
        }

        switch (int.Parse(ModelId))
        {
            case 1:
                return MeterModelId.NSX1P2W;
            case 2:
                return MeterModelId.NSX1P3W;
            case 3:
                return MeterModelId.NSX2P3W;
            case 4:
                return MeterModelId.NSX3P4W;
            default:
                return MeterModelId.InvalidModel;
        }
    }

    public SwitchStatus ValidateSwitchStatus(string switchStatus)
    {
        if (!ValidateIntInput(switchStatus))
        {
            Console.WriteLine("Invalis input.");
            throw new Exception("Invalid input");
        }

        switch (int.Parse(switchStatus))
        {
            case 1:
                return SwitchStatus.Disconnected;
            case 2:
                return SwitchStatus.Connected;
            case 3:
                return SwitchStatus.Armed;
            default:
                return SwitchStatus.InvalidStatus;
        }
    }
}