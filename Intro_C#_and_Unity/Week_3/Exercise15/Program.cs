using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15 {
    class Program {
        static void Main(string[] args) {
            printMenu();
            String choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    Console.WriteLine("Starting new game");
                    break;
                case "2":
                    Console.WriteLine("Loading game...");
                    break;
                case "3":
                    Console.WriteLine("Loading options...");
                    break;
                case "4":
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }

        private static void printMenu() {
            Console.WriteLine("*************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - NewGame");
            Console.WriteLine("2 - LoadGame");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("*************");
            Console.WriteLine("Please type in your choice (1, 2, 3 or 4):");
        }
    }
}
