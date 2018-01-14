using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class BJPlayer
    {
        private int score = new int();
        private List<string> hand = new List<string>();

        public void TakeCard(string C)
        {
            hand.Add(C);
        }

        public string ShowCard(int i)
        {
            return hand[i - 1];
        }

        public void ShowHand()
        {
            for(int i=0; i<hand.Count(); i++)
            {
                if (i != 0) Console.Write(", ");
                Console.Write(hand[i]);
            }
        }

        public void AddScore(int n)
        {
            score = score + n;
        }

        public int ShowScore()
        {
            return score;
        }
    }
}
