using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    /// <summary>
    /// A disobedient kid
    /// </summary>
    class DisobedientKid : Kid
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DisobedientKid() : base()
        {
        }

        /// <summary>
        /// Prints a message
        /// </summary>
        public override void PrintMessage()
        {
            Console.WriteLine("You're not the boss of me!");
        }
    }
}

