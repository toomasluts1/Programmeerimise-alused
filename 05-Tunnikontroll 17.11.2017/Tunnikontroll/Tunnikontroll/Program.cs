using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("--------------------------------------------");

            double sum = 0;
            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string sisend = Console.ReadLine();
                if (sisend == "-1") break;

                double hind = double.Parse(sisend);
                sum = sum + hind;
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Subtotal: £{Math.Round(sum,2)}");
            double grat = sum * 0.15;
            Console.WriteLine($"15.00 % Gratuity: £{Math.Round(grat,2)}");
            Console.WriteLine($"Total: £{Math.Round((sum - grat),2)}");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
