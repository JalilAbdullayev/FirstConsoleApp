using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            string name = "Jalil"; //default: ""
            char letter = 'a'; //default: \0
            Console.Write("Your name is ");
            Console.WriteLine(name);
            Console.WriteLine(letter);
            Console.ReadLine();
        }
    }
}
