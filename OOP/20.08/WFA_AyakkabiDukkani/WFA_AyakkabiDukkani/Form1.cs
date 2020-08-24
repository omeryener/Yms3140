using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AyakkabiDukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //formu kullanarak listviewitem içerisine ayakkabı eklensin.
            //ayakkabı numarası 36'dan küçük ve 45'den büyükse kullanıcıya uyarı verilsin; "36'dan küçük veya 45'den büyük bir numara giremezsiniz"
            //Fiyat kdv hariç olarak girilsin, listviewitem içerisinde kdv dahil olarak gösterilsin.

            

        }

        


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi = new Ayakkabi();
            ayakkabi.Marka = txtMarka.Text;
            ayakkabi.Malzeme = txtMalzeme.Text;
            ayakkabi.Numara = Convert.ToInt32(nudNumara.Value);
            ayakkabi.Renk = txtRenk.Text;
            ayakkabi.Tip = txtTip.Text;
            ayakkabi.TabanCesit = txtTabanCesit.Text;
            ayakkabi.Fiyat = nudFiyat.Value;

            #region Basit işlem
            //ListViewItem lvi = new ListViewItem();
            //lvi.Text = ayakkabi.Marka;
            //lvi.SubItems.Add(ayakkabi.Tip);
            //lvi.SubItems.Add(ayakkabi.TabanCesit);
            //lvi.SubItems.Add(ayakkabi.Renk);
            //lvi.SubItems.Add(ayakkabi.Numara.ToString());
            //lvi.SubItems.Add(ayakkabi.Malzeme);
            //lvi.SubItems.Add(ayakkabi.KdvFiyat.ToString("C2"));

            ////Eğer numara 0'a eşit değilse listviewItem'a eklesin.
            //if (ayakkabi.Numara != 0)
            //    listView1.Items.Add(lvi);
            #endregion

            //Generic List

            //List<string> metinListesi = new List<string>();
            //metinListesi.Add("Merhaba");
            //metinListesi.Add("Nasılsın?");
            //metinListesi.Add("İsmail");


            Ayakkabi ayakkabi1 = new Ayakkabi();
            ayakkabi1.Marka = "Nike";
            ayakkabi1.Fiyat = 100m;

            Ayakkabi ayakkabi2 = new Ayakkabi();
            ayakkabi2.Marka = "Adidas";
            ayakkabi2.Fiyat = 100m;

            List<Ayakkabi> ayakkabiKutusu = new List<Ayakkabi>();
            ayakkabiKutusu.Add(ayakkabi1);
            ayakkabiKutusu.Add(ayakkabi2);

            foreach (Ayakkabi ayk in ayakkabiKutusu)
            {
                MessageBox.Show(ayk.Marka);
            }


        }
    }
}
