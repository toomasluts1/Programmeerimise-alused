using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm mis lubab sisestada N+1 hulga erinevaid sõnu, kuni sisestatakse -1");
            Console.WriteLine();
            List <string> sõnad = new List<string>();

            while (true)
            {
                Console.Write("Sisesta sõna: ");
                string sõna = Console.ReadLine();
                if (sõna == "-1") break;
                sõnad.Add(sõna);
            }

            Console.WriteLine();
            Console.Write($"Sisestasid sõnad: {string.Join(", ", sõnad)}");
            Console.WriteLine();
            Console.WriteLine($"Valin nendest välja suvalise: {sõnad[new Random().Next(sõnad.Count)]}");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
