using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Opdracht_Romel_zin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je favoriete kleur:");
            string kleur;
            kleur = Console.ReadLine();

            Console.WriteLine("Geef je favoriete eten:");
            string eten;
            eten = Console.ReadLine();

            Console.WriteLine("Geef je favoriete auto:");
            string auto;
            auto = Console.ReadLine();

            Console.WriteLine("Geef je favoriete boek:");
            string boek;
            boek = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Je favoriete kleur is " + eten + ". ");
            Console.Write("Je eet graag " + auto + ". ");
            Console.Write("Je lievelingsfilm is " + boek + " ");
            Console.Write("en je favoriete boek is " + kleur);

            Console.WriteLine();
        }
    }
}
