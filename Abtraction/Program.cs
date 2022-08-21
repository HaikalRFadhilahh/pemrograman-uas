﻿using System;
using System.Collections.Generic;
using System.Text;

namespace abstrak
{
    class Program
    {
        static void Main(string[] args)
        {
            Hp Oppo = new oppoa3("snapdragon 450", "3400", "white", "4GB");
            Console.WriteLine("Hp Oppo A3");
            Console.WriteLine("spesifikasi Hp {0}Spek,Batrai {1}, Color {2}, Ram {3}",
                Oppo.getSpek(),
                Oppo.getBatrai(),
                Oppo.getColor(),
                Oppo.getRam());

            Hp Poco = new pocox3pro("snapdragon 860", "5160", "black", "6GB");
            Console.WriteLine("Hp Poco X3 Pro");
            Console.WriteLine("spesifikasi  Hp {0}Spek,Batrai {1}, Color {2}, Ram {3}",
                Poco.getSpek(),
                Poco.getBatrai(),
                Poco.getColor(),
                Poco.getRam());

            Hp Vivo = new vivoy12("snapdragon 439", "5000", "blue", "3GB");
            Console.WriteLine("Hp Vivo Y12");
            Console.WriteLine("spesifikasi Hp {0}Spek,Batrai {1}, Color {2}, Ram {3}",
                Vivo.getSpek(),
                Vivo.getBatrai(),
                Vivo.getColor(),
                Vivo.getRam());
        }
    }
}