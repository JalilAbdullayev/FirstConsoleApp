using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            //int x = 10;
            //int y = 20;
            //int z = 30;
            int x = 10, y = 20, z = 30;

            int age = 24;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue); //2147483647
            Console.WriteLine(int.MinValue); //-2147483648

            long bigNumber = -900000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue); //9223372036854775807
            Console.WriteLine(long.MinValue); //-9223372036854775808

            double negative = -55.2;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue); //1,79769313486232E+308
            Console.WriteLine(double.MinValue); //-1,79769313486232E+308

            float precision = 5.000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue); //3,402823E+38
            Console.WriteLine(float.MinValue); //-3,402823E+38

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue); //79228162514264337593543950335
            Console.WriteLine(decimal.MinValue); //-79228162514264337593543950335
            Console.ReadLine();
        }
    }
}
