using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in first altitude:");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in second altitude:");
            int secondAltitude = int.Parse(Console.ReadLine());
            Console.WriteLine("Altitude Change: " + (secondAltitude - firstAltitude));
        }
    }
}
