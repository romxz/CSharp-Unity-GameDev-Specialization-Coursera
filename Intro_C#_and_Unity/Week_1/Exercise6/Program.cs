using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in an angle in degrees:");
            float degrees = float.Parse(Console.ReadLine());
            float cos = (float)Math.Cos(degrees * Math.PI / 180);
            Console.WriteLine("Cosine: " + cos);
            float sin = (float)Math.Sin(degrees * Math.PI / 180);
            Console.WriteLine("Sine: " + sin);
        }
    }
}
