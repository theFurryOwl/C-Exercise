namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double a = 0;
                double b = 0;
                double result = 0;

                Console.WriteLine("--------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("--------------------");

                //
                Console.WriteLine("Please enter first number");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter second number");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an option");
                //
                Console.WriteLine("\t To add write +");
                Console.WriteLine("\t To subtruct write -");
                Console.WriteLine("\t To multiply write *");
                Console.WriteLine("\t To divide write /");
                //
                switch (Console.ReadLine())
                {
                    case ("+"):
                        result = a + b;
                        Console.WriteLine($"{a} + {b} = {result}");
                        break;
                    case ("-"):
                        result = a - b;
                        Console.WriteLine($"{a} - {b} = {result}");
                        break;
                    case ("*"):
                        result = a * b;
                        Console.WriteLine($"{a} * {b} = {result}");
                        break;
                    case ("/"):
                        result = a / b;
                        Console.WriteLine($"{a} / {b} = {result}");
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;

                }
                Console.WriteLine("Would you like to continue Y/N");


            } while (Console.ReadLine().ToLower() == "y");
            Console.WriteLine("See ya");
        }
    }
}