namespace Chips.LogicGates;

public class Or
{
    public static bool Out(bool a, bool b)
    {
        bool notA = Not.Out(a);
        bool notB = Not.Out(b);

        return Not.Out(And.Out(notA, notB));
    }
}