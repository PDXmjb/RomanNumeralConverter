using NUnit.Framework;
using RomanNumeralConverter;

[TestFixture]
public class RomanConvertTests
{
    [TestCase(1, "I")]
    public void Test1(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }

    [TestCase(3, "III")]
    public void Test3(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }

    [TestCase(4, "IV")]
    public void Test4(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }

    [TestCase(5, "V")]
    public void Test5(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }

    [TestCase(9, "IX")]
    public void Test9(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }

    [TestCase(2018, "MMXVIII")]
    public void Test2018(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }

    [TestCase(889, "DCCCLXXXIX")]
    public void Test889(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }

    [TestCase(3999, "MMMCMXCIX")]
    public void Test3999(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }
}