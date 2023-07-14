namespace landys.Tests;

public class MenuControllerTests
{
    MenuController controller = new MenuController();

    [Fact]
    public void ShouldCaptureInsertInput()
    {
        Console.SetIn(new StringReader("1"));
        var result = controller.ShowMenu();
        Assert.True(result == MenuOptions.Insert);
    }

    [Fact]
    public void ShouldThrowWithInvalidInput()
    {
        Console.SetIn(new StringReader("a"));
        Assert.Throws<Exception>(() => controller.ShowMenu());
    }
}