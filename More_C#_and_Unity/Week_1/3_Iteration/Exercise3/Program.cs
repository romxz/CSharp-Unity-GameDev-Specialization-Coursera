using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            List<int> intHolder = new List<int>();

            // Problem 1
            for (int i = 1; i <= 10; i++) intHolder.Add(i);
            for (int i = 0; i < intHolder.Count; i++) Console.WriteLine(intHolder[i]);

            Console.WriteLine();

            // Problem 2
            for (int i = 2*(intHolder.Count / 2) - 1; i >=0; i -= 2) intHolder.RemoveAt(i);
            for (int i = 0; i < intHolder.Count; i++) Console.WriteLine(intHolder[i]);

            Console.WriteLine();

            // Problem 3
            intHolder = new List<int>();
            for (int i = 1; i <= 5; i++) intHolder.Add(i);
            for (int i = 0; i < 3; i++) intHolder.RemoveAt(i);
            for (int i = 0; i < intHolder.Count; i++) Console.WriteLine(intHolder[i]);
        }
    }
}
