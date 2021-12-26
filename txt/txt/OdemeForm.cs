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
    public partial class OdemeForm : Form
    {
        KrediKarti Kart = new KrediKarti();
        Nakit nakit = new Nakit();
        Cek cek = new Cek();
        public int Onaylama = 0;
        public double  Tutar { get; set; }

        public OdemeForm()
        {
            InitializeComponent();
        }
        public OdemeForm(double tutar)
        {
            InitializeComponent();
            this.Tutar = tutar;
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            labelToplamTutar.Text = Convert.ToString(Tutar/2);
        }

        private void buttonOnay_Click(object sender, EventArgs e)
        {
            if (comboBoxOdemeYont.Text == ""){

                MessageBox.Show("Lütfen Bir Ödeme Yöntemi Seçiniz");
            }
            else
            {
                if (comboBoxOdemeYont.Text == "KrediKartı")
                {
                    if (textBoxKart.Text == "" || textBoxType.Text == "" || dateTimePicker1.Text == "")
                    {
                        MessageBox.Show("Boş Alanları Doldurmalısınız");
                    }
                    else
                    {
                        Kart.KartNo = Convert.ToDecimal(textBoxKart.Text);
                        Kart.Tip = textBoxType.Text;
                        Kart.KartSKT = Convert.ToDateTime(dateTimePicker1.Text);
                        Onaylama = Kart.Yetki();
                        if (Onaylama == 1)
                        {
                            Kart.OdenecekTutar(Tutar);
                            MessageBox.Show("Ödemeniz Alınmıştır İyi Günler Dileriz");
                            this.Close();
                        }

                    }
                }
                else if (comboBoxOdemeYont.Text == "Nakit")
                {
                    Onaylama = cek.Yetki();
                    if (Onaylama == 1)
                    {
                        nakit.OdenecekTutar(Tutar);
                        labelNakit.Text =(Tutar/2).ToString();
                        MessageBox.Show("Ödemeniz Alınmıştır İyi Günler Dileriz");
                        this.Close();

                    }

                }
                else if (comboBoxOdemeYont.Text == "Cek")
                {
                    if (textBoxCekKart.Text == "" || textBoxCekisim.Text == "")
                    {
                        MessageBox.Show("Boş Alanları Doldurunuz");
                    }
                    else
                    {
                        cek.Adi = textBoxCekisim.Text;
                        cek.BankId = Convert.ToInt32(textBoxCekKart.Text);
                        Onaylama = cek.Yetki();
                        if (Onaylama == 1)
                        {
                            cek.OdenecekTutar(Tutar);
                            MessageBox.Show("Ödemeniz Alınmıştır İyi Günler Dileriz");
                            this.Close();
                        }

                    }
                }
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelToplamTutar_Click(object sender, EventArgs e)
        {

        }

        private void labelNakit_Click(object sender, EventArgs e)
        {

        }
    }
}
