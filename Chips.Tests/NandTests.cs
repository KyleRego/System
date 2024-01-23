namespace Chips.Tests;

using Chips;

public class NandTests
{
    [Fact]
    public void NandTest1()
    {
        bool a = false;
        bool b = false;

        bool result = Nand.Out(a, b);

        Assert.True(result);
    }

    [Fact]
    public void NandTest2()
    {
        bool a = false;
        bool b = true;

        bool result = Nand.Out(a, b);

        Assert.True(result);
    }

    [Fact]
    public void NandTest3()
    {
        bool a = true;
        bool b = false;

        bool result = Nand.Out(a, b);

        Assert.True(result);
    }

    [Fact]
    public void NandTest4()
    {
        bool a = true;
        bool b = true;

        bool result = Nand.Out(a, b);

        Assert.False(result);
    }
}