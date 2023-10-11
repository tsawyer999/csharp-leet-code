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

    public BigInteger Solve()
    {
        var value1 = _operands[0] == 't';
        var value2 = _operands[1] == 't';
        var result = 0;
        if (_operators[0] == '&')
        {
            if (value1 && value2)
            {
                result++;
            }
        }
        else if (_operators[0] == '|')
        {
            if (value1 || value2)
            {
                result++;
            }
        }
        else if (_operators[0] == '^')
        {
            if (value1 ^ value2)
            {
                result++;
            }
        }

        return result;
    }
}