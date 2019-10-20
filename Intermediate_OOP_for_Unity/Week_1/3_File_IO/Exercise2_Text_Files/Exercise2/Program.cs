using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates text file IO
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            List<string> inputLines = new List<string>();

            // read from and echo the file
            StreamReader input = null;
            try
            {
                input = File.OpenText("WaitingForTheEnd.txt");

                // read and echo lines until end of file
                string line = input.ReadLine();
                while (line != null)
                {
                    inputLines.Add(line);
                    Console.WriteLine(line);
                    line = input.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // always close input file
                if (input != null)
                {
                    input.Close();
                }
            }

            // output even-numbered lines to output file
            StreamWriter output = null;
            try
            {
                // create stream writer object
                output = File.CreateText("evenNumbered.txt");

                // write even-numbered lines to output file
                for (int i = 1; i < inputLines.Count; i = i + 2)
                {
                    output.WriteLine(inputLines[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // always close output file
                if (output != null)
                {
                    output.Close();
                }
            }

            Console.WriteLine();
        }
    }
}
