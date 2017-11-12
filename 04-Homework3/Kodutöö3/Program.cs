using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutöö3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tegu on algelise trips-traps-trull mänguga.");
            Console.WriteLine("Sina oled X ja arvuti on 0.");
            Console.WriteLine("Oma X saad paigutada sisestades selle koordinaadid.");
            Console.WriteLine("Arvuti ei ole väga tark ja paigutab nullid suvalistele vabadele kohtadele.");
            Console.WriteLine();

            string[,] mänguväli = new string[3, 3]; //Loo mänguväli
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    mänguväli[x, y] = "-";
                }
            }

            PrintGrid(mänguväli);
            Console.WriteLine();

            Random rand = new Random();     //Kes alustab
            int alustaja = rand.Next(0, 2);
            if (alustaja > 0)
            {
                Console.WriteLine("Arvuti kord.");
                Console.WriteLine();
                Add0(mänguväli);
                PrintGrid(mänguväli);
                Console.WriteLine();
            }

            while (true)
            {
                Console.WriteLine("Sinu kord.");  //Mängija kord.
                AddX(mänguväli);
                Console.WriteLine();
                PrintGrid(mänguväli);
                Console.WriteLine();
                if(Võidukontroll(mänguväli,"X") == true)
                {
                    Console.WriteLine("Sinu võit!");
                    break;
                }
                if(Kohadtäis(mänguväli) == true)
                {
                    Console.WriteLine("Viik!");
                    break;
                }

                Console.WriteLine("Arvuti kord.");  //Arvuti kord.
                Add0(mänguväli);
                Console.WriteLine();
                PrintGrid(mänguväli);
                Console.WriteLine();
                if (Võidukontroll(mänguväli, "0") == true)
                {
                    Console.WriteLine("Arvuti võit!");
                    break;
                }
                if (Kohadtäis(mänguväli) == true)
                {
                    Console.WriteLine("Viik!");
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void PrintGrid(string[,] grid)
        {
            int laius = grid.GetLength(0);
            int pikkus = grid.GetLength(1);

            for (int x = 0; x < laius; x++)
            {
                for (int y = 0; y < pikkus; y++)
                {
                    Console.Write(grid[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        static void AddX(string[,] grid)
        {
            while (true)
            {
                int x = 0;
                int y = 0;

                Console.WriteLine("Sisesta X koordinaadid (1-3):");

                while (true)  // Rea numbri küsimine
                {
                    Console.Write("Rida: ");
                    string reasisend = Console.ReadLine();

                    try
                    {
                        x = int.Parse(reasisend);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Vigane sisend!");
                        continue;
                    }

                    if (x > 0 && x < 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vigane sisend!");
                        continue;
                    }
                }

                while (true) // Veeru numbri küsimine
                {
                    Console.Write("Veerg: ");
                    string veerusisend = Console.ReadLine();

                    try
                    {
                        y = int.Parse(veerusisend);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Vigane sisend!");
                        continue;
                    }

                    if (y > 0 && y < 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vigane sisend!");
                        continue;
                    }
                }

                if (grid[x-1,y-1] == "-")  // Asukoha sobivuse kontroll
                {
                    grid[x - 1, y - 1] = "X";
                    break;
                }
                else
                {
                    Console.WriteLine("Vigased koordinaadid!");
                }
            }
        }

        static void Add0(string[,] grid)
        {
            List<int[]> kriipsud = new List<int[]>();

            for (int x = 0; x < grid.GetLength(0); x++)  // Otsi välja vabad kohad
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    if (grid [x,y] == "-")
                    {
                        int[] asukoht = new int[2];
                        asukoht[0] = x;
                        asukoht[1] = y;
                        kriipsud.Add(asukoht);
                    }
                }
            }

            if (kriipsud.Count > 0) // Lisa 0 vabale kohale
            {
                Random rand = new Random();
                int num = rand.Next(0, kriipsud.Count);
                int[] valik = kriipsud[num];
                grid[valik[0], valik[1]] = "0";
            }
        }

        static bool Võidukontroll(string[,] grid, string sümbol)
        {
            List<string[]> võidujooned = new List<string[]>();

            for(int x = 0; x < 3; x++)
            {
                string[] joon = new string[3];
                for (int y = 0; y < 3; y++)
                {
                    joon[y] = grid[x, y];
                }
                võidujooned.Add(joon);
            }

            for (int y = 0; y < 3; y++)
            {
                string[] joon = new string[3];
                for (int x = 0; x < 3; x++)
                {
                    joon[x] = grid[x, y];
                }
                võidujooned.Add(joon);
            }

            string[] diagonaal1 = new string[3];
            diagonaal1[0] = grid[0,0];  diagonaal1[1] = grid[1, 1];  diagonaal1[2] = grid[2, 2];
            võidujooned.Add(diagonaal1);

            string[] diagonaal2 = new string[3];
            diagonaal2[0] = grid[0, 2]; diagonaal2[1] = grid[1, 1]; diagonaal2[2] = grid[2, 0];
            võidujooned.Add(diagonaal2);

            foreach (string[] line in võidujooned)
            {
                if (line[0] == line[1] && line[1] == line[2])
                {
                    if (line[0] == sümbol)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static bool Kohadtäis(string[,] grid)
        {
            List<string> loend = new List<string>();

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (grid[x,y] == "-")
                    {
                        loend.Add(grid[x, y]);
                    }
                }
            }

            if (loend.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
