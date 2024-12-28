using System;

namespace Calculator;

public class Calculator
{
    public double Calculate(Operator operate, double num1, double num2)
    {
        switch (operate)
        {
            case Operator.Add:
            return num1 + num2;
            case Operator.Subtract:
            return num1 - num2;
            case Operator.Multiply:
            return num1 * num2;
            case Operator.Divide:
            if (num1 == 0)
            {
            throw new DivideByZeroException("Can't be divided by 0");
            }
            else
            {
               return num1 / num2;
            }
            case Operator.Percentage:
            return (num1 / 100) * num2;

            default:
            throw new ArgumentException("Invalid Operation");
        }
    }
}
