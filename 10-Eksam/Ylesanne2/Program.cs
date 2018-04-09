using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimed = { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli", "Kevin", "Maarika", "Laura" };
            Console.Write("Nimed: ");
            Console.WriteLine(string.Join(", ", nimed));
            Console.WriteLine();

            Console.WriteLine("Sisesta tekst, mis sisaldab ülaltoodud nimesid: ");
            string sisend = Console.ReadLine();
            var sõnad = sisend.Split(' ');

            for(int i = 0; i < sõnad.Length; i++)
            {
                string sõna = sõnad[i].Trim('.',',','!','?');
                sõna = sõna.ToLower();
                
                foreach(string nimi in nimed)
                {
                    string name = nimi.ToLower();
                    if (sõna == name)
                    {
                        sõnad[i] = Capitalize(sõnad[i]);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sisestatud tekst: ");
            Console.WriteLine(string.Join(" ", sõnad));

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static string Capitalize(string str)
        {
            var sb = new StringBuilder(str);
            string esitäht = sb[0].ToString();
            esitäht = esitäht.ToUpper();
            sb[0] = char.Parse(esitäht);
            var newstr = sb.ToString();

            return newstr;
        }
    }
}
