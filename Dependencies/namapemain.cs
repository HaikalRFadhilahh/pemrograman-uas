using System;
using System.Collections.Generic;
using System.Linq;

namespace Dependencies
{
    public class namapemain
    {
        private Player player;

        public namapemain(Player player,string nama)
        {
            this.player = player;
            this.player.nama = nama;
        }

        public void berlari()
        {
            player.lari(2,"KM");
        }
    
        public void melompat()
        {
            player.lompat();
        }

        public void berguling()
        {
            player.guling();
        }
    }
}