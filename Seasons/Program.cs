using System;

namespace Seasons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input month: ");
            var InputMonth = Console.ReadLine();
            bool chekInputMonth = int.TryParse(InputMonth, out int parseInputMonth);
            while (chekInputMonth == false)
            {
                Console.Write("Input error, please try again: ");
                InputMonth = Console.ReadLine();
                chekInputMonth = int.TryParse(InputMonth, out parseInputMonth);
            }
            switch (parseInputMonth)
            {
                case >0 and <=2:
                    Console.WriteLine("Winter");
                    break;
                case 12:
                    Console.WriteLine("Winter");
                    break;
                case >= 3 and <= 5:
                    Console.WriteLine("Spring");
                    break;
                case >= 6 and <= 8:
                    Console.WriteLine("Summer");
                    break;
                case >= 9 and <= 11:
                    Console.WriteLine("Autumn");
                    break;
                default :
                    Console.WriteLine("I don't know this time of the year");
                    break;

            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}