namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            var FirstNumber = Console.ReadLine();
            bool chekFirstNumber = double.TryParse(FirstNumber, out double parseFirstNumber);
            while(chekFirstNumber == false)
            {
                Console.Write("Input error, please try again: ");
                FirstNumber = Console.ReadLine();
                chekFirstNumber = double.TryParse(FirstNumber, out parseFirstNumber);

            }
            Console.Write("Input the second number: ");
            var SecondNumber = Console.ReadLine();
            bool chekSecondNumber = double.TryParse(SecondNumber, out double parseSecondNumber);
            while (chekSecondNumber == false)
            {
                Console.Write("Input error, please try again: ");
                SecondNumber = Console.ReadLine();
                chekSecondNumber = double.TryParse(SecondNumber, out parseSecondNumber);
               
            }
            Console.Write("Input mathematical operation:  ");
            var MathematicalOperation = Console.ReadLine();
            bool chekMathematicalOperation = char.TryParse(MathematicalOperation, out char parseMathematicalOperation);
            while (chekMathematicalOperation == false)
            {
                Console.Write("Invalid mathematical operation, please try again: ");
                MathematicalOperation = Console.ReadLine();
                chekMathematicalOperation = char.TryParse(MathematicalOperation, out parseMathematicalOperation);
            }
            switch (parseMathematicalOperation)
            {
                case '*':
                    var result = parseFirstNumber * parseSecondNumber;
                    Console.WriteLine($"Multiplication result {result}");
                    break;
                case '/':
                    result = parseFirstNumber / parseSecondNumber;
                    Console.WriteLine($"Division result {result}");
                    break;
                case '+':
                    result = parseFirstNumber + parseSecondNumber;
                    Console.WriteLine($"Addition result {result}");
                    break;
                case '-':
                    result = parseFirstNumber - parseSecondNumber;
                    Console.WriteLine($"Subtraction result {result}");
                    break;
                case '%':
                    if ((parseFirstNumber % 1 !=0) || (parseSecondNumber % 1 !=0)) 
                    {
                        Console.WriteLine("Enter an integer number!");
                    }
                    else 
                    {
                        result = parseFirstNumber % parseSecondNumber;
                        Console.WriteLine($"Remainder of the division {result}");
                    }
                    break;
                default:
                    Console.Write("Unknown character, please try again");
                    MathematicalOperation = Console.ReadLine();
                    break;

            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
                                     



        }
    }
}