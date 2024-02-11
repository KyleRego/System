using Chips.LogicGates;

namespace Chips.Tests.LogicGates;

public class OrTests
{
    [Fact]
    public void OrTest1()
    {
        Assert.False(Or.Out(false, false));
    }

    [Fact]
    public void OrTest2()
    {
        Assert.True(Or.Out(true, false));
    }

    [Fact]
    public void OrTest3()
    {
        Assert.True(Or.Out(false, true));
    }

    [Fact]
    public void OrTest4()
    {
        Assert.True(Or.Out(true, true));
    }
}