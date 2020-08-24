using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_PersonelEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> departmanListesi = new List<string>();
        List<Personel> personelListesi = new List<Personel>();
        private void Form1_Load(object sender, EventArgs e)
        {
           departmanListesi.Add("Finans");
           departmanListesi.Add("Pazarlama");
           departmanListesi.Add("BT");
           departmanListesi.Add("Satın Alma");

            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");


            foreach (string departman in departmanListesi)
            {
                cmbDepartman.Items.Add(departman);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            //PersonelEkle();
            personelListesi.Add(PersonelEkle());

        }

        public Personel PersonelEkle()
        {
            Personel p = new Personel();
            p.Ad = txtAd.Text;
            p.Adres = txtAdres.Text;
            p.Cinsiyet = (string)cmbCinsiyet.SelectedItem;
            p.Departman = (string)cmbDepartman.SelectedItem;
            p.DogumTarihi = dtpDogumTarihi.Value;
            p.MaasBrut = nudMaasBrut.Value;
            p.MaasNet = nudMaasNet.Value;
            p.SGKNo = txtSgk.Text;
            p.Soyad = txtSoyad.Text;
            p.TCKN = txtTckn.Text;
            p.TelefonNo = txtTelefonNo.Text;
            return p;
        }

        private void btnVeritabani_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.VeritabaninaKaydet(personelListesi);
        }
    }
}
