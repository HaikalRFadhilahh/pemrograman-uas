using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericClass
{
    class Program
    {
        static void Main(String[] args)
        {
            Mahasiswa agung = new Mahasiswa("Agung Satria","21.11.3958","Informatika 02");
            Dosen Ferian = new Dosen("Pak Ferian","Magister Komunikasi","Sistem Operasi");

            Identitas<Mahasiswa> mahasiswa1 = new Identitas<Mahasiswa>(agung);
            Identitas<Dosen> dosen1 = new Identitas<Dosen>(Ferian);

            Console.WriteLine("Mahasiswa Pertama,Nama : {0} ; NIM : {1} ; Kelas : {2}",mahasiswa1.value.Nama,mahasiswa1.value.NIM,mahasiswa1.value.Kelas);
            Console.WriteLine("Dosen Pertama,Nama : {0} ; Jabatan : {1} ; MataKuliah : {2} ;",dosen1.value.Nama,dosen1.value.Jabatan,dosen1.value.Matakuliah);
        }
    }
}