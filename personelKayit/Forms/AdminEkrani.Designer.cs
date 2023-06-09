namespace PersonelKayit.Forms
{
    partial class AdminEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEkrani));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lviSirketYetkilisi = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnKaydetGuncelle = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            label7 = new Label();
            gbxCinsiyet = new GroupBox();
            rbnErkek = new RadioButton();
            rbnKadin = new RadioButton();
            mtbTcNo = new MaskedTextBox();
            gbxAktifPasif = new GroupBox();
            rbnPasif = new RadioButton();
            rbnAktif = new RadioButton();
            btnSil = new Button();
            groupBox1 = new GroupBox();
            rbnYonetici = new RadioButton();
            rbnCeo = new RadioButton();
            label8 = new Label();
            btnPersonelleriGor = new Button();
            gbxCinsiyet.SuspendLayout();
            gbxAktifPasif.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(42, 35);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(42, 87);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(42, 141);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "TC No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(405, 35);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(405, 87);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 4;
            label5.Text = "Şifre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(405, 141);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 5;
            label6.Text = "Aktif/Pasif :";
            // 
            // lviSirketYetkilisi
            // 
            lviSirketYetkilisi.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lviSirketYetkilisi.Dock = DockStyle.Bottom;
            lviSirketYetkilisi.GridLines = true;
            lviSirketYetkilisi.Location = new Point(0, 412);
            lviSirketYetkilisi.Name = "lviSirketYetkilisi";
            lviSirketYetkilisi.Size = new Size(800, 188);
            lviSirketYetkilisi.TabIndex = 6;
            lviSirketYetkilisi.UseCompatibleStateImageBehavior = false;
            lviSirketYetkilisi.View = View.Details;
            lviSirketYetkilisi.SelectedIndexChanged += lviSirketYetkilisi_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Soyad";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Durum";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Unvan";
            columnHeader4.Width = 200;
            // 
            // btnKaydetGuncelle
            // 
            btnKaydetGuncelle.Location = new Point(405, 277);
            btnKaydetGuncelle.Name = "btnKaydetGuncelle";
            btnKaydetGuncelle.Size = new Size(156, 37);
            btnKaydetGuncelle.TabIndex = 7;
            btnKaydetGuncelle.Text = "Kaydet";
            btnKaydetGuncelle.UseVisualStyleBackColor = true;
            btnKaydetGuncelle.Click += btnKaydetGuncelle_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(132, 37);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(205, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(132, 89);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(205, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(551, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(551, 89);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(181, 23);
            txtSifre.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(44, 196);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 14;
            label7.Text = "Cinsiyet : ";
            // 
            // gbxCinsiyet
            // 
            gbxCinsiyet.BackColor = Color.Transparent;
            gbxCinsiyet.Controls.Add(rbnErkek);
            gbxCinsiyet.Controls.Add(rbnKadin);
            gbxCinsiyet.Location = new Point(133, 185);
            gbxCinsiyet.Name = "gbxCinsiyet";
            gbxCinsiyet.Size = new Size(200, 49);
            gbxCinsiyet.TabIndex = 5;
            gbxCinsiyet.TabStop = false;
            // 
            // rbnErkek
            // 
            rbnErkek.AutoSize = true;
            rbnErkek.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbnErkek.Location = new Point(101, 11);
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
            // mtbTcNo
            // 
            mtbTcNo.Location = new Point(132, 143);
            mtbTcNo.Mask = "00000000000";
            mtbTcNo.Name = "mtbTcNo";
            mtbTcNo.Size = new Size(205, 23);
            mtbTcNo.TabIndex = 2;
            mtbTcNo.ValidatingType = typeof(int);
            // 
            // gbxAktifPasif
            // 
            gbxAktifPasif.BackColor = Color.Transparent;
            gbxAktifPasif.Controls.Add(rbnPasif);
            gbxAktifPasif.Controls.Add(rbnAktif);
            gbxAktifPasif.Location = new Point(551, 131);
            gbxAktifPasif.Name = "gbxAktifPasif";
            gbxAktifPasif.Size = new Size(200, 49);
            gbxAktifPasif.TabIndex = 6;
            gbxAktifPasif.TabStop = false;
            // 
            // rbnPasif
            // 
            rbnPasif.AutoSize = true;
            rbnPasif.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbnPasif.Location = new Point(101, 11);
            rbnPasif.Name = "rbnPasif";
            rbnPasif.Size = new Size(65, 25);
            rbnPasif.TabIndex = 1;
            rbnPasif.TabStop = true;
            rbnPasif.Text = "Pasif";
            rbnPasif.UseVisualStyleBackColor = true;
            // 
            // rbnAktif
            // 
            rbnAktif.AutoSize = true;
            rbnAktif.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbnAktif.Location = new Point(6, 11);
            rbnAktif.Name = "rbnAktif";
            rbnAktif.Size = new Size(65, 25);
            rbnAktif.TabIndex = 0;
            rbnAktif.TabStop = true;
            rbnAktif.Text = "Aktif";
            rbnAktif.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(215, 277);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(159, 37);
            btnSil.TabIndex = 18;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rbnYonetici);
            groupBox1.Controls.Add(rbnCeo);
            groupBox1.Location = new Point(551, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 49);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // rbnYonetici
            // 
            rbnYonetici.AutoSize = true;
            rbnYonetici.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbnYonetici.Location = new Point(101, 11);
            rbnYonetici.Name = "rbnYonetici";
            rbnYonetici.Size = new Size(90, 25);
            rbnYonetici.TabIndex = 1;
            rbnYonetici.TabStop = true;
            rbnYonetici.Text = "Yönetici";
            rbnYonetici.UseVisualStyleBackColor = true;
            // 
            // rbnCeo
            // 
            rbnCeo.AutoSize = true;
            rbnCeo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbnCeo.Location = new Point(6, 11);
            rbnCeo.Name = "rbnCeo";
            rbnCeo.Size = new Size(79, 25);
            rbnCeo.TabIndex = 0;
            rbnCeo.TabStop = true;
            rbnCeo.Text = "Admin";
            rbnCeo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(405, 206);
            label8.Name = "label8";
            label8.Size = new Size(60, 21);
            label8.TabIndex = 19;
            label8.Text = "Unvan";
            // 
            // btnPersonelleriGor
            // 
            btnPersonelleriGor.Location = new Point(320, 344);
            btnPersonelleriGor.Name = "btnPersonelleriGor";
            btnPersonelleriGor.Size = new Size(148, 36);
            btnPersonelleriGor.TabIndex = 21;
            btnPersonelleriGor.Text = "Personelleri Gör";
            btnPersonelleriGor.UseVisualStyleBackColor = true;
            btnPersonelleriGor.Click += btnPersonelleriGor_Click;
            // 
            // AdminEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 600);
            Controls.Add(btnPersonelleriGor);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(btnSil);
            Controls.Add(gbxAktifPasif);
            Controls.Add(mtbTcNo);
            Controls.Add(gbxCinsiyet);
            Controls.Add(label7);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnKaydetGuncelle);
            Controls.Add(lviSirketYetkilisi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminEkrani";
            Text = "1";
            Load += AdminEkrani_Load;
            gbxCinsiyet.ResumeLayout(false);
            gbxCinsiyet.PerformLayout();
            gbxAktifPasif.ResumeLayout(false);
            gbxAktifPasif.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ListView lviSirketYetkilisi;
        private Button btnKaydetGuncelle;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Label label7;
        private GroupBox gbxCinsiyet;
        private RadioButton rbnErkek;
        private RadioButton rbnKadin;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private MaskedTextBox mtbTcNo;
        private GroupBox gbxAktifPasif;
        private RadioButton rbnPasif;
        private RadioButton rbnAktif;
        private Button btnSil;
        private GroupBox groupBox1;
        private RadioButton rbnYonetici;
        private RadioButton rbnCeo;
        private Label label8;
        private ColumnHeader columnHeader4;
        private Button btnPersonelleriGor;
    }
}