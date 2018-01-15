using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanging
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<string> words = new List<string>();

            words.Add("computer");
            words.Add("ceiling");
            words.Add("canvas");

            string solution = words[rnd.Next(words.Count())];
            int startindex = rnd.Next(solution.Length);
            char startletter = solution[startindex];
            char[] parts = new char[solution.Length];

            for(int i = 0; i < parts.Length; i++)
            {
                if (i == startindex) parts[i] = startletter;
                else parts[i] = '_';
            }

            foreach(char x in parts)
            {
                Console.Write(x + " ");
            }

            //int tries = 5;

            //while(tries > 0)
            //{

            //}

            Console.ReadKey();
        }
    }
}
