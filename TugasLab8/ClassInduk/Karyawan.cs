using System;
using System.Collections.Generic;
using System.Text;

namespace TugasLab8.ClassInduk
{
    public abstract class Karyawan
    {
        public abstract double Gaji();
        public string NIK { get; set; }
        public string Nama { get; set; }
    }
}
