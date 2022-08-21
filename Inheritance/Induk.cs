using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Inheritance
{
    public class Hero
    {
        private int Health = 100;
        private int damageulti;
        private int basicattack;
        public void senddamage(int battack,int dulti)
        {
            this.damageulti = dulti;
            this.basicattack = battack;
        }
        public int getdamageulti()
        {
            return damageulti;
        }
        public int getdamagebasicattack()
        {
            return basicattack;
        }
        public int gethealth()
        {
            return Health;
        }
    }
}