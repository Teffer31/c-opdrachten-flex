﻿using System;

namespace CalculateOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xPos = 100;

            xPos++;
            xPos--;
            xPos += 2;
            



            Console.WriteLine("Hello, World!");

            int leeftijdStudent = 16;

            //nu ben je jarig, tel 1 bij je leeftijd op, gebruik de = A+1; constructie (zie video)
            Console.WriteLine("Year 1 Happy birthday!");
            Console.WriteLine($"je bent nu {leeftijdStudent}" );
            xPos = leeftijdStudent += 2;


            //nu ben je weer jarig, tel 1 bij je leeftijd op, gebruik de += 1; constructie (zie video)
            Console.WriteLine("Year 2 Happy birthday!");
            Console.WriteLine($"je bent nu {leeftijdStudent}");
            xPos = leeftijdStudent += 1;


            //nu ben je weer jarig, tel 1 bij je leeftijd op, gebruik de ++; constructie (zie video)
            Console.WriteLine("Year 3 Happy birthday!");
            Console.WriteLine($"je bent nu {leeftijdStudent}");

            xPos = leeftijdStudent ++ ;

            Console.WriteLine(xPos);


            //nu moet er 19 in de console staan als je het programma runt
        }
    }
}