using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            BJDeck Deck = new BJDeck();
            Deck.CreateCards();
            BJPlayer Player = new BJPlayer();
            BJPlayer House = new BJPlayer();
            Random rnd = new Random();

            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            DealCard(Player, Deck,rnd);
            DealCard(Player, Deck,rnd);
            DealCard(House, Deck,rnd);
            DealCard(House, Deck,rnd);

            Console.Write("You have been dealt: "); Player.ShowHand(); Console.WriteLine();
            Console.WriteLine($"House has been dealt: {House.ShowCard(1)}, [?]");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Choose: 1 - To take another card");
                Console.WriteLine("Choose: 2 - To finish");
                Console.WriteLine();

                string input = Console.ReadLine();
                if (input != "1" && input != "2")
                {
                    Console.WriteLine("Wrong input. Please choose 1 or 2.");
                    continue;
                }

                Console.WriteLine($"I choose: {input}");
                Console.WriteLine();

                if (input == "1")
                {
                    Console.WriteLine($"You have been dealt: {DealCard(Player, Deck,rnd)}");
                    DealCard(House, Deck,rnd);
                    Console.WriteLine("House has been dealt: [?]");
                    Console.WriteLine();
                }
                else if (input == "2") break;
            }

            Console.Write("Your cards: "); Player.ShowHand(); Console.WriteLine();
            Console.Write("House cards: "); House.ShowHand(); Console.WriteLine();
            Console.WriteLine($"You have {Player.ShowScore()} points vs. house {House.ShowScore()} points");

            if((Player.ShowScore() > 21 && House.ShowScore() > 21) || Player.ShowScore() == House.ShowScore())
            {
                Console.WriteLine("Draw!");
            }
            else if(Player.ShowScore() > 21 && House.ShowScore() <= 21)
            {
                Console.WriteLine("House wins!");
            }
            else if(Player.ShowScore() <= 21 && House.ShowScore() > 21)
            {
                Console.WriteLine("You win!");
            }
            else if(Player.ShowScore() <= 21 && House.ShowScore() <= 21)
            {
                if(Player.ShowScore() > House.ShowScore())
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("House wins!");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static int CardValue(string C)
        {
            string str = C.Remove(C.Length - 1);

            try
            {
                int value = int.Parse(str);
                return value;
            }
            catch (FormatException)
            {
                if (str == "a") return 11;
                else return 10;
            }
        }

        static string DealCard(BJPlayer P, BJDeck D, Random r)
        {
            string card = D.DrawCard(r);
            P.TakeCard(card);
            P.AddScore(CardValue(card));
            return card;
        }
    }
}
