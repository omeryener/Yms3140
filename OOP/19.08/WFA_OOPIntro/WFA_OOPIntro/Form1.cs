using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Class (Sınıf)
            /*
                Bir veri tipini modellemek için kullandığımız yapılara denir. Bir sınıf, kapsüllenmiş verileri bu veriler üzerinde işlem yapacak metotları ve bu verilere ait özellikleri içerebilir.
             */

            //#region Nesnenin bir örneğini alıp değerleri atama
            //Ayakkabi ayakkabi = new Ayakkabi();
            //ayakkabi.fiyat = 300m;
            //ayakkabi.malzeme = "deri";
            //ayakkabi.marka = "Nixe";
            //ayakkabi.numara = 42;
            //ayakkabi.renk = "Beyaz";
            //ayakkabi.tabanCesit = "Ortopedik";
            //ayakkabi.tip = "Spor";

            //MessageBox.Show(ayakkabi.fiyat.ToString()); 
            //#endregion

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi = new Ayakkabi();
            ayakkabi.malzeme = txtMalzeme.Text;
            ayakkabi.marka = txtMarka.Text;
            ayakkabi.fiyat = nudFiyat.Value;
            ayakkabi.numara = (int)nudNumara.Value;
            ayakkabi.renk = txtRenk.Text;
            ayakkabi.tabanCesit = txtTabanCesit.Text;
            ayakkabi.tip = txtTip.Text;

            //MessageBox.Show(ayakkabi.marka + " isimli ayakkabı eklendi");

            //ListViewItem lvi = new ListViewItem();
            //lvi.Text = ayakkabi.marka;
            //lvi.SubItems.Add(ayakkabi.tip);
            //lvi.SubItems.Add(ayakkabi.tabanCesit);
            //lvi.SubItems.Add(ayakkabi.renk);
            //lvi.SubItems.Add(ayakkabi.numara.ToString());
            //lvi.SubItems.Add(ayakkabi.malzeme);
            //lvi.SubItems.Add(ayakkabi.fiyat.ToString("C2"));

            //listView1.Items.Add(lvi);


            //Aşağıdaki değişkeni tabımlama sebebimiz; ListeyeEkle() isimli metottdan dönen değeri ListViewItem tipinde bulunan lvi isimli değişken içerisine aktarabilmek için. Bu sayede 71. satırda bulunan listView1.Items.Add(lvi); sayesinde dönen değeri listview1'e doğrudan aktarır.
            ListViewItem lvi = ListeyeEkle(ayakkabi.malzeme, ayakkabi.marka, ayakkabi.fiyat, ayakkabi.numara.ToString(), ayakkabi.renk, ayakkabi.tabanCesit, ayakkabi.tip);
            
            
            listView1.Items.Add(lvi);
            
            
            //listView1.Items.Add(ListeyeEkle(ayakkabi.malzeme, ayakkabi.marka, ayakkabi.fiyat, ayakkabi.numara.ToString(), ayakkabi.renk, ayakkabi.tabanCesit, ayakkabi.tip));

            

        }

        //Geriye Değer Döndüren ve Parametre Alan Metot
        ListViewItem ListeyeEkle(string malzeme,string marka, decimal fiyat, string numara, string renk, string tabanCesit, string tip)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = marka;
            lvi.SubItems.Add(tip);
            lvi.SubItems.Add(tabanCesit);
            lvi.SubItems.Add(renk);
            lvi.SubItems.Add(numara);
            lvi.SubItems.Add(malzeme);
            lvi.SubItems.Add(fiyat.ToString("C2"));

            return lvi;
        }

    }
}
