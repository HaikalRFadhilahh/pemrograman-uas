using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Inheritance
{
    class Program
    {
        static void Main(String[] args)
        {
            Paladin paladin = new Paladin();
            Sniper sniper = new Sniper();
            Priest priest = new Priest();


            Console.WriteLine("DRAGON NEST HERO");
            Console.WriteLine("HERO Paladin (Warrior)");
            paladin.senddamage(24,340);
            paladin.serang();
            paladin.ultimate();
            Console.WriteLine("");


            Console.WriteLine("HERO Priest (Clerik)");
            sniper.senddamage(21,287);
            sniper.serang();
            sniper.ultimate();
            Console.WriteLine("");


            Console.WriteLine("HERO Sniper (Archer)");
            priest.senddamage(13,435);
            priest.serang();
            priest.ultimate();
            Console.WriteLine("");
        }
    }
}