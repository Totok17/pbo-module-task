using System;

namespace TUGAS_PBO_PR
{
    class Program
    {
        static void Main(string[] args)
        {
            RumahSakit rs = new RumahSakit();

            Dokter dokter1 = new Dokter("Dr. Jack Daniels", 35, "Ahli Saraf");
            PasienAnak anak1 = new PasienAnak("Ucup", 8, "Demam");
            Perawat perawat1 = new Perawat("Ses Yola", 25, "Gawat Darurat");
            PasienDewasa dewasa1 = new PasienDewasa("Bapak Andi", 45, "Sakit Gigi");

            rs.TambahOrang(dokter1);
            rs.TambahOrang(anak1);
            rs.TambahOrang(perawat1);
            rs.TambahOrang(dewasa1);

            rs.DaftarOrang();

            Console.WriteLine("--- Demonstrasi Khusus ---");

            Orang polyPerawat = perawat1;
            Console.Write("Polymorphism (Orang -> Perawat): ");
            polyPerawat.Aktivitas();

            dokter1.Diagnosa();
            anak1.Menangis();
            perawat1.CekPasien();

            Console.ReadLine();
        }
    }
}
