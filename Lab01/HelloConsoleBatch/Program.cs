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

            string imie="";
            string nazwisko="";
            int wiek=0;

            //Console.WriteLine($"Witaj {imie} {nazwisko}");

            //Console.WriteLine($"Twoj wiek: {wiek}");

            if(args.Length != 0)
            {
            wiek = Convert.ToInt32(args[2]);
                if(args.Length ==1)
                {
                    imie = args[0];
                        Console.WriteLine($"Witaj {imie}");

                }else
                    if(args.Length == 2)
                    {
                        imie = args[0];
                        nazwisko = args[1];
                        Console.WriteLine($"Witaj {imie} {nazwisko}");

                    }else
                if(wiek>0)
                {       
                   
                imie = args[0];
                nazwisko = args[1];

                    if(wiek>=67)
                    {
                        Console.WriteLine("Jestes emerytem");

                    }
                    else
                    {
                        Console.WriteLine($"Do emerytury zostalo ci: {67-wiek}");
                    }

                }else
                    {
                        Console.WriteLine("Bledne Dane");
                    }
           
            }else
                {
                    Console.WriteLine("Bledne Dane");
                }
        }    
    }

}
