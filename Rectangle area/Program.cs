using System;

namespace Rectangle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the area of ​​a rectangle. Units for sides - millimeters");
            Console.WriteLine("=======================================================================");
            Console.Write("Enter the first side: ");
            var FirstSide = Console.ReadLine();
            bool chekParseFirstSide = double.TryParse(FirstSide, out double parseFirstSide);//попытка спарсить строку в double
            while (chekParseFirstSide == false)                                             // выполняем цикл пока не получим true
            {
                Console.Write("Invalid input, please try again: ");
                FirstSide = Console.ReadLine();
                chekParseFirstSide = double.TryParse(FirstSide, out parseFirstSide);        // попытка спарсить строку в теле цикла
                                                                                            // и вернуть результат в условие
            }
            Console.WriteLine($"First side =  {parseFirstSide} mm");
            Console.WriteLine();
            Console.Write("Enter the second side: ");
            var SecondSide = Console.ReadLine();
            bool chekParseSecondSide = double.TryParse(SecondSide, out double parseSecondSide);
            while (chekParseSecondSide == false)
            {
                Console.Write("Invalid input, please try again: ");
                SecondSide = Console.ReadLine();
                chekParseSecondSide = double.TryParse(SecondSide, out parseSecondSide);
            }
            Console.WriteLine($"Second side =  {parseSecondSide} mm");
            Console.WriteLine();
            double result = parseFirstSide * parseFirstSide;
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"Rectangle area: {result} mm^2");
            Console.WriteLine("=======================================================================");
            Console.ReadKey();
        }
       
    }
    

}