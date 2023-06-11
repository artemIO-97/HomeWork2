namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input temperature: ");
            var InputTemperature = Console.ReadLine();
            bool chekInputTemperature = double.TryParse(InputTemperature, out double parseInputTemperature);
            while (chekInputTemperature == false)
            {
                Console.Write("Input error, please try again: ");
                InputTemperature = Console.ReadLine();
                chekInputTemperature = double.TryParse(InputTemperature, out parseInputTemperature);
            }
            switch (parseInputTemperature)
            {
                case <= 0:
                    Console.WriteLine("Very cold");
                    break;
                case <= 10:
                    if (parseInputTemperature >= 0 && parseInputTemperature <= 10)
                    {
                        Console.WriteLine("Cold");

                    }
                    break;
                case <= 20:
                    if (parseInputTemperature >= 10 && parseInputTemperature <= 20)
                    {
                        Console.WriteLine("Normal");

                    }
                    break;
                case <= 30:
                    if (parseInputTemperature >= 20 && parseInputTemperature <= 30)
                    {
                        Console.WriteLine("Heat");

                    }
                    break;
                case >= 30:                 
                    Console.WriteLine("Very Heat");                   
                    break;
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}