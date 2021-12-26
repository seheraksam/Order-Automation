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

    public partial class MusteriEkrani : Form
    {
        UrunlerForm urunler;
        Sepet sepet; 
        OdemeForm odeme;
       
       


        public MusteriEkrani()
        {
            InitializeComponent();
            
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urunler == null)
            {
                urunler = new UrunlerForm();
                urunler.FormClosed += ürünler_FormClosed;
                urunler.Show();


            }
            else
            {
                urunler.Activate();
            }
        }
        private void ürünler_FormClosed(object sender, FormClosedEventArgs e)
        {
            urunler = null;
        }
        private void sepetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sepet == null)
            {
                sepet = new Sepet(UrunlerForm.SepettekiUrunler);

                sepet.FormClosed+= sepet_FormClosed;
                sepet.Show();

            }
            else
            {
                sepet.Activate();
            }
        }
        private void sepet_FormClosed(object sender, FormClosedEventArgs e)
        {
           sepet = null;
        }

        private void MusteriEkrani_Load(object sender, EventArgs e)
        {

        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (odeme == null)
            {
                odeme = new OdemeForm();
          
                odeme.FormClosed += odeme_FormClosed;

                odeme.Show();


                
            }
            else
            {
                odeme.Activate();
            }
        }

        private void odeme_FormClosed(object sender, FormClosedEventArgs e)//araştır nsaıl açılıyor
        {
            odeme = null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
