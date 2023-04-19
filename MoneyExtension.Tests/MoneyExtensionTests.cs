namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTest
{
    [TestMethod]
    public void ShowldConvertDecimalToInt()
    {
        decimal value = 279.98M;
        var cents = value.ToCents();

        Assert.AreEqual(27998, cents);
    }
}