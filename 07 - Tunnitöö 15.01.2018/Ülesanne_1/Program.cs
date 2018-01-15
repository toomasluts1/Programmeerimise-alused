using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("--------------------------------------------------");

            decimal sum = 0;

            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string sisend = Console.ReadLine();
                decimal price = 0;
                if (sisend == "-1") break;

                try
                {
                    price = decimal.Parse(sisend);
                }
                catch (FormatException)
                {
                    Console.WriteLine("False input. Enter a number.");
                }

                sum = sum + price;
            }
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine($"Subtotal: £{Math.Round(sum,2)}");
            Console.WriteLine($"15.00 % Gratiuity: ${Math.Round((decimal)0.15 * sum,2)}");
            Console.WriteLine($"Total: {Math.Round((decimal)0.85 * sum, 2)}");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
