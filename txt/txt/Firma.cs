using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace txt
{
   public  class Firma
    {
        public Siparis siparisler { get; set; }
        public int YetkiliId { get; set; }
       public List<Urun> UListe { get; set; }
        public void FUrunEkleme(Urun urun)
        {
            UListe.Add(urun);
        }
        public void FUrunCikar(int sayisi)
        {
            for (int i = 0; i < UListe.Count; i++)
            {
                if(sayisi==UListe[i].UrunKodu)
                UListe.Remove(UListe[i]);
            }
        }

        public void UrunGuncelle(int sayisi,string ad,int miktar ,string aciklama,int fiyat)
        {
            for(int i = 0; i < UListe.Count; i++)
            {
                if (sayisi == UListe[i].UrunKodu)
                {
                    UListe[i].Aciklama = aciklama;
                    UListe[i].UrunStokMiktari = miktar;
                    UListe[i].UrunAdi = ad;
                    UListe[i].UrunFiyat = fiyat;

                }
            }
        }
        public Firma()
        {
            StreamReader ItemsList = new StreamReader("UrunVeri.txt");
            this.UListe = new List<Urun>();
            Urun fUrun;
            string message = "";
            int a = 0;
            while((message=ItemsList.ReadLine())!= null)
            {
                string[] bilesen = message.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string Fdizi = bilesen[0] + "     " + bilesen[1] + "      " + bilesen[2] + "      \n";
                string[] Sira = Fdizi.Split("        ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string[] Fdizi2 = message.Split("  ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (Fdizi2[0] == Sira[0])
                {
                    fUrun = new Urun();
                    fUrun.UrunAdi = Fdizi[1].ToString();
                    fUrun.UrunKodu = Convert.ToInt32(Fdizi[0]);
                    fUrun.UrunFiyat = Convert.ToInt32(Fdizi[2]);
                    fUrun.KDV = Convert.ToInt32(Fdizi2[4]);
                    fUrun.KargoAgirliği = Convert.ToInt32(Fdizi2[5]);
                    fUrun.UrunStokMiktari = Convert.ToInt32(Fdizi[3]);
                    fUrun.Aciklama = "Ürün Adı: " + fUrun.UrunAdi + "Ürün Fiyatı: " + fUrun.UrunFiyat + "Ürün Ağırlığı: " + fUrun.KargoAgirliği;
                    UListe.Add(fUrun);
                }
                a++;
                if (a == 1)
                {
                    message = "";
                    a = 0;
                }
            }
        }

   }
}
