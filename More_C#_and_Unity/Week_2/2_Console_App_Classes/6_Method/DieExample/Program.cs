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

            // test d20 die
            Die d20Die = new Die(20);
            Console.WriteLine("D20 Die");
            Console.WriteLine("-------");
            Console.WriteLine("Number of sides: " + d20Die.NumSides);
            Console.WriteLine("Top side: " + d20Die.TopSide);

            Console.WriteLine();
        }
    }
}
