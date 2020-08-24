using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Constructor (Yapıcı Metot)

            /*
                Yapıcı metotlardan kısaca bahsetmek gerekirse , static olmayan (ileride göreceğiz) bir sınıf içerisindeki özelliklere sınıfın instance alımı esnasında değerleri atama işlemidir.
             */

            Bebek bebek1 = new Bebek();
            bebek1.AnneAdi = "Hatice";
            bebek1.BabaAdi = "Hüseyin";
            bebek1.Cinsiyet = "Erkek";

            bebek1.Ebe = "Hicran";

            Bebek bebek2 = new Bebek();
            bebek2.AnneAdi = "Fatma";
            bebek2.BabaAdi = "Hasan";
            bebek2.Cinsiyet = "Kız";
            //bebek2.DogumTarihi = DateTime.Now;
            bebek2.Ebe = "Merve";

            Bebek bebek3 = new Bebek();
            bebek3.AnneAdi = "Ayşe";
            bebek3.BabaAdi = "Mehmet";
            bebek3.Cinsiyet = "Kız";
            //bebek3.DogumTarihi = DateTime.Now;
            bebek3.Ebe = "Zeynep";

            Bebek bebek4 = new Bebek("Şeyma");


            //MessageBox.Show(bebek1.DogumTarihi.ToString());
            //MessageBox.Show(bebek2.DogumTarihi.ToString());
            //MessageBox.Show(bebek3.DogumTarihi.ToString());

            //MessageBox.Show(bebek4.Ebe);

            Bebek bebek5 = new Bebek("Merve", "Fatma", "Murat", "erkek");



            //Object Initializer
            Bebek bebek6 = new Bebek()
            {
                AnneAdi = "Zeynep",
                BabaAdi = "Ahmet",
                Ebe = "Ayşe",
                Cinsiyet = "Kız",
                DogumTarihi = DateTime.Now
            };

            Bebek bebek7 = new Bebek();
            bebek7.AnneAdi = "Zeynep";
            bebek7.BabaAdi = "Ahmet";

        }
    }
}
