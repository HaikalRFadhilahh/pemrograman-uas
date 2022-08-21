using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericClass
{
    public class Mahasiswa
    {
        public string Nama;
        public string NIM;
        public string Kelas;

        public Mahasiswa (string name,string nim,string kelas)
        {
            this.Nama = name;
            this.NIM = nim;
            this.Kelas = kelas;
        }


    }
}