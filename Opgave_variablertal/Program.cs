using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_variablertal
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 10;
            Console.WriteLine(tal1);
            tal1++;
            Console.WriteLine(tal1);
            tal1--;
            Console.WriteLine(tal1);
            tal1+=20;
            Console.WriteLine(tal1);

            double tal2 = 12.5;
            Console.WriteLine(tal2);
            // test

            tal2++;
            Console.WriteLine(tal2);
            tal2--;
            Console.WriteLine(tal2);
            tal2 *= 2;
            Console.WriteLine(tal2);




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }

    }
}
