using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDataTypes
{
    /// <summary>
    /// Integer Data Types lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrate C# int data types
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;
            // calc mins and seconds
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

            // print results
            Console.WriteLine("Minutes played: " + minutesPlayed);
            Console.WriteLine("Seconds played: " + secondsPlayed);
        }
    }
}
