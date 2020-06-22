using System;
using TugasLab8.ClassInduk;
using TugasLab8.ClassAnak;
using System.Collections.Generic;

namespace TugasLab8
{
    class Program 
    {
        static void Main(string[] args)
        {
          

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "123-234-345";
            karyawanTetap.Nama = "Michael Suyana";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "123-333-347";
            karyawanHarian.Nama = "Laura Cellahan";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 13000;

            Sales sales = new Sales();
            sales.NIK = "123-333-347";
            sales.Nama = "Andrew Fuller";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}, NIK: {1}, Nama: {2}, Gaji: {3:N0}",
                    noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
