using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /// <summary>
    /// A Closer Look at Methods code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates passing an object as an argument
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // build a hand of cards
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Rank.Two, Suit.Clubs));
            hand.Add(new Card(Rank.Three, Suit.Diamonds));
            hand.Add(new Card(Rank.Four, Suit.Hearts));
            hand.Add(new Card(Rank.Three, Suit.Spades));
            hand.Add(new Card(Rank.Two, Suit.Clubs));

            // cheat
            CardChanger cardChanger = new CardChanger();
            foreach (Card card in hand)
            {
                cardChanger.ChangeCard(card);
            }

            // print cheating results
            foreach (Card card in hand)
            {
                card.FlipOver();
                card.Print();
            }

            Console.WriteLine();
        }
    }
}