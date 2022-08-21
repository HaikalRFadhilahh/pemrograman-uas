using System;
using System.Collections.Generic;
using System.Linq;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Leviathan leviathan = new Leviathan();
            NissanSkylineR34 skyline = new NissanSkylineR34();

            Console.WriteLine("Nissan Skyline R43");
            skyline.checking();
            Console.WriteLine("");

            Console.WriteLine("Helicopter Leviathan");
            leviathan.checkingheli();
            Console.WriteLine("");
        }
    }
}