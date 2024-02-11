namespace Chips.LogicGates;

public class Multiplexer
{
    /// <summary>
    /// Uses sel (selection bit) to select and output the value of either a or b (data bits).
    /// If sel is false, then output a, else output b.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="sel"></param>
    public static bool Out(bool a, bool b, bool sel)
    {
        return Or.Out(
            And.Out(a, Not.Out(sel)),
            And.Out(b, sel)
        );
    }
}