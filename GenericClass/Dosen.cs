using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericClass
{
    public class Dosen
    {
        public string Nama;
        public string Jabatan;
        public string Matakuliah;


        public Dosen(string Nama, string Jabatan,string Matakuliah)
        {
            this.Nama = Nama;
            this.Jabatan = Jabatan;
            this.Matakuliah = Matakuliah;
        }
    }
}