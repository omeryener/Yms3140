using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AyakkabiDukkani
{
    public class Ayakkabi
    {

        public string Marka { get; set; }//property
        public string Tip { get; set; }
        public string TabanCesit { get; set; }
        public string Renk { get; set; }

        //Encapsulation (Kapsülleme)
        //public int Numara { get; set; }
        private int _numara;

        public int Numara
        {
            get { return _numara; }
            set
            {
                if (value <= 35 || value >= 45)
                {
                    MessageBox.Show("36'dan küçük veya 45'den büyük bir numara giremezsiniz");

                }
                else
                {
                    _numara = value;
                }
            }
        }


        public string Malzeme { get; set; }
        public decimal Fiyat { get; set; }//KDVHariç

        //Read only=> içerisinde bulunan değer sadece okunabilir. Dışarıdan değer gönderilemez.
        public decimal KdvFiyat
        {
            get
            {
                return Fiyat + (Fiyat * 0.18m);
            }
        }


        

    }
}
