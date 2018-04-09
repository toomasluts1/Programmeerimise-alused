using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var timestamps = new List<DateTime>();
            var vanused = new List<int>();
            var sünnikuud = new int[12];

            long binmin = new DateTime(1940, 1, 1).ToBinary();
            long binmax = new DateTime(2010, 1, 1).ToBinary();
            long vahemik = binmax - binmin;

            for (int i = 0; i < 30; i++)
            {
                double rndouble = rnd.NextDouble();
                long x = (long)(vahemik * rndouble);
                long randombin = binmin + x;

                var stamp = DateTime.FromBinary(randombin);
                timestamps.Add(stamp);
            }

            timestamps.Sort();

            Console.WriteLine("Inimeste sünniajad:");
            foreach (DateTime ts in timestamps)
            {
                Console.WriteLine(ts.ToLocalTime());

                int sünnikuu = ts.Month;
                sünnikuud[sünnikuu - 1] += 1;
            }

            foreach (DateTime ts in timestamps)
            {
                var vanusdate = DateTime.Now;
                vanusdate = vanusdate.AddYears(-ts.Year);
                vanusdate = vanusdate.AddMonths(-ts.Month);
                vanusdate = vanusdate.AddDays(-ts.Day);
                int vanus = vanusdate.Year;

                vanused.Add(vanus);
            }

            int maxkuunr = Array.IndexOf(sünnikuud, sünnikuud.Max()) + 1;
            string maxkuu = "";

            switch (maxkuunr)
            {
                case 1:
                    maxkuu = "jaanuar";
                    break;
                case 2:
                    maxkuu = "veebruar";
                    break;
                case 3:
                    maxkuu = "märts";
                    break;
                case 4:
                    maxkuu = "aprill";
                    break;
                case 5:
                    maxkuu = "mai";
                    break;
                case 6:
                    maxkuu = "juuni";
                    break;
                case 7:
                    maxkuu = "juuli";
                    break;
                case 8:
                    maxkuu = "august";
                    break;
                case 9:
                    maxkuu = "september";
                    break;
                case 10:
                    maxkuu = "oktoober";
                    break;
                case 11:
                    maxkuu = "november";
                    break;
                case 12:
                    maxkuu = "detsember";
                    break;
            }

            Console.WriteLine();
            Console.WriteLine($"Maksimaalne vanus on {vanused.Max()}");
            Console.WriteLine($"Minimaalne vanus on {vanused.Min()}");
            Console.WriteLine($"Keskmine vanus on {(int)vanused.Average()}");
            Console.WriteLine($"Kuu, milles on enim sünnipäevi: {maxkuu}");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
