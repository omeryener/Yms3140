using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Kitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Basit İşlem
            //Kitap ktp1 = new Kitap();
            //ktp1.Ad = "1984";
            //ktp1.Yazar = "George Orwell";
            //ktp1.SayfaNo = 384;
            //ktp1.YayinEvi = "Can";
            //ktp1.Tur = "Edebiyat";
            //ktp1.BasimYili = "2000";
            //ktp1.Fiyat = 22.8m;


            //Kitap ktp2 = new Kitap();
            //ktp2.Ad = "Kaygının Anlamı";
            //ktp2.Yazar = "İsmail Sürmeli";
            //ktp2.SayfaNo = 526;
            //ktp2.YayinEvi = "Okyanus";
            //ktp2.Tur = "Felsefe";
            //ktp2.BasimYili = "2017";
            //ktp2.Fiyat = 54.31m;

            //Kitap ktp3 = new Kitap();
            //ktp3.Ad = "Sefiller";
            //ktp3.Yazar = "Victor Hugo";
            //ktp3.SayfaNo = 800;
            //ktp3.YayinEvi = "İş Bankası";
            //ktp3.Tur = "Dünya Klasikleri";
            //ktp3.BasimYili = "2007";
            //ktp3.Fiyat = 20m;

            //List<Kitap> kitaplik = new List<Kitap>();
            //kitaplik.Add(ktp1);
            //kitaplik.Add(ktp2);
            //kitaplik.Add(ktp3);

            //foreach (Kitap kitap in kitaplik)
            //{
            //    MessageBox.Show(kitap.Ad);
            //} 
            #endregion
          

        }


        List<Kitap> kitapListesi = new List<Kitap>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitap yeniKitap = new Kitap();
            yeniKitap.Ad = txtKitapAd.Text;
            yeniKitap.BasimYili = txtBasimYil.Text;
            yeniKitap.Fiyat = nudFiyat.Value;
            yeniKitap.SayfaNo = int.Parse(txtSayfaNo.Text);
            yeniKitap.Tur = txtTur.Text;
            yeniKitap.YayinEvi = txtYayinEvi.Text;
            yeniKitap.Yazar = txtYazar.Text;
            kitapListesi.Add(yeniKitap);
            listBox1.Items.Clear();
            foreach (Kitap k in kitapListesi)
            {

                listBox1.Items.Add(k.Ad);
            }


        }

    }
}
