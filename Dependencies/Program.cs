using System;
using System.Collections.Generic;
using System.Linq;

namespace Dependencies
{
    class Program
    {
        static void Main(String[] args)
        {
            Player user = new Player();
            namapemain Haikal = new namapemain(user,"Haikal");
            Haikal.berlari();
            Haikal.melompat();
            Haikal.berguling();
        
            Player user2 = new Player();
            namapemain Reza = new namapemain(user2,"Reza");
            Reza.berlari();
            Reza.melompat();
            Reza.berguling();
        }
    }
}