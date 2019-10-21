using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    /// <summary>
    /// A sharing kid
    /// </summary>
    class SharingKid : Kid
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SharingKid() : base()
        {
        }

        /// <summary>
        /// Prints a message
        /// </summary>
        public override void PrintMessage()
        {
            Console.WriteLine("Would you like my cookie?");
        }
    }
}

