using Chips.LogicGates;

namespace Chips.Tests.LogicGates;

public class MultiplexerTests
{
    [Fact]
    public void MultiplexerTest1()
    {
        Assert.False(Multiplexer.Out(false, false, false));
    }

    [Fact]
    public void MultiplexerTest2()
    {
        Assert.False(Multiplexer.Out(false, true, false));
    }

    [Fact]
    public void MultiplexerTest3()
    {
        Assert.True(Multiplexer.Out(true, false, false));
    }

    [Fact]
    public void MultiplexerTest4()
    {
        Assert.True(Multiplexer.Out(true, true, false));
    }

    [Fact]
    public void MultiplexerTest5()
    {
        Assert.False(Multiplexer.Out(false, false, true));
    }

    [Fact]
    public void MultiplexerTest6()
    {
        Assert.True(Multiplexer.Out(false, true, true));
    }

    [Fact]
    public void MultiplexerTest7()
    {
        Assert.False(Multiplexer.Out(true, false, true));
    }

    [Fact]
    public void MultiplexerTest8()
    {
        Assert.True(Multiplexer.Out(true, true, true));
    }
}