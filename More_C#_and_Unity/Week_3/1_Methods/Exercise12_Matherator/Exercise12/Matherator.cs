using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    /// <summary>
    /// Provides a variety of numeric methods
    /// </summary>
    class Matherator
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Matherator()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prints the numbers from 1 to 10
        /// </summary>
        public void PrintOneToTen()
        {
            PrintMToN(1, 10);
        }

        /// <summary>
        /// Prints the numbers from m to n
        /// </summary>
        /// <param name="m">m</param>
        /// <param name="n">n</param>
        public void PrintMToN(int m, int n)
        {
            for (int i = m; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Returns the tenth even number, starting at 1
        /// </summary>
        /// <returns>tenth even number</returns>
        public int GetTenthEvenNumber()
        {
            return GetNthEvenNumber(10);
        }

        /// <summary>
        /// Returns the nth even number, starting at 1
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>nth even number</returns>
        public int GetNthEvenNumber(int n)
        {
            // of course, returning 2 * n would work
            // here, but I wanted to get more practice
            // with my coding!
            int evenCount = 0;
            int i = 0;
            while (evenCount < n)
            {
                i++;
                if (i % 2 == 0)
                {
                    evenCount++;
                }
            }
            return i;
        }

        #endregion
    }
}
