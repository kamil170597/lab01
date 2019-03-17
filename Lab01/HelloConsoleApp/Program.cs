using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie.");
            Console.Write("Podaj imie:");
            string imie;
            imie = Console.ReadLine();
            Console.Write("Podaj nazwisko:");
            string nazwisko;
            nazwisko = Console.ReadLine();
            Console.WriteLine($"Witaj {imie} {nazwisko}");
            Console.WriteLine($"Witaj {imie} {nazwisko}. Czy Pan {nazwisko} rzeczywiscie nazywa sie {imie}");

            Console.Write("Podaj Wiek:");
            int wiek = Convert.ToInt32(Console.ReadLine());
            if(wiek < 67)
            {
                Console.WriteLine("do emerytury zostalo ci {0}",67-wiek );
            }
            else
            {
                Console.WriteLine(" jestes emerytem");
            }
        }
    }
}
