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
    public partial class YoneticiEkrani : Form
    {

        public static Firma firma = new Firma();
        public Urun YeniUrun { get; set; }
        public string Kayit { get; set; }
        public YoneticiEkrani()
        {
            InitializeComponent();
        }
        public void ListTemizleYönetici()
        {
            
            YoneticiListe.Clear();
            YoneticiListe.Columns.Add("Ürün : ", 50);
            YoneticiListe.Columns.Add("Fiyatı : ", 50);
            YoneticiListe.Columns.Add("Adet : ", 50);
            YoneticiListe.Columns.Add("Ağırlık : ", 100);
            YoneticiListe.Columns.Add("Urun Kodu : ", 70);
            YoneticiListe.Columns.Add("Açıklama : ", 200);
           
           
            for (int i = 0; i < firma.UListe.Count; i++)
            {
                YoneticiListe.Items.Add(firma.UListe[i].UrunAdi.ToString());
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].UrunFiyat.ToString());
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].UrunStokMiktari.ToString());
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].KargoAgirliği.ToString());
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].UrunKodu.ToString());
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].Aciklama);
               
            }
        }


        private void firmaYetkilisiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void YoneticiEkrani_Load(object sender, EventArgs e)
        {
             
            YoneticiListe.Columns.Add("Ürün : ", 50);
            YoneticiListe.Columns.Add("Fiyatı : ", 50);
            YoneticiListe.Columns.Add("Adet : ", 50);
            YoneticiListe.Columns.Add("Ağırlık : ", 100);
            YoneticiListe.Columns.Add("Urun Kodu : ", 70);
            YoneticiListe.Columns.Add("Açıklama : ", 200);
           
            for (int i = 0; i < firma.UListe.Count; i++)
            {
                YoneticiListe.Items.Add(firma.UListe[i].UrunAdi);
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].UrunFiyat.ToString());
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].UrunStokMiktari.ToString());
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].KargoAgirliği.ToString());
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].UrunKodu.ToString());
                YoneticiListe.Items[i].SubItems.Add(firma.UListe[i].Aciklama); 
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUrunAdiGuncelle.Text == "" || textBoxFiyatGuncelle.Text == "" || textBoxMiktarGuncelle.Text == "" || textBoxAciklamaGuncelle.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
            }
            else
            {
                if (YoneticiListe.SelectedItems.Count == 1)
                {
                    firma.UrunGuncelle(int.Parse(YoneticiListe.SelectedItems[0].SubItems[4].Text), textBoxUrunAdiGuncelle.Text, int.Parse(textBoxMiktarGuncelle.Text), textBoxAciklamaGuncelle.Text, int.Parse(textBoxFiyatGuncelle.Text));
                }
                ListTemizleYönetici();
            }
        }

        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {
            if (textBoxAdEkle.Text == "" || textBoxMiktarEkle.Text == "" || textBoxFiyatEkle.Text == "" || textBoxAciklamaEkle.Text == "" || textBoxAgırlıkEkle.Text == "")
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
            }
            else
            {
                YeniUrun = new Urun();
                YeniUrun.Aciklama = textBoxAciklamaEkle.Text;
                YeniUrun.UrunFiyat = int.Parse(textBoxFiyatEkle.Text);
                YeniUrun.UrunKodu = firma.UListe.Count + 1;
                YeniUrun.UrunAdi = textBoxAdEkle.Text;
                YeniUrun.UrunStokMiktari = Convert.ToInt32(textBoxMiktarEkle.Text);
                YeniUrun.KargoAgirliği = int.Parse(textBoxAgırlıkEkle.Text);

                firma.FUrunEkleme(YeniUrun);
                ListTemizleYönetici();



            }

        }

        private void SiparisListButton_Click(object sender, EventArgs e)
        {
            MüsteriListe.View = View.Details;
            MüsteriListe.Columns.Add("Müşteri Rumuz : ", 50);
            MüsteriListe.Columns.Add("Isim : ", 252);
            MüsteriListe.Columns.Add("Müşteri Adres : ", 252);
           
            MüsteriListe.Columns.Add("Ürün Adı : ", 100);
            MüsteriListe.Columns.Add("Ürün Miktarı : ", 150);
            MüsteriListe.Columns.Add("Ürün Fiyatı : ", 100);
            
            MüsteriListe.Columns.Add("Urun Kodu : ", 50);
            MüsteriListe.Columns.Add("Sipariş Verilen Tarih : ");
          


             try
             {
                 
                 if(Sepet.siparis.Detay.Count==0)
                     MessageBox.Show("Siparis Yok");
                 else
                 {
                   for(int i =0 ; i<Sepet.siparis.Detay.Count;i++){
                        MüsteriListe.Items.Add(Sepet.siparis.Musteriler.MüsteriID.ToString());
                        MüsteriListe.Items.Add(Sepet.siparis.Musteriler.Adres.ToString());
                      
                        MüsteriListe.Items[i].SubItems.Add(Sepet.siparis.Detay[i].urunn.UrunAdi);
                        MüsteriListe.Items[i].SubItems.Add(Sepet.siparis.Detay[i].urunn.UrunKodu.ToString());
                    
                        MüsteriListe.Items[i].SubItems.Add(Sepet.siparis.Detay[i].urunn.UrunFiyat.ToString());
                       
                        MüsteriListe.Items[i].SubItems.Add(Sepet.siparis.Detay[i].urunn.SecilenUrunSayisi.ToString());
                        MüsteriListe.Items[i].SubItems.Add(Sepet.siparis.SiparisTarih.ToString());


                    }    
                 }
             }
            catch(Exception){
            MessageBox.Show("Siparis Tanımlandı");

                } 
            }
            







        

        private void UrunCikarButton_Click(object sender, EventArgs e)
        {
            if (YoneticiListe.CheckedItems.Count > 0)
            {
                for(int i = 0;i<YoneticiListe.CheckedItems.Count;i++ )
                {
                    int m = int.Parse(YoneticiListe.CheckedItems[i].SubItems[4].Text);

                        firma.FUrunCikar(m);
                    MessageBox.Show("Isleme Devam Ediniz Ürün Çıkarılacaktır...");
                }
            }
            
        }

        private void YoneticiListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YoneticiListe.SelectedItems.Count == 1)
            {
                textBoxUrunAdiGuncelle.Text = YoneticiListe.SelectedItems[0].SubItems[0].Text;
                textBoxFiyatGuncelle.Text = YoneticiListe.SelectedItems[0].SubItems[1].Text;
                textBoxMiktarGuncelle.Text = YoneticiListe.SelectedItems[0].SubItems[2].Text;
                textBoxAciklamaGuncelle.Text = YoneticiListe.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void MüsteriListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
