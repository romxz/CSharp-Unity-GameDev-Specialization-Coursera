using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileIO
{
    /// <summary>
    /// Demonstrates text file io
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates text file io
        /// </summary>
        /// <param name="args">command-line args</param>

        static void Main(string[] args)
        {
            // write to a text file
            StreamWriter output = null;
            try
            {
                // create stream writer object
                output = File.CreateText("OneStepCloser.txt");

                // write a few lines
                output.WriteLine("Everything you say to me");
                output.WriteLine("Takes me one step closer to the edge");
                output.WriteLine("And I'm about to break");
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

            // read from the text file
            StreamReader input = null;
            try
            {
                // create stream reader object
                input = File.OpenText("OneStepCloser.txt");

                // read and echo lines until end of file
                string line = input.ReadLine();
                while (line != null)
                {
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

            Console.WriteLine();
        }
    }
}

