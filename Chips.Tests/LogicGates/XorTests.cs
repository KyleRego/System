using Chips.LogicGates;

namespace Chips.Tests.LogicGates;

public class XorTests
{
    [Fact]
    public void XorTest1()
    {
        Assert.False(Xor.Out(false, false));
    }

    [Fact]
    public void XorTest2()
    {
        Assert.True(Xor.Out(true, false));
    }

    [Fact]
    public void XorTest3()
    {
        Assert.True(Xor.Out(false, true));
    }

    [Fact]
    public void XorTest4()
    {
        Assert.False(Xor.Out(true, true));
    }
}