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

    // Time to try break my solution!

    // Test with no pit
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, -1)]
    [DataRow(new[] { 10, 9, 8, 7 ,6 }, -1)]
    public void Q2_TestWithNoPit(int[] testArray, int expectation)
    {
        // Arrange
        var input = testArray;

        // Act
        var outcome = DeepestPitAnswer.Solution(input);

        // Assert
        Assert.AreEqual(expectation, outcome);
    }

    // Test with Extra values
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 2)]
    [DataRow(new[] { 1000000, 200000, 300000, 100000, 200000, 300000, 100000, 200000, 300000 }, 200000)]
    public void Q2_TestWithExtraValues(int[] testArray, int expectation)
    {
        // Arrange
        var input = testArray;

        // Act
        var outcome = DeepestPitAnswer.Solution(input);

        // Assert
        Assert.AreEqual(expectation, outcome);
    }

    // Test with small collections
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, -1)]
    [DataRow(new[] { 1, 2 }, -1)]
    [DataRow(new[] { 1}, -1)]
    public void Q2_TestWithSmallCollections(int[] testArray, int expectation)
    {
        // Arrange
        var input = testArray;

        // Act
        var outcome = DeepestPitAnswer.Solution(input);

        // Assert
        Assert.AreEqual(expectation, outcome);
    }
}
