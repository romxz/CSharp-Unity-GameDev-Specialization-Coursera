using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise1 {
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // Problem 1
            Deck deck = new Deck();
            Card[] cards = new Card[5];
            deck.Shuffle();
            // Problem 2
            cards[0] = deck.TakeTopCard();
            cards[0].FlipOver();
            cards[0].Print();
            // Problem 3
            cards[1] = deck.TakeTopCard();
            cards[1].FlipOver();
            for (int i = 0; i < 2; i++) {
                cards[i].Print();
            }
            //Console.WriteLine();
        }
    }
}
