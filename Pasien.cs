using System;
using System.Collections.Generic;
using System.Text;

namespace TUGAS_PBO_PR
{
    internal class Pasien : Orang
    {
        public string keluhan { get; set; }

        public Pasien(string nama, int umur, string keluhan) : base(nama, umur)
        {
            this.keluhan = keluhan;
        }

        public void CekKeluhan() => Console.WriteLine($"Keluhan: {keluhan}");

        public override void Aktivitas() => Console.WriteLine($"{nama} sedang menunggu antrean berobat.");
    }
}
