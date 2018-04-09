using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var timestamps = new List<DateTime>();

            Console.Write("Minimaalne aasta arv: ");
            string sisend1 = Console.ReadLine();
            Console.Write("Maksimaalne aasta arv: ");
            string sisend2 = Console.ReadLine();
            Console.Write("Genereeritavate andmete hulk: ");
            string sisend3 = Console.ReadLine();

            int min = int.Parse(sisend1);
            int max = int.Parse(sisend2);
            int count = int.Parse(sisend3);

            long binmin = new DateTime(min, 1, 1).ToBinary();
            long binmax = new DateTime(max, 1, 1).ToBinary();
            long vahemik = binmax - binmin;

            for(int i = 0; i < count; i++)
            {
                double rndouble = rnd.NextDouble();
                long x = (long)(vahemik * rndouble);
                long randombin = binmin + x;

                var stamp = DateTime.FromBinary(randombin);
                timestamps.Add(stamp);
            }

            Console.WriteLine();
            Console.WriteLine("Genereeritud timestambid:");
            foreach(DateTime ts in timestamps)
            {
                Console.WriteLine(ts.ToLocalTime());
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
