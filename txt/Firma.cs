using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

}
}
