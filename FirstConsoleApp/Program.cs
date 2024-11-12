using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            double age = 24;
            //age++; //25
            //age--; //24
            //age = age + 10;
            //age += 10 // 34;
            //age -= 10 // 14;
            //age *= 10 // 240;
            age /= 10; // int-dirsə 2.4 -> 2. Double-da elə 2.4.
            Console.WriteLine(age);

            string name = "Jalil";
            name += " is a programmer.";
            Console.WriteLine(name); // Jalil is a programmer.

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++); // 0
            Console.WriteLine(++i); // 2
            Console.ReadLine();
        }
    }
}
