namespace SimpleCalculator;

class Program
{
    static void Main(string[] args)
    {
        ICalculation calc = new Calculation();

            Console.Write("Birinci ededi daxil edin: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Emeliyyati daxil edin (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("İkinci ededi daxil edin: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = calc.Calculate(num1, num2, operation);

            Console.WriteLine($"Nəticə: {result}");
        }
    }

