using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txt
{
   public  class Nakit:Odeme
    {
        public double VerilecekTutar { get; set; }
        int Yetkili;
        public int Yetki()
        {
            Yetkili = 1;
            return Yetkili;
        }
        public override void OdenecekTutar(double tutar)
        {
            // base.OdenecekTutar(double tutar);
            Miktar = tutar;

        }
    }
}
