using System.Numerics;

namespace Exercices;

public class BooleanOrder
{
    private readonly string _operands;
    private readonly string _operators;

    public BooleanOrder(string operands, string operators)
    {
        _operands = operands;
        _operators = operators;
    }

    delegate bool Operation(bool value1, bool value2);

    public BigInteger Solve()
    {
        var value1 = _operands[0] == 't';
        var value2 = _operands[1] == 't';
        var result = 0;

        Operation f = GetOperation(_operators[0]);

        if (f(value1, value2))
        {
            result++;
        }

        return result;
    }

    private Operation GetOperation(char operation)
    {
        if (operation == '&')
        {
            return And;
        }
        if (operation == '|')
        {
            return Or;
        }
        if (operation == '^')
        {
            return Xor;
        }

        return NotImplemented;
    }

    public bool And(bool value1, bool value2)
    {
        return value1 && value2;
    }

    public bool Or(bool value1, bool value2)
    {
        return value1 || value2;
    }

    public bool Xor(bool value1, bool value2)
    {
        return value1 ^ value2;
    }

    public bool NotImplemented(bool value1, bool value2)
    {
        throw new NotImplementedException();
    }
}