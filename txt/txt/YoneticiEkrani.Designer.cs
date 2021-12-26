
namespace txt
{
    partial class YoneticiEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiEkrani));
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.YoneticiListe = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAciklamaGuncelle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUrunEkle = new System.Windows.Forms.Button();
            this.textBoxAciklamaEkle = new System.Windows.Forms.TextBox();
            this.textBoxAgırlıkEkle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFiyatEkle = new System.Windows.Forms.TextBox();
            this.textBoxMiktarEkle = new System.Windows.Forms.TextBox();
            this.textBoxAdEkle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMiktarGuncelle = new System.Windows.Forms.TextBox();
            this.textBoxFiyatGuncelle = new System.Windows.Forms.TextBox();
            this.textBoxUrunAdiGuncelle = new System.Windows.Forms.TextBox();
            this.buttonUrunGüncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UrunCikarButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SiparisListButton = new System.Windows.Forms.Button();
            this.MüsteriListe = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(37, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 381);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.YoneticiListe);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.UrunCikarButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünler";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(244, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // YoneticiListe
            // 
            this.YoneticiListe.CheckBoxes = true;
            this.YoneticiListe.FullRowSelect = true;
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "listViewGroup1";
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "listViewGroup2";
            this.YoneticiListe.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            this.YoneticiListe.HideSelection = false;
            this.YoneticiListe.Location = new System.Drawing.Point(401, 12);
            this.YoneticiListe.Name = "YoneticiListe";
            this.YoneticiListe.Size = new System.Drawing.Size(771, 319);
            this.YoneticiListe.TabIndex = 11;
            this.YoneticiListe.UseCompatibleStateImageBehavior = false;
            this.YoneticiListe.View = System.Windows.Forms.View.Details;
            this.YoneticiListe.SelectedIndexChanged += new System.EventHandler(this.YoneticiListe_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.textBoxAciklamaGuncelle);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxMiktarGuncelle);
            this.groupBox1.Controls.Add(this.textBoxFiyatGuncelle);
            this.groupBox1.Controls.Add(this.textBoxUrunAdiGuncelle);
            this.groupBox1.Controls.Add(this.buttonUrunGüncelle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxAciklamaGuncelle
            // 
            this.textBoxAciklamaGuncelle.Location = new System.Drawing.Point(109, 90);
            this.textBoxAciklamaGuncelle.Name = "textBoxAciklamaGuncelle";
            this.textBoxAciklamaGuncelle.Size = new System.Drawing.Size(122, 22);
            this.textBoxAciklamaGuncelle.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUrunEkle);
            this.groupBox2.Controls.Add(this.textBoxAciklamaEkle);
            this.groupBox2.Controls.Add(this.textBoxAgırlıkEkle);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxFiyatEkle);
            this.groupBox2.Controls.Add(this.textBoxMiktarEkle);
            this.groupBox2.Controls.Add(this.textBoxAdEkle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 197);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // buttonUrunEkle
            // 
            this.buttonUrunEkle.Location = new System.Drawing.Point(40, 168);
            this.buttonUrunEkle.Name = "buttonUrunEkle";
            this.buttonUrunEkle.Size = new System.Drawing.Size(116, 23);
            this.buttonUrunEkle.TabIndex = 11;
            this.buttonUrunEkle.Text = "Ürün Ekle";
            this.buttonUrunEkle.UseVisualStyleBackColor = true;
            this.buttonUrunEkle.Click += new System.EventHandler(this.buttonUrunEkle_Click);
            // 
            // textBoxAciklamaEkle
            // 
            this.textBoxAciklamaEkle.Location = new System.Drawing.Point(101, 136);
            this.textBoxAciklamaEkle.Name = "textBoxAciklamaEkle";
            this.textBoxAciklamaEkle.Size = new System.Drawing.Size(122, 22);
            this.textBoxAciklamaEkle.TabIndex = 14;
            // 
            // textBoxAgırlıkEkle
            // 
            this.textBoxAgırlıkEkle.Location = new System.Drawing.Point(101, 106);
            this.textBoxAgırlıkEkle.Name = "textBoxAgırlıkEkle";
            this.textBoxAgırlıkEkle.Size = new System.Drawing.Size(122, 22);
            this.textBoxAgırlıkEkle.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ürün Açıklaması:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ürün Ağırlığı:";
            // 
            // textBoxFiyatEkle
            // 
            this.textBoxFiyatEkle.Location = new System.Drawing.Point(101, 75);
            this.textBoxFiyatEkle.Name = "textBoxFiyatEkle";
            this.textBoxFiyatEkle.Size = new System.Drawing.Size(122, 22);
            this.textBoxFiyatEkle.TabIndex = 10;
            // 
            // textBoxMiktarEkle
            // 
            this.textBoxMiktarEkle.Location = new System.Drawing.Point(100, 44);
            this.textBoxMiktarEkle.Name = "textBoxMiktarEkle";
            this.textBoxMiktarEkle.Size = new System.Drawing.Size(122, 22);
            this.textBoxMiktarEkle.TabIndex = 9;
            // 
            // textBoxAdEkle
            // 
            this.textBoxAdEkle.Location = new System.Drawing.Point(101, 15);
            this.textBoxAdEkle.Name = "textBoxAdEkle";
            this.textBoxAdEkle.Size = new System.Drawing.Size(122, 22);
            this.textBoxAdEkle.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ürün Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ürün Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Adı:";
            // 
            // textBoxMiktarGuncelle
            // 
            this.textBoxMiktarGuncelle.Location = new System.Drawing.Point(109, 62);
            this.textBoxMiktarGuncelle.Name = "textBoxMiktarGuncelle";
            this.textBoxMiktarGuncelle.Size = new System.Drawing.Size(122, 22);
            this.textBoxMiktarGuncelle.TabIndex = 9;
            // 
            // textBoxFiyatGuncelle
            // 
            this.textBoxFiyatGuncelle.Location = new System.Drawing.Point(110, 34);
            this.textBoxFiyatGuncelle.Name = "textBoxFiyatGuncelle";
            this.textBoxFiyatGuncelle.Size = new System.Drawing.Size(122, 22);
            this.textBoxFiyatGuncelle.TabIndex = 8;
            // 
            // textBoxUrunAdiGuncelle
            // 
            this.textBoxUrunAdiGuncelle.Location = new System.Drawing.Point(110, 6);
            this.textBoxUrunAdiGuncelle.Name = "textBoxUrunAdiGuncelle";
            this.textBoxUrunAdiGuncelle.Size = new System.Drawing.Size(122, 22);
            this.textBoxUrunAdiGuncelle.TabIndex = 7;
            // 
            // buttonUrunGüncelle
            // 
            this.buttonUrunGüncelle.Location = new System.Drawing.Point(37, 119);
            this.buttonUrunGüncelle.Name = "buttonUrunGüncelle";
            this.buttonUrunGüncelle.Size = new System.Drawing.Size(140, 24);
            this.buttonUrunGüncelle.TabIndex = 6;
            this.buttonUrunGüncelle.Text = "Ürün Güncelle";
            this.buttonUrunGüncelle.UseVisualStyleBackColor = true;
            this.buttonUrunGüncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // UrunCikarButton
            // 
            this.UrunCikarButton.Location = new System.Drawing.Point(255, 291);
            this.UrunCikarButton.Name = "UrunCikarButton";
            this.UrunCikarButton.Size = new System.Drawing.Size(140, 53);
            this.UrunCikarButton.TabIndex = 6;
            this.UrunCikarButton.Text = "Ürün Çıkar";
            this.UrunCikarButton.UseVisualStyleBackColor = true;
            this.UrunCikarButton.Click += new System.EventHandler(this.UrunCikarButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.SiparisListButton);
            this.tabPage2.Controls.Add(this.MüsteriListe);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteri";
            // 
            // SiparisListButton
            // 
            this.SiparisListButton.Location = new System.Drawing.Point(156, 278);
            this.SiparisListButton.Name = "SiparisListButton";
            this.SiparisListButton.Size = new System.Drawing.Size(225, 47);
            this.SiparisListButton.TabIndex = 1;
            this.SiparisListButton.Text = "Siparisleri Listele";
            this.SiparisListButton.UseVisualStyleBackColor = true;
            this.SiparisListButton.Click += new System.EventHandler(this.SiparisListButton_Click);
            // 
            // MüsteriListe
            // 
            this.MüsteriListe.HideSelection = false;
            this.MüsteriListe.Location = new System.Drawing.Point(431, 20);
            this.MüsteriListe.Name = "MüsteriListe";
            this.MüsteriListe.Size = new System.Drawing.Size(677, 317);
            this.MüsteriListe.TabIndex = 0;
            this.MüsteriListe.UseCompatibleStateImageBehavior = false;
            this.MüsteriListe.SelectedIndexChanged += new System.EventHandler(this.MüsteriListe_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palace Script MT", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(36, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 77);
            this.label10.TabIndex = 2;
            this.label10.Text = "Techno Box";
            // 
            // YoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1225, 484);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "YoneticiEkrani";
            this.Load += new System.EventHandler(this.YoneticiEkrani_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxFiyatEkle;
        private System.Windows.Forms.TextBox textBoxMiktarEkle;
        private System.Windows.Forms.TextBox textBoxAdEkle;
        private System.Windows.Forms.TextBox textBoxAciklamaGuncelle;
        private System.Windows.Forms.TextBox textBoxMiktarGuncelle;
        private System.Windows.Forms.TextBox textBoxFiyatGuncelle;
        private System.Windows.Forms.TextBox textBoxUrunAdiGuncelle;
        private System.Windows.Forms.Button buttonUrunGüncelle;
        private System.Windows.Forms.ListView YoneticiListe;
        private System.Windows.Forms.Button buttonUrunEkle;
        private System.Windows.Forms.TextBox textBoxAciklamaEkle;
        private System.Windows.Forms.TextBox textBoxAgırlıkEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SiparisListButton;
        private System.Windows.Forms.ListView MüsteriListe;
        private System.Windows.Forms.Button UrunCikarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
    }
}