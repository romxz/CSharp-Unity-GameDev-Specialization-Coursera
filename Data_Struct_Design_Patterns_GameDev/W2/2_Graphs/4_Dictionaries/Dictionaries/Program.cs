using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries {
    /// <summary>
    /// Dictionaries lecture code
    /// </summary>
    class Program {
        /// <summary>
        /// Demonstrates using a dictionary
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // create dictionary of high scores by gamertag
            Dictionary<string, int> highScores = new Dictionary<string, int>();
            highScores.Add("Joe", 100);
            highScores.Add("Bob", 9000);
            highScores.Add("JoeBob", 1);

            // prompt for and get gamertag from user
            Console.WriteLine("Enter gametag: ");
            string gamertag = Console.ReadLine();

            // print high score or error message for gamertag
            if (highScores.ContainsKey(gamertag)) {
                Console.WriteLine($"Score: [{highScores[gamertag]}]");
            } else {
                Console.WriteLine("No such gamertag");
            }

            Console.WriteLine();
        }
    }
}
