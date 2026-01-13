using BasicMath;

namespace BasicMathTests;

public class UnitTest1 {
    [Fact]
    public void Test_Add() {
        var math = new MathEngine();
        var result = math.Add(1, 3);
        Assert.Equal(4, result);
    }
}