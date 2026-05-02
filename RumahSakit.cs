using System;
using System.Collections.Generic;
using System.Text;

namespace TUGAS_PBO_PR
{
    internal class RumahSakit
    {
        private List<Orang> daftarOrang = new List<Orang>(); //

        public void TambahOrang(Orang orang) => daftarOrang.Add(orang); //

        public void DaftarOrang() //
        {
            Console.WriteLine("--- Daftar Orang di Rumah Sakit ---");
            foreach (var o in daftarOrang)
            {
                o.InfoOrang();
                o.Aktivitas();
                Console.WriteLine();
            }
        }
    }
}
