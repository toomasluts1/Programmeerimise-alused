using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diceroller
{
    class Dice
    {
        Random rnd = new Random();

        public int Roll(int tahud)
        {
            return rnd.Next(1, tahud + 1);
        }
    }
}
