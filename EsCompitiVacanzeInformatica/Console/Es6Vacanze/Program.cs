using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es6Vacanze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sommaSucc;
            Console.WriteLine("Inserire n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire n2");
            n2 = int.Parse(Console.ReadLine());
            sommaSucc = funzRic(n1, n2);
            Console.WriteLine("Il risultato finale è " + sommaSucc);
        }

        private static int funzRic(int n1, int n2)
        {
            if (n2 == 0)
            {
                return 0;
            }
            return n1 + funzRic(n1, n2 - 1);
        }
    }
}
