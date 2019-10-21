using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    /// <summary>
    /// A kid
    /// </summary>
    class Kid
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Kid()
        {
        }

        /// <summary>
        /// Prints a message
        /// </summary>
        public virtual void PrintMessage()
        {
            Console.WriteLine("Sometimes, I feel I gotta get away");
        }
    }
}
