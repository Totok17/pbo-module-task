using System;
using System.Collections.Generic;
using System.Text;

namespace TUGAS_PBO_PR
{
    internal class TenagaMedis : Orang
    {
        public string spesialisasi { get; set; }

        public TenagaMedis(string nama, int umur, string spesialisasi) : base(nama, umur)
        {
            this.spesialisasi = spesialisasi;
        }

        public void CekSpesialis() => Console.WriteLine($"Spesialisasi: {spesialisasi}");

        public override void Aktivitas() => Console.WriteLine($"{nama} sedang bersiap melayani.");
    }
}
