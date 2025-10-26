using System;

namespace SimpleCalculator
{
    public interface ICalculation
    {
        double Calculate(double num1, double num2, char operation);
    }
    public class Calculation : ICalculation
    {
        public double Calculate(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;

                case '-':
                    return num1 - num2;

                case '*':
                    return num1 * num2;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("0-a bölmek olmaz");
                        return double.NaN;
                    }
                    return num1 / num2;

                default:
                    Console.WriteLine("yanlis simvol daxil edilib!");
                    return double.NaN;
            }
        }
    }
}
