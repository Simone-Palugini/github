using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_conversione
{
    class Program
    {
        static void Main(string[] args)
        {
            string risultato = ""; int num = 0, Vbase=0;

            do
            {
                Console.WriteLine("inserisci un numero da convertire");
                num = Convert.ToInt32(Console.ReadLine());   
                if (num < 0)
                {
                    Console.WriteLine("il numero deve essere maggiore di 0, reinseriscilo");
                }
            }
            while (num < 0);

            do
            {
                Console.WriteLine("inserisci la base in cui convertire il numero");
                Vbase = Convert.ToInt32(Console.ReadLine());
                if (Vbase != 2 && Vbase != 8 && Vbase != 16)
                {
                    Console.WriteLine("si può convertire solo in base 2, 8, e 16, reinserisci la base");
                }
            }
            while (Vbase != 2 && Vbase != 8 && Vbase != 16);

            //conversione
            string convertitore = Convert.ToString(num, Vbase);          
            risultato = Convert.ToString(num, Vbase) + risultato;
            Console.WriteLine($"il numero convertito è {risultato}");


            Console.ReadLine();
        }
    }
}
