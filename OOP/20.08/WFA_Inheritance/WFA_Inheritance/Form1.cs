using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        List<Urun> urunler = new List<Urun>();
        List<EkranKarti> ekranKartlari = new List<EkranKarti>();

        private void Form1_Load(object sender, EventArgs e)
        {
            EkranKarti ekranKarti = new EkranKarti();
            ekranKarti.Marka = "Nvdia";
            ekranKarti.Model = "GTX 2060";
            ekranKarti.Fiyat = 8000;

            ekranKartlari.Add(ekranKarti);
            foreach (EkranKarti item in ekranKartlari)
            {
                urunler.Add(item);
            }

            Anakart anakart = new Anakart();
            anakart.Marka = "MSI";
            anakart.Model = "DML500";
            anakart.Fiyat = 2500;
            urunler.Add(anakart);


            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Fiyat = 10500;
            bilgisayar.IslemciMarka = "Intel";
            bilgisayar.AnaKart = anakart;
            bilgisayar.EkranKarti = ekranKarti;
            urunler.Add(bilgisayar);


            //MessageBox.Show(bilgisayar.EkranKarti.Model);



        }
    }
}
