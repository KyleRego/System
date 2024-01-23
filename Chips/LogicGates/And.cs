namespace Chips.LogicGates;

public class And
{
    public static bool Out(bool a, bool b)
    {
        return Not.Out(Nand.Out(a, b));
    }
}