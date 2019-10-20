using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasics {
    /// <summary>
    /// String Basics lecture code
    /// </summary>
    class Program {
        /// <summary>
        /// Desmonstrates string basics
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // prompt for and read in gamertag
            Console.Write("Enter gamertag: ");
            string gamertag = Console.ReadLine();

            // prompt for and read in high score
            Console.Write("Enter high score as a whole number: ");
            int highScore = int.Parse(Console.ReadLine());

            // extract the first character of the gamertag
            char firstGamertagCharacter = gamertag[0];

            // print out values
            Console.WriteLine("\nGamertag: " + gamertag);
            Console.WriteLine("High Score: " + highScore);
            Console.WriteLine("First Gamertag Character: " + firstGamertagCharacter);
            Console.WriteLine();
        }
    }
}

