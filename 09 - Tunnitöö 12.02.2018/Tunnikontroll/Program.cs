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
            Console.Write("Sisesta lause: ");
            string lause = Console.ReadLine();
            string[] sõnad = lause.Split(' ');
            var uuedsõnad = new List<string>();

            foreach(string sõna in sõnad)
            {
                if(sõna.Length > 3)
                {
                    char algustäht = sõna[0];
                    char lõpptäht = sõna[sõna.Length - 1];
                    string str1 = sõna.Remove(0, 1);
                    string keskosa = str1.Remove(str1.Length - 1, 1);
                    string mixedkeskosa = keskosa;

                    while(keskosa == mixedkeskosa)     //Kui tagastatakse juhuslikult sama sõna, mixi uuesti
                    {
                        mixedkeskosa = Shuffle.StringMixer(keskosa);
                    }

                    string uussõna = string.Join("", algustäht, mixedkeskosa, lõpptäht);
                    uuedsõnad.Add(uussõna);
                }

                else
                {
                    uuedsõnad.Add(sõna);
                }
            }

            string uuslause = string.Join(" ", uuedsõnad);

            Console.WriteLine();
            Console.WriteLine(uuslause);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
