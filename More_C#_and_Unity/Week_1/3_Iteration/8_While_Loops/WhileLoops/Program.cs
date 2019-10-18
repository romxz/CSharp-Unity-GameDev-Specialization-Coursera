using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops {
    /// <summary>
    /// While Loops lecture code
    /// </summary>
    class Program {
        /// <summary>
        /// Demonstrates while loops
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // prompt for and get level
            Console.Write("What level are you in WoW (1-110)? ");
            int level = int.Parse(Console.ReadLine());

            // input validation
            while (level < 1 || level > 110) {
                // print error and reprompt
                Console.WriteLine("Level must be betweeen 1 and 110 ");
                Console.Write("What level are you in WoW (1-110)? ");
                level = int.Parse(Console.ReadLine());
            }

            // print level
            Console.WriteLine();
            Console.WriteLine("Got it, you're level " + level);

            Console.WriteLine();
        }
    }
}