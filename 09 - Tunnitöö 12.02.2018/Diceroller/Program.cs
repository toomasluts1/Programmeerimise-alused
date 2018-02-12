using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diceroller
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();
            int sum = 0;

            for(int i = 0; i<3; i++)
            {
                int num = rnd.Next(1, 7);
                sum = sum + num;
                Console.WriteLine($"1d6: {num}");
            }

            for (int i = 0; i < 2; i++)
            {
                int num = rnd.Next(1, 9);
                sum = sum + num;
                Console.WriteLine($"1d8: {num}");
            }

            Console.WriteLine();
            Console.WriteLine($"Roll total: {sum}");
            Console.WriteLine();
            Console.WriteLine(">");

            Console.ReadKey();
        }
    }
}
