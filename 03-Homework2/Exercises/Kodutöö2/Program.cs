using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutöö2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arvuti hakkab väljastama liitmis-, lahutamis-, korrutamis-, jagamistehteid 100 piires.");
            Console.WriteLine("Sisesta vastus ja arvuti ütleb, kas see on õige.");
            Console.WriteLine("Võid vastuseks kirjutada \"stop\", et programm peatada.");
            Console.WriteLine("Vajuta Enterit, et alustada.");
            Console.ReadLine();

            Random rand = new Random();

            while (true)
            {
                int tulemus = 0;
                int vastus = 0;
                string input = "";

                int valija = rand.Next(1, 5);
                switch (valija)
                {
                    case 1: // Liitmistehe
                        int x = rand.Next(0, 100);
                        int y = rand.Next(0, 100 - x);
                        tulemus = x + y;

                        Console.Write($"{x} + {y} = ");
                        input = Console.ReadLine();
                        if (input == "stop") { break; }
                        try
                        {
                            vastus = int.Parse(input);
                        }
                        catch (Exception)
                        {
                            vastus = 200;
                        }
                        break;

                    case 2: // Lahutamistehe
                        x = rand.Next(0, 100);
                        y = rand.Next(0, x);
                        tulemus = x - y;

                        Console.Write($"{x} - {y} = ");
                        input = Console.ReadLine();
                        if (input == "stop") { break; }
                        try
                        {
                            vastus = int.Parse(input);
                        }
                        catch (Exception)
                        {
                            vastus = 200;
                        }
                        break;

                    case 3: // Korrutamistehe
                        x = rand.Next(2, 25);
                        y = rand.Next(2, 100 / x);
                        tulemus = x * y;

                        Console.Write($"{x} * {y} = ");
                        input = Console.ReadLine();
                        if (input == "stop") { break; }
                        try
                        {
                            vastus = int.Parse(input);
                        }
                        catch (Exception)
                        {
                            vastus = 200;
                        }
                        break;

                    case 4: // Jagamistehe
                        x = rand.Next(2, 15);
                        int a = rand.Next(2, rand.Next(2,100 / x));
                        y = x * a;
                        tulemus = y / x;

                        Console.Write($"{y} : {x} = ");
                        input = Console.ReadLine();
                        if (input == "stop") { break; }
                        try
                        {
                            vastus = int.Parse(input);
                        }
                        catch (Exception)
                        {
                            vastus = 200;
                        }
                        break;

                    default:
                        break;
                }

                if (input == "stop")
                {
                    break;
                }

                if (tulemus == vastus)
                {
                    Console.WriteLine("Õige!");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine($"Vale! (Õige vastus on {tulemus})");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}