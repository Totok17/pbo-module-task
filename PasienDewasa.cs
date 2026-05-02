using System;
using System.Collections.Generic;
using System.Text;

namespace TUGAS_PBO_PR
{
    internal class PasienDewasa : Pasien
    {
        public PasienDewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }

        public void Konsultasi() => Console.WriteLine($"{nama} sedang berkonsultasi mengenai gaya hidup sehat.");
    }
}
