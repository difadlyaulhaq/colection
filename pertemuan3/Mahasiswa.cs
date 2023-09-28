using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan3
{
    class Mahasiswa
    {
        public String Nim;
        public String Nama;
        public String Kelas;
        public int Nilai;
        public String Nilai_h;
    
        public void Nilaihuruf()
        {
            if (Nilai>=0 && Nilai<=20)
            {
                Nilai_h = "E";
            }else if (Nilai<=40)
            {
                Nilai_h= "D";
            }else if (Nilai<=60)
            {
                Nilai_h = "C";
            }else if (Nilai<=80)
            {
                Nilai_h = "B";
            }else if (Nilai<=100)
            {
                
            }
        }
    }
}
