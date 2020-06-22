using System;
using System.Collections.Generic;
using System.Text;
using TugasLab8.ClassInduk;

namespace TugasLab8.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {

        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }

        public override double Gaji() => UpahPerJam * JumlahJamKerja;
       
    }
}
