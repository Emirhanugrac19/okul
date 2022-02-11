using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _KitapDukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Yazarlar> yazarlar = new List<Yazarlar>();
        List<Musteriler> musteriler = new List<Musteriler>();
        List<Kitaplar> kitaplar = new List<Kitaplar>();
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazarlar yzr = new Yazarlar();
            yzr.YazarAdi = txtYazarAdi.Text;
            yzr.DogumTarihi = dtYazarDogumTarihi.Value;
            if (chkNobel.Checked == true)
            {
                yzr.NobelOduluVarMi = true;
            }
            else
            {
                yzr.NobelOduluVarMi = false;
            }
            yazarlar.Add(yzr);
            cmbYazar.Items.Add(yzr);
            cmbYazar.DisplayMember = "YazarAdi";
            txtYazarAdi.Text = null;
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitaplar ktp = new Kitaplar();
            ktp.KitapAdi = txtKitapAdi.Text;
            ktp.KitapTuru = (string)cmbKitapTuru.SelectedItem;
            ktp.SayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            ktp.Fiyat = decimal.Parse(txtFiyat.Text);
            ktp.yazar = (Yazarlar)cmbYazar.SelectedItem;
            kitaplar.Add(ktp);
            cmbKitap.Items.Add(ktp);
            cmbKitap.DisplayMember = "KitapAdi";
            txtKitapAdi.Text = null;
            txtSayfaSayisi.Text = null;
            txtFiyat.Text = null;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteriler mstr = new Musteriler();
            mstr.MusteriAdi = txtMusteriAdi.Text;
            mstr.Meslegi = txtMeslegi.Text;
            mstr.Kitap = (Kitaplar)cmbKitap.SelectedItem;
            mstr.Yas = int.Parse(txtMusteriYas.Text);
            musteriler.Add(mstr);
            txtMusteriAdi.Text = null;
            txtMeslegi.Text = null;
            txtMusteriYas.Text = null;
        }

        private void btnMusterileriGetir_Click(object sender, EventArgs e)
        {
            lsbMusteriler.Items.Clear();
            lsbMusteriler.Items.Add("Adı Kitap_Adı Fiyatı Yazarı");
            foreach (Musteriler veriler in musteriler)
            {
                lsbMusteriler.Items.Add(veriler.MusteriAdi + " " + veriler.Kitap.KitapAdi + " " + veriler.Kitap.Fiyat + " " + veriler.Kitap.yazar.YazarAdi);
            }
        }
    }
}
