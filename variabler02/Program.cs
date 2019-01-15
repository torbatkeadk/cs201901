using System;

namespace variabler02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            if (true)
            {
                DateTime d1 = DateTime.Now;
                DateTime d2 = d1.AddDays(10);
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                d2 = d2.AddMinutes(20);
                Console.WriteLine(d2);
                d2 = d2.AddMonths(-1);
                Console.WriteLine(d2);
                DateTime d3 = DateTime.Now;
                Console.WriteLine((DateTime)d3-d2);
           
                            }
            

            // strenge
            if (!true)
            {
                string fornavn = "Torben";
                string efternavn = "Bertelsen";
                string samletNavn = fornavn + " " + efternavn;
                string navnStort = samletNavn.ToUpper() ;
                string navnLille = samletNavn.ToLower();
                string substring = samletNavn.Substring(2,4);
                Console.WriteLine($"fornavn  \t: { fornavn} ");
                Console.WriteLine($"Efternavn\t: {efternavn}");
                Console.WriteLine($"Samletnavn\t: {samletNavn}");
                Console.WriteLine($"navnStort\t: {navnStort}");
                Console.WriteLine($"NavnLille\t: { navnLille}");
                Console.WriteLine($"substring\t: { substring}");
                Console.WriteLine($"substring\t: \n{ substring}");
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
