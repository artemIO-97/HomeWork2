namespace Area_of_​​a_right_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating the area of a right triangle. Units of measurement - millimeters.");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("");
            Console.Write("Enter the length of the first leg: ");
            var FirstLeg = Console.ReadLine();
            bool chekFirstLeg = double.TryParse(FirstLeg, out double parseFirstLeg);
            while(chekFirstLeg == false)
            {
                Console.Write("Input error, please try again: ");
                FirstLeg = Console.ReadLine();
                chekFirstLeg = double.TryParse(FirstLeg, out parseFirstLeg);
            }
            Console.WriteLine($"The first leg is: {parseFirstLeg} mm");
            Console.WriteLine("==============================================================================");
            Console.Write("Enter the length of the second leg: ");
            var SecondLeg = Console.ReadLine();
            bool chekSecondLeg = double.TryParse(SecondLeg,out double parseSecondLeg);
            while(chekSecondLeg == false)
            {
                Console.Write("Input error, please try again: ");
                SecondLeg = Console.ReadLine();
                chekSecondLeg = double.TryParse(SecondLeg, out parseSecondLeg);
            }
            Console.WriteLine($"The second leg is: {parseSecondLeg} mm");
            Console.WriteLine("==============================================================================");
            var result = (parseFirstLeg * parseSecondLeg)/2;
            Console.WriteLine($"The area of a right triangle is {result}");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}