using System;
using System.Collections.Generic;
using System.Text;

namespace abstrak
{
    class pocox3pro : Hp
    {
        private string spek;
        private string batrai;
        private string color;
        private string ram;
        public pocox3pro(string spek, string batrai, string color, string ram)
        {
            this.spek = spek;
            this.batrai = batrai;
            this.color = color;
            this.ram = ram;
        }
        public override string getSpek()
        {
            return this.spek;
        }
        public override string getBatrai() 
        {
            return this.batrai;
        }
        public override string getColor()
        {
            return this.color;
        }
        public override string getRam()
        {
            return this.ram;
        }


    }
}