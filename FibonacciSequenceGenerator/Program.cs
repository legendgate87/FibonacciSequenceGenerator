using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Fibonacci Sequence Generator--" + "\r\n" +
                "" + "\r\n"+
                " Run FibonacciDynamic press - F1" + "\r\n" +
                " Run Fibonacci Int press - F2" + "\r\n" +
                " Run Fibonacci Long press - F3" + "\r\n" +
                " Run Fibonacci loop press - F4" + "\r\n");
         
            var userPress = Console.ReadKey().Key;

            if (userPress == ConsoleKey.F1)
            {
                Console.Clear();
                // Console.WriteLine("" + "\r\n");
                Calculation.FibDynamic();
            }
            else if (userPress == ConsoleKey.F2)
            {
                Console.Clear();
                Console.WriteLine("Enter number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Calculation.Fibonacci2(n);
            }
            else if (userPress == ConsoleKey.F3)
            {
                Console.Clear();
                Console.WriteLine("Enter number: ");
                long n = Convert.ToInt64(Console.ReadLine());
                Calculation.Fibonacci(n);
            }
            else if (userPress == ConsoleKey.F4)
            {
                Console.Clear();
                Calculation.doFiboCal();
            }

            }
    }
}
