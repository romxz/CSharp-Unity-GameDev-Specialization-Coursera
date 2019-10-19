using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieExample {
    /// <summary>
    /// A die
    /// </summary>
    public class Die {
        #region Fields

        int numSides;
        int topSide;
        Random rand = new Random();

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for six-sided die
        /// </summary>
        public Die() : this(6) {
        }

        /// <summary>
        /// Constructor for die with numSides sides
        /// </summary>
        /// <param name="numSides">number of sides</param>
        public Die(int numSides) {
            this.numSides = numSides;
            topSide = 1;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of sides
        /// </summary>
        /// <value>number of sides</value>
        public int NumSides {
            get { return numSides; }
        }

        /// <summary>
        /// Gets the top side
        /// </summary>
        /// <value>top side</value>
        public int TopSide {
            get { return topSide; }
        }

        #endregion

        #region Methods

        public void Roll() {
            topSide = rand.Next(1, this.numSides + 1);
        }

        #endregion
    }
}

