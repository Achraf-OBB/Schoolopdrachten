﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Opdracht_Woordenslinger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blauw");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("groen");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("rood");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("geel");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("rood");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blauw");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("groen");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
