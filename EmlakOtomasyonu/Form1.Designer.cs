﻿namespace EmlakOtomasyonu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_İl = new System.Windows.Forms.ComboBox();
            this.cbSemt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSatilik = new System.Windows.Forms.RadioButton();
            this.rbKiralik = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.txtOdaSayisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKatNumarasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEvTur = new System.Windows.Forms.ComboBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDepozito = new System.Windows.Forms.TextBox();
            this.yapim = new System.Windows.Forms.DateTimePicker();
            this.tahmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(168, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl :";
            // 
            // cb_İl
            // 
            this.cb_İl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cb_İl.FormattingEnabled = true;
            this.cb_İl.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa ",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cb_İl.Location = new System.Drawing.Point(233, 36);
            this.cb_İl.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cb_İl.Name = "cb_İl";
            this.cb_İl.Size = new System.Drawing.Size(181, 38);
            this.cb_İl.TabIndex = 0;
            this.cb_İl.SelectedValueChanged += new System.EventHandler(this.cb_İl_SelectedValueChanged);
            // 
            // cbSemt
            // 
            this.cbSemt.Enabled = false;
            this.cbSemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbSemt.FormattingEnabled = true;
            this.cbSemt.Location = new System.Drawing.Point(233, 86);
            this.cbSemt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbSemt.Name = "cbSemt";
            this.cbSemt.Size = new System.Drawing.Size(181, 38);
            this.cbSemt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(117, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semt :";
            // 
            // rbSatilik
            // 
            this.rbSatilik.AutoSize = true;
            this.rbSatilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbSatilik.Location = new System.Drawing.Point(206, 133);
            this.rbSatilik.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbSatilik.Name = "rbSatilik";
            this.rbSatilik.Size = new System.Drawing.Size(115, 35);
            this.rbSatilik.TabIndex = 2;
            this.rbSatilik.TabStop = true;
            this.rbSatilik.Text = "Satılık";
            this.rbSatilik.UseVisualStyleBackColor = true;
            this.rbSatilik.CheckedChanged += new System.EventHandler(this.rbSatilik_CheckedChanged);
            // 
            // rbKiralik
            // 
            this.rbKiralik.AutoSize = true;
            this.rbKiralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbKiralik.Location = new System.Drawing.Point(351, 129);
            this.rbKiralik.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbKiralik.Name = "rbKiralik";
            this.rbKiralik.Size = new System.Drawing.Size(116, 35);
            this.rbKiralik.TabIndex = 3;
            this.rbKiralik.TabStop = true;
            this.rbKiralik.Text = "Kiralık";
            this.rbKiralik.UseVisualStyleBackColor = true;
            this.rbKiralik.CheckedChanged += new System.EventHandler(this.rbKiralik_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(67, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alan(m2) :";
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(233, 168);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(181, 37);
            this.txtAlan.TabIndex = 4;
            this.txtAlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(233, 225);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(181, 37);
            this.txtOdaSayisi.TabIndex = 5;
            this.txtOdaSayisi.TextChanged += new System.EventHandler(this.cbEvTur_SelectedValueChanged);
            this.txtOdaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(43, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oda Sayısı :";
            // 
            // txtKatNumarasi
            // 
            this.txtKatNumarasi.Location = new System.Drawing.Point(233, 276);
            this.txtKatNumarasi.Name = "txtKatNumarasi";
            this.txtKatNumarasi.Size = new System.Drawing.Size(181, 37);
            this.txtKatNumarasi.TabIndex = 6;
            this.txtKatNumarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Location = new System.Drawing.Point(8, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kat Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(21, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yapım Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Location = new System.Drawing.Point(60, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Evin Türü :";
            // 
            // cbEvTur
            // 
            this.cbEvTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbEvTur.FormattingEnabled = true;
            this.cbEvTur.Items.AddRange(new object[] {
            "Daire",
            "Bahçeli",
            "Dubleks",
            "Mustakil"});
            this.cbEvTur.Location = new System.Drawing.Point(233, 370);
            this.cbEvTur.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbEvTur.Name = "cbEvTur";
            this.cbEvTur.Size = new System.Drawing.Size(181, 38);
            this.cbEvTur.TabIndex = 8;
            this.cbEvTur.SelectedValueChanged += new System.EventHandler(this.cbEvTur_SelectedValueChanged);
            // 
            // btnGonder
            // 
            this.btnGonder.AutoSize = true;
            this.btnGonder.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGonder.Location = new System.Drawing.Point(233, 425);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(115, 41);
            this.btnGonder.TabIndex = 11;
            this.btnGonder.Text = "Kaydet";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(577, 222);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(184, 37);
            this.txtKira.TabIndex = 10;
            this.txtKira.Visible = false;
            this.txtKira.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Location = new System.Drawing.Point(452, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kirası :";
            this.label8.Visible = false;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(577, 171);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(184, 37);
            this.txtFiyat.TabIndex = 9;
            this.txtFiyat.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(454, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fiyatı :";
            this.label9.Visible = false;
            // 
            // txtDepozito
            // 
            this.txtDepozito.Location = new System.Drawing.Point(577, 171);
            this.txtDepozito.Name = "txtDepozito";
            this.txtDepozito.Size = new System.Drawing.Size(184, 37);
            this.txtDepozito.TabIndex = 9;
            this.txtDepozito.Visible = false;
            this.txtDepozito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdaSayisi_KeyPress);
            // 
            // yapim
            // 
            this.yapim.Location = new System.Drawing.Point(233, 325);
            this.yapim.MaxDate = new System.DateTime(2024, 10, 10, 0, 0, 0, 0);
            this.yapim.Name = "yapim";
            this.yapim.Size = new System.Drawing.Size(369, 37);
            this.yapim.TabIndex = 7;
            this.yapim.Value = new System.DateTime(2024, 10, 10, 0, 0, 0, 0);
            // 
            // tahmin
            // 
            this.tahmin.AutoSize = true;
            this.tahmin.Location = new System.Drawing.Point(435, 63);
            this.tahmin.Name = "tahmin";
            this.tahmin.Size = new System.Drawing.Size(0, 31);
            this.tahmin.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 477);
            this.Controls.Add(this.tahmin);
            this.Controls.Add(this.yapim);
            this.Controls.Add(this.txtDepozito);
            this.Controls.Add(this.txtKira);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.cbEvTur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKatNumarasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOdaSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbKiralik);
            this.Controls.Add(this.rbSatilik);
            this.Controls.Add(this.cbSemt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_İl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Yeni Kayıt Ekleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGonder;
        public System.Windows.Forms.ComboBox cb_İl;
        public System.Windows.Forms.RadioButton rbSatilik;
        public System.Windows.Forms.RadioButton rbKiralik;
        public System.Windows.Forms.TextBox txtKira;
        public System.Windows.Forms.TextBox txtFiyat;
        public System.Windows.Forms.TextBox txtDepozito;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbSemt;
        public System.Windows.Forms.TextBox txtAlan;
        public System.Windows.Forms.TextBox txtOdaSayisi;
        public System.Windows.Forms.TextBox txtKatNumarasi;
        public System.Windows.Forms.ComboBox cbEvTur;
        private System.Windows.Forms.DateTimePicker yapim;
        private System.Windows.Forms.Label tahmin;
    }
}

