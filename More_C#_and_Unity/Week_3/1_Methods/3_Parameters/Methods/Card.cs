using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /// <summary>
    /// A playing card
    /// </summary>
    class Card
    {
        #region Fields

        Rank rank;
        Suit suit;
        bool faceUp;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a card with the given rank and suit
        /// </summary>
        /// <param name="rank">the rank</param>
        /// <param name="suit">the suit</param>
        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
            faceUp = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the card rank
        /// </summary>
        public Rank Rank
        {
            get { return rank; }
        }

        /// <summary>
        /// Gets the card suit
        /// </summary>
        public Suit Suit
        {
            get { return suit; }
        }

        /// <summary>
        /// Gets whether or not the card is face up
        /// </summary>
        public bool FaceUp
        {
            get { return faceUp; }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Flips the card over
        /// </summary>
        public void FlipOver()
        {
            faceUp = !faceUp;
        }

        /// <summary>
        /// Prints the card
        /// </summary>
        public void Print()
        {
            if (faceUp)
            {
                Console.WriteLine(rank + " of " + suit);
            }
            else
            {
                Console.WriteLine("Card is face down");
            }
        }

        #endregion
    }
}

