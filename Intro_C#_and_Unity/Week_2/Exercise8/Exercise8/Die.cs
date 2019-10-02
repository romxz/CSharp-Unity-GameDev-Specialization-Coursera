using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise8
{
    /// <summary>
    /// A die
    /// </summary>
    public class Die
    {
        #region Fields

        int topSide;
        int numSides;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for six-sided die
        /// </summary>
        public Die() : this(6)
        {
        }

        /// <summary>
        /// Constructor for a die with the given number of sides
        /// </summary>
        /// <param name="numSides">the number of sides</param>
        public Die(int numSides)
        {
            this.numSides = numSides;
            topSide = 1;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the current top side of the die
        /// </summary>
        public int TopSide
        {
            get { return topSide; }
        }

        /// <summary>
        /// Gets the number of sides the die has
        /// </summary>
        public int NumSides
        {
            get { return numSides; }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Rolls the die
        /// </summary>
        public void Roll()
        {
            topSide = RandomNumberGenerator.Next(numSides) + 1;
        }

        #endregion
    }
}
