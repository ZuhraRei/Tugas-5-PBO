using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class KaryawanGaji : Karyawan
    {
        private decimal gajiMingguan;
        public KaryawanGaji(string namaDepan, string namaBelakang, string nomorKTP, decimal gajiMingguan) : base(namaDepan, namaBelakang, nomorKTP)
        {
            GajiMingguan = gajiMingguan;
        }

        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiMingguan)} harus >= 0");
                }
                gajiMingguan = value;
            }
        }

        public override decimal Pendapatan() => GajiMingguan;
        public override string ToString() => $"karyawan bergaji: {base.ToString()}\n" + $"gaji mingguan: {GajiMingguan:C}";
    }

}
