using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ForeachLoops {
    /// <summary>
    /// Foreach Loops lecture code
    /// </summary>
    class Program {
        /// <summary>
        /// Demonstrates foreach loops
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
            Console.WriteLine();
            //for (int i = 0; i < hand.Count; i++) {
            foreach (Card card in hand) {
                Console.WriteLine(card.Rank + " of " +
                    card.Suit);
            }

            // add 5 cards to hand
            for (int i = 0; i < 5; i++) {
                hand.Add(deck.TakeTopCard());
            }

            // print cards in the hand
            Console.WriteLine();
            //for (int i = 0; i < hand.Count; i++) {
            foreach (Card card in hand) {
                Console.WriteLine(card.Rank + " of " +
                    card.Suit);
            }

            Console.WriteLine();
        }
    }
}
