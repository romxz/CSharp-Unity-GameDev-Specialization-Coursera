using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4 {
    class ArtisticKid : Kid {

        public ArtisticKid() : base() {

        }

        public override void PrintMessage() {
            Console.WriteLine("I like art");
        }
    }
}
