using System;
using System.Collections.Generic;
using System.Text;

namespace TUGAS_PBO_PR
{
    internal class Dokter : TenagaMedis
    {
        public Dokter(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi) { }

        public void Diagnosa() => Console.WriteLine($"{nama} sedang mendiagnosa penyakit pasien.");
        public override void Aktivitas() => Console.WriteLine($"{nama} sedang melakukan operasi/pemeriksaan.");
    }
}
