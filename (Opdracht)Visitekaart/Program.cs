using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Opdracht_Visitekaart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je voornaam?");
            string voornaam;
            voornaam = Console.ReadLine();

            Console.WriteLine("Wat is je achternaam?");
            string achternaam;
            achternaam = Console.ReadLine();

            Console.WriteLine("Waar woon je?");
            string woonplaats;
            woonplaats = Console.ReadLine();

            Console.WriteLine("Wat is je hobby?");
            string hobby;
            hobby = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Goed. Hier volgt je visitekaartje");
            Console.WriteLine();
            Console.WriteLine("Naam: " + voornaam + " " + achternaam);
            Console.WriteLine("Adres: " + woonplaats);
            Console.WriteLine("Hobby: " + hobby);
        }
    }
}
