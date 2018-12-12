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

            Console.WriteLine("inserisci un numero da convertire");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci la base in cui convertire il numero");
            Vbase = Convert.ToInt32(Console.ReadLine());

            //conversione
            string convertitore = Convert.ToString(num, Vbase);          
            risultato = Convert.ToString(num, Vbase) + risultato;
            Console.WriteLine($"il numero convertito è {risultato}");


            Console.ReadLine();
        }
    }
}
