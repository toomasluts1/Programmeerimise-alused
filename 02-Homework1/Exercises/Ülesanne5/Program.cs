using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja suvalise numbri vahemikus [1-100], proovi see ära arvata.");
            Console.WriteLine();

            Random rand = new Random();
            int x = rand.Next(1, 100);

            while (true)
            {
                Console.Write("Sisesta number: ");
                string sisend = Console.ReadLine();
                int num = int.Parse(sisend);
                Console.WriteLine();

                if (num < x)
                {
                    Console.WriteLine("Arvuti valitud number on suurem.");
                }

                if (num > x)
                {
                    Console.WriteLine("Arvuti valitud number on väiksem.");
                }

                if (num == x)
                {
                    Console.WriteLine("Arvasid numbri ära!");
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
