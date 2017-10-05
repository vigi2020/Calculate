using Calculate;
using System;

namespace CalculateApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.Write("Enter number to calculate: ");
                    var input = Console.ReadLine();
                    if (double.TryParse(input, out double myNum))
                    {
                        Console.WriteLine(CalculateUtility.Calculate(myNum));
                    }
                    else
                    {
                        Console.WriteLine("Enter only number");
                    }
                    Console.Write("Enter Y to try another number or Press any key to exit: ");
                } while (Convert.ToString(Console.ReadLine()).ToLower().Equals("y"));
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}