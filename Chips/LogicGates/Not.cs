namespace Chips.LogicGates;

public class Not
{
    public static bool Out(bool inp)
    {
        return Nand.Out(inp, inp);
    }
}