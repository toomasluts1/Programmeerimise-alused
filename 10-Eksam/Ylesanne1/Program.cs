using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nimed = new List<string>();

            while(true)
            {
                Console.Write("Sisesta nimi või sisesta \"-1\", et lõpetada: ");

                string sisend = Console.ReadLine();
                Console.WriteLine();
                if (sisend == "-1") break;

                var sb = new StringBuilder(sisend);
                string esitäht = sb[0].ToString();
                esitäht = esitäht.ToUpper();
                sb[0] = char.Parse(esitäht);
                var nimi = sb.ToString();

                nimed.Add(nimi);
            }

            Console.WriteLine("Sisestatud nimed on: ");
            foreach (string n in nimed) Console.WriteLine(n);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
