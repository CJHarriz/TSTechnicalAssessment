using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class DeepestPitTests
{
    [TestMethod]
    public void Q2_BasicNominalTest()
    {
        // Arrange
        var input = new[] {0, 1, 3, -2, 0, 1, -3, 2, 3};

        // Act
        var outcome = DeepestPitAnswer.Solution(input);

        // Assert
        Assert.AreEqual(4, outcome);
    }

    // The requested test
    [TestMethod]
    public void Q2_TestWithRequestedValues()
    {
        // Arrange
        var input = new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 };

        // Act
        var outcome = DeepestPitAnswer.Solution(input);

        // Assert
        Assert.AreEqual(2, outcome);
    }
}
