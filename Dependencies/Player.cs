using System;
using System.Collections.Generic;
using System.Linq;

namespace Dependencies
{

    public class Player
    {
        
        public string nama;

        public void lari(int jarak,string konversi)
        {
            Console.WriteLine("Player " + this.nama + " Berlari Sejauh " + jarak + " " + konversi);
        }

        public void lompat()
        {
            Console.WriteLine("Player " + this.nama + " Melompat");
        }

        public void guling()
        {
            Console.WriteLine("Player " + this.nama + " Berguling");
        }
    }
}