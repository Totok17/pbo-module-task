using System;
using System.Collections.Generic;
using System.Text;

namespace TUGAS_PBO_PR
{
    internal class Perawat : TenagaMedis
    {
        public Perawat(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi) { }

        public void CekPasien() => Console.WriteLine($"{nama} sedang mengecek kondisi vital pasien.");
        public override void Aktivitas() => Console.WriteLine($"{nama} sedang memberikan obat kepada pasien.");
    }
}
