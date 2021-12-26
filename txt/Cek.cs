using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txt
{
    public class Cek:Odeme
    {
        public string Adi { get; set; }
        public int BankId { get; set; }
        int Yetkili;
        public int Yetki ()
        {
            Yetkili = 1;
            return Yetkili;
        }
        public override void OdenecekTutar(double tutar)
        {
            Miktar = tutar;
        }
    }
}
