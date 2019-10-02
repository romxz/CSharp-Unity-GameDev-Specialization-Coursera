using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    /// <summary>
    /// Generates random numbers
    /// </summary>
    static class RandomNumberGenerator
    {
        static Random rand;

        /// <summary>
        /// Initializes the random number generator
        /// </summary>
        public static void Initialize()
        {
            rand = new Random();
        }

        /// <summary>
        /// Returns a non-negative random integer that is less than the specified 
        /// maximum
        /// </summary>
        /// <param name="maxValue">The exclusive upper bound of the random number 
        ///     to be generated. maxValue must be greater than or equal to 0</param>
        /// <returns>A 32-bit signed integer that is greater than or equal 
        ///     to 0, and less than maxValue; that is, the range of return values 
        ///     ordinarily includes 0 but not maxValue. However, if maxValue 
        ///     equals 0, maxValue is returned</returns>
        public static int Next(int maxValue)
        {
            return rand.Next(maxValue);
        }
    }
}
