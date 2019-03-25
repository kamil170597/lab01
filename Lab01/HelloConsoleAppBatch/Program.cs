using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleAppBatch
{
    class Program
    {
        static void Main(string[] args)
        {

            string imie="";
            string nazwisko="";
            int wiek;

            if(args.Length ==0 )
            {
          
                Console.Write($"Podaj imie: ");
                imie=Console.ReadLine();
                Console.Write("Podaj nazwisko: ");
                nazwisko=Console.ReadLine();
                Console.Write("Podaj wiek: ");
                wiek=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Witaj {imie} {nazwisko}");

                if(wiek>=67)
                    {
                        Console.WriteLine("Jestes emerytem.");
                    }else
                        {
                            Console.WriteLine($"Do emerytury zostalo ci: {67-wiek}");  
                        }

           }else
                if(args.Length ==1)
                {
                    imie=args[0];
                    Console.Write("Podaj nazwisko: ");
                    nazwisko=Console.ReadLine();
                    Console.Write("Podaj wiek: ");
                    wiek=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Witaj {imie} {nazwisko}");

                    if(wiek>=67)
                        {
                            Console.WriteLine("Jestes emerytem.");
                        }else
                            {
                                Console.WriteLine($"Do emerytury zostalo ci: {67-wiek}");  
                            }


                }else if(args.Length ==2)
                {
                    imie=args[0];
                    nazwisko=args[1];
                    Console.Write("Podaj wiek: ");
                    wiek=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Witaj {imie} {nazwisko}");

                    if(wiek>=67)
                        {
                            Console.WriteLine("Jestes emerytem.");
                        }else
                            {
                                Console.WriteLine($"Do emerytury zostalo ci: {67-wiek}");  
                            }


                }else if(args.Length>=3)
                {
                    imie=args[0];
                    nazwisko=args[1];
                    wiek=Convert.ToInt32(args[2]);
                   if(wiek>=67)
                    {
                        Console.WriteLine("Jestes emerytem.");
                    }else
                        {
                            Console.WriteLine($"Witaj {imie} {nazwisko}");
                            Console.WriteLine($"Twoj wiek: {wiek}");
                            Console.WriteLine($"Do emerytury zostalo ci: {67-wiek}");
                            
                        }
                }
                
        }
    }
}
