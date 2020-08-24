using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPIntro
{
    class Pabuc
    {
        //Bir pabucun ......'sı olur.

        /*
         OOP içerisinde 4 Temel prensip bulunmaktadır.
            1-Encapsulation (Kapsülleme)
            2-Inheritance (Kalıtım/Miras)
            3-Polymorphism (Çok Biçimlilik)
            4-Abstraction (Soyutlama)
         */

        //public int numara;
        //Property
        private int _numara;
        public int Numara
        {
            //Get=>Getter yani property çağrıldığında devreye girer.
            get
            {
                return _numara;
            }

            //Set=> Setter property'e değer atandığında devreye girer.
            set
            {
                if (value <= 35 || value >= 45)//38
                {
                    MessageBox.Show("Numara 35'den küçük veya 45'den büyük olamaz.");
                }
                else
                {
                    _numara = value;//38
                }
            }
        }

        public string Renk { get; set; }
        public string TabanCesit { get; set; }
        //prop+tab+tab

        public string Tip { get; set; }
        public string Marka { get; set; }
        public string Malzeme { get; set; }
        public decimal Fiyat { get; set; }

        //propfull+tab+tab
        private int _Ornek;

        public int Ornek
        {
            get { return _Ornek; }
            set { _Ornek = value; }
        }



        //internal string renk;
        //public string tabanCesit;
        //public string tip;
        //public string marka;
        //public string malzeme;
        //public decimal fiyat;



    }
}
