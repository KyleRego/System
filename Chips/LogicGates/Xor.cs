namespace Chips.LogicGates;

public class Xor
{
    public static bool Out(bool a, bool b)
    {
        bool aTrueOnly = And.Out(a, Not.Out(b));
        bool bTrueOnly = And.Out(Not.Out(a), b);

        return Or.Out(aTrueOnly, bTrueOnly);
    }
}