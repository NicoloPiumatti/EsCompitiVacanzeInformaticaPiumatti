using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es7Vacanze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fib;
            do
            {
                Console.WriteLine("Inserire n");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);
            fib = fibonacci(n);
            Console.WriteLine("Il risultato finale di fibonacci è " + fib);
        }

        private static int fibonacci(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
