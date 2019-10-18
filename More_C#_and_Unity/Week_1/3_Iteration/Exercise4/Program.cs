using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise4 {
    class Program {

        /// <summary>
        /// Exercise4: For and Foreach
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            
            // Problem 1
            Console.WriteLine("Type in a lower bound integer:");
            int lowerBound = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in an upper bound integer:");
            int higherBound = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = lowerBound; i <= higherBound; i++) Console.WriteLine(i);
            Console.WriteLine();

            // Problem 2
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();
            deck.Shuffle();

            // Problem 3
            for (int i = 0; i < 5; i++) hand.Add(deck.TakeTopCard());
            for (int i = 0; i < hand.Count; i++) hand[i].FlipOver();
            foreach (Card card in hand) card.Print();
        }
        
    }
}
