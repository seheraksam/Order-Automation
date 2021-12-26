using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txt
{
    public partial class Sepet : Form
    {
        public Firma firma { get; set; }
        public List<Urun> SepetListesi = new List<Urun>();
        public Musteri musteri { get; set; }
        public static SiparisDetayi siparisD { get; set; }
        public static Siparis siparis { get; set; }
        public int Toplam { get; set; }
         public Sepet(List<Urun> u)
        {
            InitializeComponent();
            this.SepetListesi = u;
            musteri = new Musteri();
            siparis = new Siparis(this.musteri);
            siparis.Detay = new List<SiparisDetayi>();
            

        }


        public Sepet()
        {
            InitializeComponent();
        }

        private void Sepet_Load(object sender, EventArgs e)
        {
            foreach (Urun a in SepetListesi)
            {
                listBoxSepet.Items.Add(a.UrunAdi + "       " + a.UrunFiyat + "        " + a.SecilenUrunSayisi.ToString());
                Toplam += (a.UrunFiyat * a.SecilenUrunSayisi*a.KDV);
            }
            label5.Text = (Toplam.ToString());
            
            

            
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            MusteriEkrani menu = new MusteriEkrani();
            menu.Show();

           
        }

        private void buttonOdeme_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SepetListesi.Count; i++)
            {
                siparisD = new SiparisDetayi();
                siparisD.urunn.UrunAdi = SepetListesi[i].UrunAdi;
                siparisD.urunn.UrunFiyat = SepetListesi[i].UrunFiyat;
                siparisD.urunn.KDV = SepetListesi[i].KDV;
                siparisD.urunn.SecilenUrunSayisi = SepetListesi[i].SecilenUrunSayisi;

                siparisD.urunn.UrunKodu = SepetListesi[i].UrunKodu;
                siparisD.urunn.KargoAgirliği = SepetListesi[i].KargoAgirliği;
                siparisD.urunn.Aciklama = SepetListesi[i].Aciklama;
                siparis.SiparisTarih = DateTime.Now;
                siparis.SiparisDetayiEkle(siparisD);


            }
            double toplam = siparis.ToplamFiyatHesapla();
            double agirlik = siparis.ToplamAgirlikHesapla();
            double vergi = siparis.VergiHesapla();
            MessageBox.Show("Topam Tutar : "+toplam/2);
            MessageBox.Show("Topam Ağırlık : " + agirlik);
            MessageBox.Show("Topam Vergi : " + vergi);
            OdemeForm odemeForm = new OdemeForm(siparis.ToplamFiyatHesapla());
            odemeForm.Show();
        }

        private void buttonSepetClear_Click(object sender, EventArgs e)
        {
            SepetListesi.Clear();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
