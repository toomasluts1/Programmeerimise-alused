using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diceroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //4,6,8,10,12,20
            Random rnd = new Random();
            string input = Console.ReadLine();
            string[] dices = input.Split(',', ' ');

            foreach (string d in dices)
            {
                int repeat = 0;
                int size = 0;

                string[] dicedata = d.Split('d');
                if (dicedata[0] == "")
                {
                    repeat = 1;
                    size = int.Parse(dicedata[1]);
                }
                else
                {
                    repeat = int.Parse(dicedata[0]);
                    size = int.Parse(dicedata[1]);
                }

                for(int i = 0; i < repeat; i++)
                {
                    RollDice(size, rnd);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static void RollDice(int surf, Random rnd)
        {
            Console.WriteLine($"Rolled a {surf}-surface dice: {rnd.Next(1, surf + 1)}");
        }
    }
}
