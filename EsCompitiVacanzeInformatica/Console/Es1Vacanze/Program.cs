using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1Vacanze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, n;
            do
            {
                Console.WriteLine("Inserire x");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserire n multipli");
                n = Convert.ToInt32(Console.ReadLine());
            } while (x < 0 || n < 0);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(x + " * " + i + " = " + x * i);
            }
            Console.ReadKey();
        }
    }
}
