using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates exception handling
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            try
            {
                // prompt for and get score
                Console.Write("Enter score (as a whole number): ");
                int score = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("That's not a whole number!");
            }
            catch (OverflowException fe)
            {
                Console.WriteLine("That number is out of range!");
            }
            finally
            {
                Console.WriteLine("GG");
            }

            Console.WriteLine();
        }
    }
}
