using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleBatch
{
    class Program
    {
        static void Main(string[] args)
        {

            string imie = args[0];
            string nazwisko = args[1];
            int wiek = Convert.ToInt32(args[2]);

            Console.WriteLine($"Witaj {imie} {nazwisko}");

            Console.WriteLine($"Twoj wiek: {wiek}");

            if(wiek>0)
            {
                if(wiek>=67)
                {
                    Console.WriteLine("Jestes emerytem");

                }
                else
                {
                    Console.WriteLine($"Do emerytury zostalo ci: {67-wiek}");
                }
            }
            else
            {
                Console.WriteLine("Bledne Dane");
            }



        }
    }
}
