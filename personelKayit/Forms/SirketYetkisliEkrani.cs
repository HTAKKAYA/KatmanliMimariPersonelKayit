using BLL.BLL.Models;
using Entities.Enums;
using Entities.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonelKayit.Forms
{
    public partial class SirketYetkisliEkrani : Form
    {
        public SirketYetkisliEkrani()
        {
            InitializeComponent();
            personelBLL = new PersonelBLL();
            personel = new Personel();
        }

        PersonelBLL personelBLL;
        Personel personel;

        private void SirketYetkisliEkrani_Load(object sender, EventArgs e)
        {
            ListviewGuncelle();
        }

        private void lviPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviPersonel.SelectedItems.Count > 0)
            {
                btnPersonelEkleGuncelle.Text = "Personeli Güncelle";
                var selectedLvi = lviPersonel.SelectedItems[0];

                if (selectedLvi.Tag is Personel personel)
                {
                    int personelID = personel.Id;
                    Personel personel1 = personelBLL.IdyeGoreGetir(personelID);

                    txtPersonelAd.Text = personel1.Ad;
                    txtPersonelSoyad.Text = personel1.Soyad;
                    mbxTcNo.Text = personel1.TCNo;
                    cbxDepartman.Text = personel1.Departman;
                    txtPersonelEmail.Text = personel1.Email;
                    txtPersonelAdres.Text = personel1.Adres;
                    mtbPersonelTelefon.Text = personel1.Telefon;
                    //dtpDogumTarihi.Value = personel1.DogumTarihi.Date;
                    if (personel1.Cinsiyet == Cinsiyet.erkek)
                    {
                        rbnErkek.Checked = true;
                    }
                    else
                    {
                        rbnKadin.Checked = true;
                    }
                }

            }
            else
            {
                btnPersonelEkleGuncelle.Text = "Personel Ekle";
            }
        }

        private void btnPersonelEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (btnPersonelEkleGuncelle.Text == "Personeli Güncelle")
            {
                var selectedLvi = lviPersonel.SelectedItems[0];

                if (selectedLvi.Tag is Personel personel)
                {
                    int personelID = personel.Id;
                    Personel personel1 = personelBLL.IdyeGoreGetir(personelID);

                    if (string.IsNullOrWhiteSpace(txtPersonelAd.Text) || string.IsNullOrWhiteSpace(txtPersonelSoyad.Text) || string.IsNullOrWhiteSpace(mbxTcNo.Text) || string.IsNullOrWhiteSpace(txtPersonelEmail.Text) || string.IsNullOrWhiteSpace(mtbPersonelTelefon.Text) || string.IsNullOrWhiteSpace(txtPersonelAdres.Text))
                    {
                        MessageBox.Show("Alanlar Boş Geçilemez!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        personel1.Ad = txtPersonelAd.Text;
                        personel1.Soyad = txtPersonelSoyad.Text;

                        string secilenDepertman = cbxDepartman.Text;


                        if (secilenDepertman == "İK")
                        {
                            personel1.Departman = "İK";
                        }
                        else if (secilenDepertman == "Bilgi İşlem")
                        {
                            personel1.Departman = "Bilgi İşlem";
                        }
                        else if (secilenDepertman == "IT")
                        {
                            personel1.Departman = "IT";
                        }
                        else if (secilenDepertman == "Muhasebe")
                        {
                            personel1.Departman = "Muhasebe";
                        }
                        else
                        {
                            personel1.Departman = "Lojistik";
                        }

                        if ((DateTime.Now - dtpDogumTarihi.Value).TotalDays > 18 * 365)
                        {
                            personel1.DogumTarihi = dtpDogumTarihi.Value;
                        }
                        else
                        {
                            MessageBox.Show("Çalışcanlar 18 yaşından küöük olmazlar.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (personelBLL.TcNoVarMi(mbxTcNo.Text))
                        {
                            
                        }
                        else
                        {
                            personel1.TCNo = mbxTcNo.Text;
                        }


                        if (txtPersonelEmail.Text.Contains("@") && txtPersonelEmail.Text.EndsWith(".com"))
                        {
                            if (personelBLL.EmailVarMi(txtPersonelEmail.Text))
                            {
                               

                            }
                            else
                            {
                                personel1.Email = txtPersonelEmail.Text;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geçerli bir mail adresi giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        personel1.Telefon = mtbPersonelTelefon.Text;
                        personel1.Adres = txtPersonelAdres.Text;

                        if (rbnErkek.Checked)
                        {
                            personel1.Cinsiyet = Cinsiyet.erkek;
                        }
                        else
                        {
                            personel1.Cinsiyet = Cinsiyet.kadın;
                        }

                        bool guncellendiMi = personelBLL.Guncelle(personel1);

                        if (guncellendiMi)
                        {
                            MessageBox.Show($"{personel1.Ad} {personel1.Soyad} Başarıyla Güncellenmiştir.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                Personel personel1 = new Personel();
                personel1.Ad = txtPersonelAd.Text;
                personel1.Soyad = txtPersonelSoyad.Text;

                string secilenDepertman = cbxDepartman.Text;


                if (secilenDepertman == "İK")
                {
                    personel1.Departman = "İK";
                }
                else if (secilenDepertman == "Bilgi İşlem")
                {
                    personel1.Departman = "Bilgi İşlem";
                }
                else if (secilenDepertman == "IT")
                {
                    personel1.Departman = "IT";
                }
                else if (secilenDepertman == "Muhasebe")
                {
                    personel1.Departman = "Muhasebe";
                }
                else
                {
                    personel1.Departman = "Lojistik";
                }

                if ((DateTime.Now - dtpDogumTarihi.Value).TotalDays > 18 * 365)
                {
                    personel1.DogumTarihi = dtpDogumTarihi.Value;
                }
                else
                {
                    MessageBox.Show("Çalışcanlar 18 yaşından küöük olmazlar.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (personelBLL.TcNoVarMi(mbxTcNo.Text))
                {
                    MessageBox.Show("TC No Zaten Kullanılmakta. TC No Benzersiz Olmalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    personel1.TCNo = mbxTcNo.Text;
                }


                if (txtPersonelEmail.Text.Contains("@") && txtPersonelEmail.Text.EndsWith(".com"))
                {
                    if (personelBLL.EmailVarMi(txtPersonelEmail.Text))
                    {
                        MessageBox.Show("Girmiş Olduğunuz E-mail Adresi Zaten Kullanılmaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else
                    {
                        personel1.Email = txtPersonelEmail.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir mail adresi giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                personel1.Telefon = mtbPersonelTelefon.Text;
                personel1.Adres = txtPersonelAdres.Text;

                if (rbnErkek.Checked)
                {
                    personel1.Cinsiyet = Cinsiyet.erkek;
                }
                else
                {
                    personel1.Cinsiyet = Cinsiyet.kadın;
                }

                bool kaydedildiMi = personelBLL.Ekle(personel1);

                if (kaydedildiMi)
                {
                    MessageBox.Show($"{personel1.Ad} {personel1.Soyad} Başarıyla Eklenmiştir.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListviewGuncelle();
                    Helper.FormuTemizle(this.Controls);
                }
                else
                {
                    MessageBox.Show("Personel Eklenirken Bir Hata Meydana Geldi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        public void ListviewGuncelle()
        {
            lviPersonel.Items.Clear();
            List<Personel> personeller = personelBLL.TumPersonelleriGetir();
            foreach (Personel personel in personeller)
            {
                ListViewItem lvi = new();
                lvi.Text = personel.Ad;
                lvi.SubItems.Add(personel.Soyad);
                lvi.SubItems.Add(personel.Departman);
                lvi.Tag = personel;
                lviPersonel.Items.Add(lvi);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lviPersonel.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Silme işlemini onaylıyor musunuz?", "Silme Onayı", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    var selectedLvi = lviPersonel.SelectedItems[0];

                    if (selectedLvi.Tag is Personel personel)
                    {
                        int personelID = personel.Id;
                        bool silindiMi = personelBLL.Sil(personelID);

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

        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {
            string aramaKelimesi = txtPersonelAra.Text;

            lviPersonel.Items.Clear();
            List<Personel> personeller = personelBLL.ArananPersonel(aramaKelimesi);
            foreach (Personel personel in personeller)
            {
                ListViewItem lvi = new();
                lvi.Text = personel.Ad;
                lvi.SubItems.Add(personel.Soyad);
                lvi.SubItems.Add(personel.Departman);
                lvi.Tag = personel;
                lviPersonel.Items.Add(lvi);
            }
        }
    }
}
