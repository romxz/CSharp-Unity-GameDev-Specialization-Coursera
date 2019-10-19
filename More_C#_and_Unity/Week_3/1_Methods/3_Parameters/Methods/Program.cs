using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods {
    /// <summary>
    /// A Closer Look at Methods code
    /// </summary>
    class Program {
        /// <summary>
        /// Demonstrates various methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            Deck deck = new Deck();

            // method with no return value, no parameters
            //deck.Shuffle();

            // method with return value, no parameters
            //Card topCard = deck.TakeTopCard();
            //topCard.FlipOver();
            //topCard.Print();

            // method with no return value, with parameters
            //deck.Cut(deck.Count / 2);

            // method with return value, with parameters
            Card card = deck.TakeCard(deck.Count - 1);
            card.FlipOver();
            card.Print();
            card = deck.TakeCard(0);
            card.FlipOver();
            card.Print();

            Console.WriteLine();
        }
    }
}
