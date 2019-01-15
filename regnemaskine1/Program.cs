using System;

namespace regnemaskine1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej til min regnemaskine!");

            // bed om tal 1
            Console.Write("Indtast tal 1 :");
            string tal1S = Console.ReadLine();
            //bed om tal2
            Console.Write("Indtast tal 2 :");
            string tal2S = Console.ReadLine();

            double tal1D = Convert.ToDouble(tal1S);
            double tal2D = Convert.ToDouble(tal2S);
            Console.Write("sum : ");
            double sumD = tal1D + tal2D;

            Console.WriteLine(sumD.ToString("N2"));


            //Console.WriteLine

            //Console.WriteLine(System.Math.)




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
