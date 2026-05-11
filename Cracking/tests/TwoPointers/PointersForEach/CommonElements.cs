using Cracking.TwoPointers.PointersForEach;

namespace Cracking.Tests.TwoPointers.PointersForEach;

public class CommonElementsSolutionTests
{
    [Theory]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new int[] { 0, 2, 4, 8, 8 }, new int[] { 1, 2, 2, 7, 8, 8, 8 }, new int[] { 2, 8, 8 })]
    [InlineData(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 }, new int[] { })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 10 }, new int[] { 1, 5, 10, 20 }, new int[] { 10 })]
    [InlineData(new int[] { -5, -2, 0 }, new int[] { -2, 0, 5 }, new int[] { -2, 0 })]
    [InlineData(new int[] { 10, 20, 30 }, new int[] { 1, 2 }, new int[] { })]
    [InlineData(new int[] { 8, 8, 8 }, new int[] { 8 }, new int[] { 8 })]
    [InlineData(new int[] { 1, 1, 1 }, new int[] { 1, 1 }, new int[] { 1, 1 })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { })]
    [InlineData(new int[] { 5, 10 }, new int[] { 1, 5, 7, 10, 15 }, new int[] { 5, 10 })]
    [InlineData(new int[] { int.MinValue }, new int[] { int.MinValue }, new int[] { int.MinValue })]
    public void FindCommonElements_ReturnsExpectedResult(int[] a, int[] b, int[] expected)
    {
        // Act
        var result = CommonElementsSolution.FindCommonElements(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
