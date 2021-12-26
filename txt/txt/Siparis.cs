using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txt
{
    public class Siparis
    {
        public Urun urun { get; set; }
        public Musteri Musteriler { get; set; }
        public DateTime SiparisTarih { get; set; }
        public string Durum { get; set; }
        public List<SiparisDetayi> Detay { get; set; }
        
        public Siparis(Musteri m)
        {
            this.Musteriler = m;

        }
        public void SiparisDetayiEkle(SiparisDetayi s)
        {
            Detay.Add(s);

        }
        public void SiparisDetayiCikar(SiparisDetayi s)
        {
            Detay.Remove(s);

        }
        public string SiparisListele()
        {

            string bilgi = "";
            foreach (SiparisDetayi s in Detay)
            {
                bilgi += Musteriler.Isim + "\n " + Musteriler.Adres + "\n " + urun.SecilenUrunSayisi + "\n" + urun.UrunFiyat + " ";
            }
            return bilgi;

        }

       public double VergiHesapla()
        {

            double Vergi = 0;
            foreach (SiparisDetayi s in Detay)
            {
                Vergi += s.ToplamVergiHesapla();
                

            }
            return Vergi;
        }
        public double ToplamFiyatHesapla()
        {
            double ToplamFiyat = 0;
            foreach (SiparisDetayi s in Detay)
            {
                ToplamFiyat += s.ToplamParaHesapla();
            }
           
            return ToplamFiyat;

        }
        public double ToplamAgirlikHesapla()
        {

            double toplamAgırlık = 0;
            foreach (SiparisDetayi s in Detay)
            {
                toplamAgırlık += s.ToplamAğırlıkHesapla();
            }
            return toplamAgırlık;
        }
    }
}
