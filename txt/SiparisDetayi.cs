using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txt
{
    public class SiparisDetayi
    {
        public Urun urunn = new Urun();
        public int SiparisSayisi { get; set; }
        public double VergiDurumu  { get; set; }
        public double  VergiDahilTutar { get; set; }
        public double ToplamParaHesapla()
        {
            VergiDurumu = ((urunn.MiktarFiyatAl(urunn.SecilenUrunSayisi)) * urunn.KDV);
            VergiDahilTutar = (urunn.MiktarFiyatAl(urunn.SecilenUrunSayisi)+VergiDurumu);
            return VergiDahilTutar;
        }
        public double ToplamAğırlıkHesapla()
        {
            //Sıkıbtı Çıkarsa Bak
            return  urunn.AğirlikAl();
        }
    }
}
