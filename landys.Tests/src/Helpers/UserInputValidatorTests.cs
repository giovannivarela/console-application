namespace landys.Tests;

public class UserInputValidatorTests
{
    UserInputValidator validator = new UserInputValidator();

    [Fact]
    public void ShouldReturnCorrectlyWithValidInput()
    {
        MeterModelId test = validator.ValidateMeterModelId("1");
        Assert.True(test == MeterModelId.NSX1P2W);
    }

    [Fact]
    public void ShouldThrowWithInvalidInput()
    {
        Assert.Throws<Exception>(() => validator.ValidateMeterModelId("a"));
    }
}