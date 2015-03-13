using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Value Calculator");
            Console.WriteLine("==========================");
            Console.WriteLine("\nPlease enter the Fibonacci Value you wish to calculate");
            Console.WriteLine("(This works best with small positive values):");

            try
            {
                RunFibonacci(false);

                char again;
                Console.WriteLine("\nWould you like to find another value? (Y|N):");
                while (char.TryParse(Console.ReadLine(), out again) && again.ToString().ToUpper().Contains('Y'))
                {
                    RunFibonacci(true);
                    Console.WriteLine("\nWould you like to find another value? (Y|N):");
                }

                Console.WriteLine("\nOK, thanks for using the Fibonacci Value Calculator. Bye.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("\nOh no! Something went wrong!\nHere are the exception details, report them to your Programmer:\n{0}", e.ToString());
                Console.ReadKey();
            }
            
        }

        public static void RunFibonacci(bool runagain)
        {
            if (runagain)
            {
                Console.WriteLine("\nPlease enter the Fibonacci Value you wish to calculate");
                Console.WriteLine("(Remember, this works best with small positive values):");
            }

            long n;
            while (!long.TryParse(Console.ReadLine(), out n) || (n < 0))
            {
                string s = (n < 0) ? "Your value must be positive for this to work:"
                                 : "Sorry, that's not a real value. Have another go:";
                Console.WriteLine(s);
            }

            Console.WriteLine("\nPlease wait while your value is being calculated...");
            if (n > 48)
            {
                Console.WriteLine("\nYou've entered a rather large value, this could take a while. Maybe go grab a coffee!");
            }

            Console.WriteLine("\nThe value at position {0} of the Fibonacci Sequence is {1} ", n, Fibonacci(n));
        }

        public static long Fibonacci(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
