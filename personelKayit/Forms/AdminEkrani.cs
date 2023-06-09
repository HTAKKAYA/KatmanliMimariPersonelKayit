using BLL.BLL.Models;
using Entities.Enums;
using Entities.Models;
using personelKayit.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelKayit.Forms
{
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
            yoneticiBLL = new YoneticiBLL();
            ListviewGuncelle();
        }

        YoneticiBLL yoneticiBLL;

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
            ListviewGuncelle();
        }


        private void ListeyiDoldur()
        {
            yoneticiBLL = new YoneticiBLL();

        }

        private void lviSirketYetkilisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviSirketYetkilisi.SelectedItems.Count > 0)
            {
                btnKaydetGuncelle.Text = "Güncelle";
                var selectedLvi = lviSirketYetkilisi.SelectedItems[0];

                if (selectedLvi.Tag is Yonetici yonetici)
                {
                    int yoneticiID = yonetici.Id;
                    Yonetici yonetici1 = yoneticiBLL.IdyeGoreGetir(yoneticiID);
                    txtAd.Text = yonetici1.Ad;
                    txtSoyad.Text = yonetici1.Soyad;
                    mtbTcNo.Text = yonetici1.TCNo;
                    txtEmail.Text = yonetici1.Email;
                    txtSifre.Text = "Şifre belirleyin";
                    if (yonetici1.Unvan == Unvan.admin)
                    {
                        rbnCeo.Checked = true;
                    }
                    else
                    {
                        rbnYonetici.Checked = true;
                    }
                    if (yonetici1.Cinsiyet == Cinsiyet.erkek)
                    {
                        rbnErkek.Checked = true;
                    }
                    else
                    {
                        rbnKadin.Checked = true;
                    }
                    if (yonetici1.AktifMi == true)
                    {
                        rbnAktif.Checked = true;
                    }
                    else
                    {
                        rbnPasif.Checked = true;
                    }
                }
            }
            else
            {
                Helper.FormuTemizle(this.Controls);
                btnKaydetGuncelle.Text = "Kaydet";
            }
        }


        private void btnKaydetGuncelle_Click(object sender, EventArgs e)
        {
            if (btnKaydetGuncelle.Text == "Kaydet")
            {
                if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(mtbTcNo.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
                {
                    MessageBox.Show("Alanlar Boş Geçilemez!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Yonetici yonetici = new Yonetici();
                    yonetici.Ad = txtAd.Text;
                    yonetici.Soyad = txtSoyad.Text;

                    if (rbnCeo.Checked)
                    {
                        yonetici.Unvan = Unvan.admin;
                    }
                    else
                    {
                        yonetici.Unvan = Unvan.yonetici;
                    }

                    if (yoneticiBLL.TcNoVarMi(mtbTcNo.Text))
                    {
                        MessageBox.Show("TC No Zaten Kullanılmakta. TC No Benzersiz Olmalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        yonetici.TCNo = mtbTcNo.Text;
                    }


                    if (txtEmail.Text.Contains("@") && txtEmail.Text.EndsWith(".com"))
                    {
                        if (yoneticiBLL.EmailVarMi(txtEmail.Text))
                        {
                            MessageBox.Show("Girmiş Olduğunuz E-mail Adresi Zaten Kullanılmaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;

                        }
                        else
                        {
                            yonetici.Email = txtEmail.Text;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir mail adresi giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    yonetici.Sifre = yoneticiBLL.ComputeSha256Hash(txtSifre.Text);

                    if (rbnErkek.Checked)
                    {
                        yonetici.Cinsiyet = Cinsiyet.erkek;
                    }
                    else
                    {
                        yonetici.Cinsiyet = Cinsiyet.kadın;
                    }

                    if (rbnPasif.Checked)
                    {
                        yonetici.AktifMi = false;
                    }
                    else
                    {
                        yonetici.AktifMi = true;
                    }

                    bool basariliMi = yoneticiBLL.Ekle(yonetici);

                    if (basariliMi)
                    {
                        MessageBox.Show($"{yonetici.Ad} {yonetici.Soyad} Kaydı Başarıyla Gerçekleşmiştir.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListviewGuncelle();
                        Helper.FormuTemizle(this.Controls);
                    }
                    else
                    {
                        MessageBox.Show("Kaydedilirken Bir Hata Meydana Geldi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }



            }
            else
            {
                var selectedLvi = lviSirketYetkilisi.SelectedItems[0];

                if (selectedLvi.Tag is Yonetici yonetici)
                {
                    int yoneticiID = yonetici.Id;
                    Yonetici yonetici1 = yoneticiBLL.IdyeGoreGetir(yoneticiID);

                    if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(mtbTcNo.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
                    {
                        MessageBox.Show("Alanlar Boş Geçilemez!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        yonetici1.Ad = txtAd.Text;
                        yonetici1.Soyad = txtSoyad.Text;
                        if (rbnCeo.Checked)
                        {
                            yonetici.Unvan = Unvan.admin;
                        }
                        else
                        {
                            yonetici.Unvan = Unvan.yonetici;
                        }

                        if (yoneticiBLL.TcNoVarMi(mtbTcNo.Text))
                        {


                        }
                        else
                        {
                            yonetici1.TCNo = mtbTcNo.Text;
                        }


                        if (txtEmail.Text.Contains("@") && txtEmail.Text.EndsWith(".com"))
                        {
                            if (yoneticiBLL.EmailVarMi(txtEmail.Text))
                            {


                            }
                            else
                            {
                                yonetici1.Email = txtEmail.Text;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geçerli bir mail adresi giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if(txtSifre.Text == "Şifre belirleyin")
                        {
                           
                        }
                        else
                        {
                            yonetici1.Sifre = yoneticiBLL.ComputeSha256Hash(txtSifre.Text);
                        }


                        if (rbnErkek.Checked)
                        {
                            yonetici1.Cinsiyet = Cinsiyet.erkek;
                        }
                        else
                        {
                            yonetici1.Cinsiyet = Cinsiyet.kadın;
                        }

                        if (rbnPasif.Checked)
                        {
                            yonetici1.AktifMi = false;
                        }
                        else
                        {
                            yonetici1.AktifMi = true;
                        }

                        bool guncellendiMi = yoneticiBLL.Guncelle(yonetici1);

                        if (guncellendiMi)
                        {
                            MessageBox.Show($"{yonetici.Ad} {yonetici.Soyad} Başarıyla Güncellenmiştir.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListviewGuncelle();
                            Helper.FormuTemizle(this.Controls);
                        }
                        else
                        {
                            MessageBox.Show("Güncellenirken Bir Hata Meydana Geldi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }


                }
            }
        }

        public void ListviewGuncelle()
        {
            lviSirketYetkilisi.Items.Clear();
            List<Yonetici> yoneticiler = yoneticiBLL.TumYoneticileriGetir();
            foreach (Yonetici yonetici in yoneticiler)
            {
                ListViewItem lvi = new();
                lvi.Text = yonetici.Ad;
                lvi.SubItems.Add(yonetici.Soyad);
                lvi.SubItems.Add(yonetici.AktifMi ? "Aktif" : "Pasif");
                lvi.SubItems.Add(yonetici.Unvan.ToString());
                lvi.Tag = yonetici;
                lviSirketYetkilisi.Items.Add(lvi);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lviSirketYetkilisi.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Silme işlemini onaylıyor musunuz?", "Silme Onayı", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    var selectedLvi = lviSirketYetkilisi.SelectedItems[0];

                    if (selectedLvi.Tag is Yonetici yonetici)
                    {
                        int yoneticiID = yonetici.Id;
                        bool silindiMi = yoneticiBLL.Sil(yoneticiID);

                        if (silindiMi)
                        {
                            MessageBox.Show("Personel Silindi");
                            ListviewGuncelle();
                            Helper.FormuTemizle(this.Controls);
                        }
                        else
                        {
                            MessageBox.Show("Silinemedi");
                        }
                    }
                }
            }
        }

        private void btnPersonelleriGor_Click(object sender, EventArgs e)
        {
            this.Hide();
            SirketYetkisliEkrani sirketYetkisliEkrani = new SirketYetkisliEkrani();
            sirketYetkisliEkrani.ShowDialog();
        }
    }
}
