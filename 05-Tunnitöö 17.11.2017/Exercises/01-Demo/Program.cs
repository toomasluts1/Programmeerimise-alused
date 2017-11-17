using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = new Random().Next(1, 50);
            int num2 = new Random().Next(50, 100);
            int summa = num1 + num2;

            Console.Write($"Tere, kui palju on {num1} + {num2}? ");
            string sisend = Console.ReadLine();
            Console.WriteLine();

            int vastus = 1000;
            try
            {
                vastus = int.Parse(sisend);
            }
            catch(Exception)
            {
            }
            

            if(vastus == summa)
            {
                Console.WriteLine("Õige!");
            }
            else
            {
                Console.WriteLine("Vale!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
