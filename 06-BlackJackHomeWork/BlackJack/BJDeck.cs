using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class BJDeck
    {
        private List<string> cards = new List<string>();
        
        private void AddSuit(string x)
        {
            for(int i=2; i<11; i++)
            {
                cards.Add(i + x);
            }
            cards.Add("k" + x);
            cards.Add("q" + x);
            cards.Add("j" + x);
            cards.Add("a" + x);
        }

        public void CreateCards()
        {
            AddSuit("C");
            AddSuit("D");
            AddSuit("H");
            AddSuit("S");
        }

        public string DrawCard(Random rnd)
        {
            int i = rnd.Next(0, cards.Count());
            string ChosenCard = cards[i];
            cards.RemoveAt(i);

            return ChosenCard;
        }
    }
}
