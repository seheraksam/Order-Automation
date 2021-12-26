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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }
        
        public Sepet sepet;
        public static Urun uurun = new Urun();
        public static Firma firma;
        public static List<Urun> SepettekiUrunler = new List<Urun>();

        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            foreach (Urun urun in YoneticiEkrani.firma.UListe)
            {
                listBox1.Items.Add(urun);
            }
            if (listBox1.SelectedItem == null)
            {
                button1.Enabled = false;
                comboBox1.Enabled = false;
            }
            comboBox1.SelectionStart = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            MessageBox.Show("Adet Seçilmesi Zorunludur");
            else
            {
               
                Urun urun = (Urun)listBox1.SelectedItem;
                
                urun.SecilenUrunSayisi = int.Parse(comboBox1.Text);
                SepettekiUrunler.Add(urun);
                sepet = new Sepet(SepettekiUrunler);
                sepet.Show();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= uurun.UrunStokMiktari; i++)
            {

                comboBox1.Items.Add(i);



            }
            
            

            
            uurun.KDV = (uurun.UrunFiyat/100)*20;
            Urun urun = (Urun)listBox1.SelectedItem;
            urun.SecilenUrunSayisi = int.Parse(comboBox1.SelectedItem.ToString());
            FytLbl.Text = urun.UrunFiyat.ToString();
            KdvLbl.Text = urun.KDV.ToString();
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                button1.Enabled = false;
            
            else
            {
                button1.Enabled = true;
                comboBox1.Enabled = true;
                foreach (Urun urun in YoneticiEkrani.firma.UListe)
                {
                    Urun urunn = (Urun)listBox1.SelectedItem;
                    if (urunn.UrunAdi == urunn.UrunAdi)
                    {
                        comboBox1.Items.Clear();
                        string[] temp = new string[urun.UrunStokMiktari];
                        int a = 0;
                        for (int i = 0; i <=urun.UrunStokMiktari; i++)
                        {
                            temp[a] = i.ToString();
                            i++;
                        }
                        comboBox1.Items.AddRange(temp);
                    }
                }
                

                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
