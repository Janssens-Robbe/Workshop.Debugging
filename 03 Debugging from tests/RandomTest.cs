namespace _03_Debugging_from_tests;

[TestClass]
public sealed class RandomTest
{
    [TestMethod]
    public void VeryExampleBadTest()
    {
        var randomNumber = new Random().Next(1, 100);
        Assert.IsTrue(randomNumber > 50, "The random number is not greater than 50.");
    }
}
