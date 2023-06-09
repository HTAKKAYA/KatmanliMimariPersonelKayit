namespace PersonelKayit.Forms
{
    partial class SirketYetkisliEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SirketYetkisliEkrani));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPersonelAra = new TextBox();
            txtPersonelAd = new TextBox();
            txtPersonelSoyad = new TextBox();
            btnPersonelEkleGuncelle = new Button();
            lviPersonel = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            mtbPersonelTelefon = new MaskedTextBox();
            txtPersonelAdres = new TextBox();
            txtPersonelEmail = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dtpDogumTarihi = new DateTimePicker();
            gbxCinsiyet = new GroupBox();
            rbnErkek = new RadioButton();
            rbnKadin = new RadioButton();
            mbxTcNo = new MaskedTextBox();
            btnSil = new Button();
            label12 = new Label();
            cbxDepartman = new ComboBox();
            gbxCinsiyet.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 0;
            label1.Text = "Personel Ara :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(25, 318);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 1;
            label2.Text = "Personel Ad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(25, 370);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 2;
            label3.Text = "Personel Soyad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(25, 425);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 3;
            label4.Text = "Personel TC No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(407, 318);
            label5.Name = "label5";
            label5.Size = new Size(199, 21);
            label5.TabIndex = 4;
            label5.Text = "Personel Doğum Tarihi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(407, 370);
            label6.Name = "label6";
            label6.Size = new Size(155, 21);
            label6.TabIndex = 5;
            label6.Text = "Personel Cinsiyet :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(407, 425);
            label7.Name = "label7";
            label7.Size = new Size(182, 21);
            label7.TabIndex = 6;
            label7.Text = "Perosnel Departman :";
            // 
            // txtPersonelAra
            // 
            txtPersonelAra.Location = new Point(143, 29);
            txtPersonelAra.Name = "txtPersonelAra";
            txtPersonelAra.Size = new Size(152, 23);
            txtPersonelAra.TabIndex = 7;
            txtPersonelAra.TextChanged += txtPersonelAra_TextChanged;
            // 
            // txtPersonelAd
            // 
            txtPersonelAd.Location = new Point(166, 320);
            txtPersonelAd.Name = "txtPersonelAd";
            txtPersonelAd.Size = new Size(230, 23);
            txtPersonelAd.TabIndex = 0;
            // 
            // txtPersonelSoyad
            // 
            txtPersonelSoyad.Location = new Point(166, 372);
            txtPersonelSoyad.Name = "txtPersonelSoyad";
            txtPersonelSoyad.Size = new Size(230, 23);
            txtPersonelSoyad.TabIndex = 1;
            // 
            // btnPersonelEkleGuncelle
            // 
            btnPersonelEkleGuncelle.Location = new Point(456, 673);
            btnPersonelEkleGuncelle.Name = "btnPersonelEkleGuncelle";
            btnPersonelEkleGuncelle.Size = new Size(235, 44);
            btnPersonelEkleGuncelle.TabIndex = 9;
            btnPersonelEkleGuncelle.Text = "Personel Ekle";
            btnPersonelEkleGuncelle.UseVisualStyleBackColor = true;
            btnPersonelEkleGuncelle.Click += btnPersonelEkleGuncelle_Click;
            // 
            // lviPersonel
            // 
            lviPersonel.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lviPersonel.GridLines = true;
            lviPersonel.Location = new Point(12, 87);
            lviPersonel.Name = "lviPersonel";
            lviPersonel.Size = new Size(855, 155);
            lviPersonel.TabIndex = 18;
            lviPersonel.UseCompatibleStateImageBehavior = false;
            lviPersonel.View = View.Details;
            lviPersonel.SelectedIndexChanged += lviPersonel_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Soyad";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Departman";
            columnHeader3.Width = 300;
            // 
            // mtbPersonelTelefon
            // 
            mtbPersonelTelefon.Location = new Point(173, 591);
            mtbPersonelTelefon.Mask = "(999) 000-00-00";
            mtbPersonelTelefon.Name = "mtbPersonelTelefon";
            mtbPersonelTelefon.Size = new Size(228, 23);
            mtbPersonelTelefon.TabIndex = 7;
            // 
            // txtPersonelAdres
            // 
            txtPersonelAdres.Location = new Point(559, 539);
            txtPersonelAdres.Multiline = true;
            txtPersonelAdres.Name = "txtPersonelAdres";
            txtPersonelAdres.Size = new Size(282, 77);
            txtPersonelAdres.TabIndex = 8;
            // 
            // txtPersonelEmail
            // 
            txtPersonelEmail.Location = new Point(173, 539);
            txtPersonelEmail.Name = "txtPersonelEmail";
            txtPersonelEmail.Size = new Size(228, 23);
            txtPersonelEmail.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(416, 537);
            label8.Name = "label8";
            label8.Size = new Size(138, 21);
            label8.TabIndex = 41;
            label8.Text = "Personel Adres :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(24, 591);
            label9.Name = "label9";
            label9.Size = new Size(151, 21);
            label9.TabIndex = 40;
            label9.Text = "Personel Telefon :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(24, 539);
            label10.Name = "label10";
            label10.Size = new Size(143, 21);
            label10.TabIndex = 39;
            label10.Text = "Personel E-mail :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(24, 486);
            label11.Name = "label11";
            label11.Size = new Size(203, 34);
            label11.TabIndex = 45;
            label11.Text = "İletişim Bilgileri";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(605, 320);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(235, 23);
            dtpDogumTarihi.TabIndex = 3;
            // 
            // gbxCinsiyet
            // 
            gbxCinsiyet.BackColor = Color.Transparent;
            gbxCinsiyet.Controls.Add(rbnErkek);
            gbxCinsiyet.Controls.Add(rbnKadin);
            gbxCinsiyet.Location = new Point(605, 361);
            gbxCinsiyet.Name = "gbxCinsiyet";
            gbxCinsiyet.Size = new Size(235, 45);
            gbxCinsiyet.TabIndex = 4;
            gbxCinsiyet.TabStop = false;
            // 
            // rbnErkek
            // 
            rbnErkek.AutoSize = true;
            rbnErkek.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbnErkek.Location = new Point(111, 11);
            rbnErkek.Name = "rbnErkek";
            rbnErkek.Size = new Size(70, 25);
            rbnErkek.TabIndex = 1;
            rbnErkek.TabStop = true;
            rbnErkek.Text = "Erkek";
            rbnErkek.UseVisualStyleBackColor = true;
            // 
            // rbnKadin
            // 
            rbnKadin.AutoSize = true;
            rbnKadin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbnKadin.Location = new Point(6, 11);
            rbnKadin.Name = "rbnKadin";
            rbnKadin.Size = new Size(72, 25);
            rbnKadin.TabIndex = 0;
            rbnKadin.TabStop = true;
            rbnKadin.Text = "Kadın";
            rbnKadin.UseVisualStyleBackColor = true;
            // 
            // mbxTcNo
            // 
            mbxTcNo.Location = new Point(168, 427);
            mbxTcNo.Mask = "00000000000";
            mbxTcNo.Name = "mbxTcNo";
            mbxTcNo.Size = new Size(228, 23);
            mbxTcNo.TabIndex = 2;
            mbxTcNo.ValidatingType = typeof(int);
            // 
            // btnSil
            // 
            btnSil.Location = new Point(215, 673);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(235, 43);
            btnSil.TabIndex = 49;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(23, 269);
            label12.Name = "label12";
            label12.Size = new Size(181, 34);
            label12.TabIndex = 50;
            label12.Text = "Kişisel Bilgiler";
            // 
            // cbxDepartman
            // 
            cbxDepartman.FormattingEnabled = true;
            cbxDepartman.Items.AddRange(new object[] { "İK", "Bilgi İşlem", "IT", "Muhasebe", "Lojistik" });
            cbxDepartman.Location = new Point(605, 427);
            cbxDepartman.Name = "cbxDepartman";
            cbxDepartman.Size = new Size(236, 23);
            cbxDepartman.TabIndex = 5;
            // 
            // SirketYetkisliEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 755);
            Controls.Add(cbxDepartman);
            Controls.Add(label12);
            Controls.Add(btnSil);
            Controls.Add(mbxTcNo);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(gbxCinsiyet);
            Controls.Add(label11);
            Controls.Add(mtbPersonelTelefon);
            Controls.Add(txtPersonelAdres);
            Controls.Add(txtPersonelEmail);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(lviPersonel);
            Controls.Add(btnPersonelEkleGuncelle);
            Controls.Add(txtPersonelSoyad);
            Controls.Add(txtPersonelAd);
            Controls.Add(txtPersonelAra);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SirketYetkisliEkrani";
            Text = "SirketYetkisliEkrani";
            Load += SirketYetkisliEkrani_Load;
            gbxCinsiyet.ResumeLayout(false);
            gbxCinsiyet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPersonelAra;
        private TextBox txtPersonelAd;
        private TextBox txtPersonelSoyad;
        private Button btnPersonelEkleGuncelle;
        private ListView lviPersonel;
        private MaskedTextBox mtbPersonelTelefon;
        private TextBox txtPersonelAdres;
        private TextBox txtPersonelEmail;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker dtpDogumTarihi;
        private GroupBox gbxCinsiyet;
        private RadioButton rbnErkek;
        private RadioButton rbnKadin;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private MaskedTextBox mbxTcNo;
        private Button btnSil;
        private Label label12;
        private ComboBox cbxDepartman;
    }
}