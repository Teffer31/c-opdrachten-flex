﻿using System;

namespace VariableOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            string naam = ("Bingus");
            int hp = 22;
            int str = 12;


            //nu zou de statement hieronder moeten werken
            Console.WriteLine($"{naam} {hp} {str}");
        }
    }

}
//maak hier 3 local variables aan:
//1 type=string, naam: name, waarde je favoriete rpg character
//2 type=int, naam: hp, een waarde van hoeveel health dit character heeft
//3 type=int, naam: str, een waarde van hoe sterk dit character is  