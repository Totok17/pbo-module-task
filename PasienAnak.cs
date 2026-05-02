using System;
using System.Collections.Generic;
using System.Text;

namespace TUGAS_PBO_PR
{
    internal class PasienAnak : Pasien
    {
        public PasienAnak(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }

        public void Menangis() => Console.WriteLine($"{nama} menangis karena takut disuntik.");
        public override void Aktivitas() => Console.WriteLine($"{nama} sedang bermain di ruang tunggu anak.");
    }
}
