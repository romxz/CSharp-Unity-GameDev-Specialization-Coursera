using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharDataType
{
    /// <summary>
    /// The Char Data Type lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Gets user menu choice and prints message
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print menu
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("N – New Game");
            Console.WriteLine("L – Load Game");
            Console.WriteLine("O – Options");
            Console.WriteLine("Q – Quit");
            Console.WriteLine("**************");
            Console.WriteLine();

            // prompt for and get choice
            Console.Write("Enter your choice (N, L, O or Q): ");
            char choice = Console.ReadLine().ToUpper()[0];
            Console.WriteLine();

            // print message
            if (choice == 'N')
            {
                Console.WriteLine("Creating new game ...");
            }
            else if (choice == 'L')
            {
                Console.WriteLine("Loading game ...");
            }
            else if (choice == 'O')
            {
                Console.WriteLine("Setting options ...");
            }
            else if (choice == 'Q')
            {
                Console.WriteLine("Quitting ...");
            }
            else
            {
                Console.WriteLine("That's not a valid menu choice!");
            }

            Console.WriteLine();
        }
    }
}
