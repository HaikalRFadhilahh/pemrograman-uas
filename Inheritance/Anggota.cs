using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Inheritance
{
    public class Paladin : Hero
    {

        public void serang()
        {
            Console.WriteLine("Paladin Memukul,Damage Ke Lawan : " + getdamagebasicattack());
        }

        public void ultimate()
        {
            Console.WriteLine("Paladin Mengeluarkan Ultimate (Pedang Berputar) Damage : " + getdamageulti());
        }
    }

    public class Sniper : Hero
    {
        public void serang()
        {
            Console.WriteLine("Sniper Menembak,Damage Ke Lawan : " + getdamagebasicattack());
        }

        public void ultimate()
        {
            Console.WriteLine("Sniper Mengeluarkan Ultimate (Peluru Penghancur Hati) Damage : " + getdamageulti());
        }
    }

    public class Priest : Hero
    {
        public void serang()
        {
            Console.WriteLine("Priest Menyihir,Damage Ke Lawan : " + getdamagebasicattack());
        }

        public void ultimate()
        {
            Console.WriteLine("Priest Mengeluarkan Ultimate (Perisai Pendorong) Damage : " + getdamageulti());
        }
    }
}