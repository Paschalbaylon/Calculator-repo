using System;

namespace Calculator;

public class CalcOperator
{
    public static void MyCalculator()
    {
        Calculator calculator = new Calculator();
        System.Console.WriteLine("");
        System.Console.WriteLine("BAYLON CONSOLE CALCULATOR");
        System.Console.WriteLine("_________________________");
        System.Console.WriteLine("");
        
        while (true)
        {
        Console.Write("1st num: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("operator: ");
        string? operateInput = Console.ReadLine();
        Operator operate = GetOperator(operateInput);

        
        
        if (operate == Operator.Percentage)
        {
            Console.Write("2nd num: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("percentage value: ");
            double percentageValue = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("");
            double Result = calculator.Calculate(operate, percentageValue, num2);

            System.Console.WriteLine($"{Result}");
        }
        else
        {

        try
        {
            Console.Write("2nd num: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double Result = calculator.Calculate(operate, num1, num2);
            System.Console.WriteLine($"{Result}");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        }
        System.Console.WriteLine("Want to Continue? ");
        string? Response = Console.ReadLine();

        if (Response.ToLower() != "yes")
        {
            break;
        }
        }
    }
         

    static Operator GetOperator(string operateInput)
    {
        switch (operateInput)
        {
            case "+":
            return Operator.Add;
            case "-":
            return Operator.Subtract;
            case "*":
            return Operator.Multiply;
            case "/":
            return Operator.Divide;
            case "%":
            return Operator.Percentage;

            default:
            throw new ArgumentException("Invalid Operation");
        }
    }
}
