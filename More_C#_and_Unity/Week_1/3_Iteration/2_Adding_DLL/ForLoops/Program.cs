using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ForLoops {
    /// <summary>
    /// For Loops lecture code
    /// </summary>
    class Program {
        /// <summary>
        /// Demonstrates for loops
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            // add a few cards to the list
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());

            // print cards in the hand
            for (int i = 0; i < hand.Count; i++) {
                Console.WriteLine(hand[i].Rank + " of " + hand[i].Suit);
            }

            // add 5 cards to hand
            for (int i = 0; i < 5; i++) {
                hand.Add(deck.TakeTopCard());
            }

            // print cards in the hand
            Console.WriteLine();
            for (int i = 0; i < hand.Count; i++) {
                Console.WriteLine(hand[i].Rank + " of " + hand[i].Suit);
            }
        }
    }
}
