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
        if (string.IsNullOrEmpty(_operands))
        {
            throw new Exception("operands not initialized");
        }
        if (string.IsNullOrEmpty(_operators))
        {
            throw new Exception("operators not initialized");
        }
        if (_operands.Length - _operators.Length != 1)
        {
            throw new Exception("wrong number of operators");
        }

        var result = 0;
        for (var i = 0; i < _operands.Length - 1; i++)
        {
            var value1 = _operands[i] == 't';
            var value2 = _operands[i+1] == 't';

            var f = GetOperation(_operators[i]);

            if (f(value1, value2))
            {
                result++;
            }
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