using Chips.LogicGates;

namespace Chips.Tests.LogicGates;

public class NotTests
{
    [Fact]
    public void NotTest1()
    {
        bool inp = true;

        bool result = Not.Out(inp);

        Assert.False(result);
    }

    [Fact]
    public void NotTest2()
    {
        bool inp = false;

        bool result = Not.Out(inp);

        Assert.True(result);
    }
}