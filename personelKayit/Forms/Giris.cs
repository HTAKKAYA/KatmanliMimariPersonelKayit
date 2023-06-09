using BLL.BLL.Models;
using Entities.Enums;
using Entities.Models;
using Microsoft.VisualBasic.ApplicationServices;
using PersonelKayit.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayit
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            yoneticiBLL = new YoneticiBLL();
        }

        YoneticiBLL yoneticiBLL;
        Yonetici yonetici;

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                yoneticiBLL = new YoneticiBLL();
                Yonetici yonetici = yoneticiBLL.EmaileGoreGetir(txtEmail.Text.Trim());

                if (yonetici == null)
                {
                    MessageBox.Show("Kullanıcı Bulunamadı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (yonetici.Sifre != yoneticiBLL.ComputeSha256Hash(txtSifre.Text))
                {
                    MessageBox.Show("Email Adı veya Şifre Hatalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!yonetici.AktifMi)
                {
                    MessageBox.Show("Admin kaydınızı onaylamamıştır. Lütfen admin ile iletişime geçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    switch (yonetici.Unvan)
                    {
                        case Unvan.admin:
                            AdminEkrani adminEkrani = new AdminEkrani();
                            adminEkrani.ShowDialog();
                            break;
                        case Unvan.yonetici:
                            SirketYetkisliEkrani sirketYetkisliEkrani = new SirketYetkisliEkrani();
                            sirketYetkisliEkrani.ShowDialog();
                            break;

                    }
                    this.Show();

                }
            }


        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
