using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HelloConsoleVBDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interaction.MsgBox("Aplikacja na powitanie!",MsgBoxStyle.OkOnly | MsgBoxStyle.Information,"Tytul okienka");

           
            string imie=Interaction.InputBox("Podaj imie","Okienko imie");
            Console.WriteLine($"Podano imie {imie}");

            string nazwisko = Interaction.InputBox("Podaj nazwisko", "Okienko nazwisko");
            Console.WriteLine($"Podano nazwisko {nazwisko}");

            Interaction.MsgBox($"Wiaj {imie} {nazwisko} ", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Powitanie");

            int wiek = Convert.ToInt32(Interaction.InputBox("Podaj swoj wiek", "Okienko wiek"));
            if(wiek>=67)
            {

                Interaction.MsgBox($"Jestes emerytem", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
            }
            else
            {
                Interaction.MsgBox($"Do emerytury zostalo ci {67-wiek} lat/lata ", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
            }
        }
    }
}
