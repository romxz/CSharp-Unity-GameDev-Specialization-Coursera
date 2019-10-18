using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5 {
    class Program {
        static string[] menu = new string[4] {"NewGame", "LoadGame", "Options", "Quit"};

        static void Main(string[] args) {
            // Problem 1
            printMenu();

            int choice = choicePrompt();

            do {
                while (choice < 1 || choice > menu.Length) {
                    Console.WriteLine("Valid choices are 1-" + menu.Length);
                    choice = choicePrompt();
                }
                Console.WriteLine("Selected " + menu[choice - 1] + "...");
                choice = choicePrompt();
            } while (choice != 4);
            Console.WriteLine("Selected " + menu[choice - 1] + "...");
        }

        static void printMenu() {
            Console.WriteLine("*********");
            Console.WriteLine("Menu:");
            for (int i = 0; i < menu.Length; i++) Console.WriteLine("" + (i + 1) + "-" + menu[i]);
            Console.WriteLine("*********");
        }

        static int choicePrompt() {
            Console.Write("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
