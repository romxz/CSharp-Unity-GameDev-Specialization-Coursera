using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieExample
{
    /// <summary>
    /// Demonstrates testing a Die class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests the die class
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // test standard die
            Die standardDie = new Die();
            Console.WriteLine("Standard Die");
            Console.WriteLine("------------");
            Console.WriteLine("Number of sides: " + standardDie.NumSides);
            Console.WriteLine("Top side: " + standardDie.TopSide);

            Console.WriteLine();
        }
    }
}
