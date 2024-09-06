using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class LongestSentanceTests
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {
        // Arrange
        var input = "We test coders. Give us a try";

        // Act
        var outcome = LongestSentanceAnswer.Solution(input);

        // Assert
        Assert.AreEqual(4, outcome);
    }

    // The requested test
    [TestMethod]
    public void Q1_TestWithMultipleDelimetersAndSpaces()
    {
        // Arrange
        var input = "“Forget CVs..Save time . x x";

        // Act
        var outcome = LongestSentanceAnswer.Solution(input);

        // Assert
        Assert.AreEqual(2, outcome);
    }
}
