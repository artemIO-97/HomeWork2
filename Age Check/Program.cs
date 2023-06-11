namespace Age_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input age: ");
            var AgeUser = Console.ReadLine();
            bool chekAgeUser = double.TryParse(AgeUser, out double parseAgeUser);
            while (chekAgeUser == false)
            {
                Console.Write("Input error, please try again: ");
                AgeUser = Console.ReadLine();
                chekAgeUser = double.TryParse(AgeUser, out parseAgeUser);
            }                  
           switch (parseAgeUser)
            {
                case >= 18:
                    Console.WriteLine("Adult");
                    break;
                case  <= 18:
                    if (parseAgeUser <= 0) 
                    {
                        Console.WriteLine("(O_o) realy?????");
                    }
                    else
                    {
                        Console.WriteLine("Not Adult");
                        
                    }
                    break;
                    
                
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}