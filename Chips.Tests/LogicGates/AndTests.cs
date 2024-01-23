using Chips.LogicGates;

namespace Chip.Tests.LogicGates;

public class AndTests
{
    [Fact]
    public void AndTest1()
    {
        bool a = false;
        bool b = false;

        bool result = And.Out(a, b);

        Assert.False(result);
    }

    [Fact]
    public void AndTest2()
    {
        bool a = false;
        bool b = true;

        bool result = And.Out(a, b);

        Assert.False(result);
    }

    [Fact]
    public void AndTest3()
    {
        bool a = true;
        bool b = false;

        bool result = And.Out(a, b);

        Assert.False(result);
    }

    [Fact]
    public void AndTest4()
    {
        bool a = true;
        bool b = true;

        bool result = And.Out(a, b);

        Assert.True(result);
    }
}