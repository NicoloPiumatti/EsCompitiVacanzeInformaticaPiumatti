using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es2Vacanze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dado, cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt4 = 0, cnt5 = 0, cnt6 = 0, cntGen = 0;
            Random rnd = new Random();
            do
            {
                dado = rnd.Next(0, 7);
                if (dado == 1)
                {
                    cnt1++;
                }
                else if (dado == 2)
                {
                    cnt2++;
                }
                else if (dado == 3)
                {
                    cnt3++;
                }
                else if (dado == 4)
                {
                    cnt4++;
                }
                else if (dado == 5)
                {
                    cnt5++;
                }
                else if(dado == 6)
                    cnt6++;
                cntGen++;
                Console.WriteLine(dado);
            } while (dado != 0);
            cntGen = cntGen - 1; // Lancio 0 da non includere
            Console.WriteLine("Lanci totali effettuati: " + cntGen + ".\n 1: " + cnt1 + " volte\n 2: " + cnt2 + " volte\n 3: " + cnt3 + " volte\n 4: " + cnt4 + " volte\n 5: " + cnt5 + " volte\n 6: " + cnt6 + " volte");
            Console.ReadKey();
        }
    }
}
