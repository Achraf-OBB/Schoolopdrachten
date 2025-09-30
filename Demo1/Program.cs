using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hallo, dit ben ik");
            Console.WriteLine("Wie ben jij?");
            string result;
            result = Console.ReadLine();
            Console.WriteLine("Dag " + result + ", hoe gaat het met je?");
            
            Console.WriteLine("Geef leeftijd");
            string leeftijd;
            leeftijd = Console.ReadLine();
            
            Console.WriteLine("Geeft adres");
            string adres;
            adres = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("We hebben alle bijnodige informatie, dank.");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("Druk op Enter om dit progamma te sluiten.");

            Console.ReadKey();
        }
    }
}
