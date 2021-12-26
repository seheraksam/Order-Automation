using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txt
{
    public class Urun
    {
        //Urun kodunu kullanmadık ona göre yaz
        public int UrunKodu { get; set; }
        public int KargoAgirliği { get; set; }
        public string Aciklama { get; set; }
        public int SecilenUrunSayisi { get; set; }
        public int UrunStokMiktari { get; set; }
        public double KDV { get; set; }
        public double UrunFiyat { get; set; }
        public string UrunAdi { get; set; }
        public override string ToString()
        {
            return string.Format("{0}\t\t{1}TL\t\t{2} ", UrunAdi, UrunFiyat, UrunStokMiktari);
        }
        public double MiktarFiyatAl(int miktar)
        {
            return miktar * UrunFiyat;//Miktarı kullanıcıya Girdir
        }
        public double AğirlikAl()
        {
            return SecilenUrunSayisi * KargoAgirliği;
        }
    }
}
