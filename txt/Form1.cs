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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        string[] idSifre;

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;

            
            idSifre = System.IO.File.ReadAllLines(Application.StartupPath + "\\idpw.txt");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (textBox1.Text == idSifre[0] && textBox2.Text == idSifre[1])
                {

                    MessageBox.Show("Giriş Başarılı");
                    girisBasariliMusteri();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı Veya Şifre");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }

            }
            else if (radioButton1.Checked)
            {
                if (textBox1.Text == idSifre[2] && textBox2.Text == idSifre[3])
                {

                    MessageBox.Show("Giriş Başarılı");
                    girisBasariliPersonel();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı Veya Şifre");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
          
        }
        public void girisBasariliPersonel()
        {
            
            YoneticiEkrani yonetici = new YoneticiEkrani();
            yonetici.Show();

        }
        public void girisBasariliMusteri()
        {
           MusteriEkrani musteri = new MusteriEkrani();
            musteri.Show();
        }
    }
}
