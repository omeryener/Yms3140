using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Kitap
{
   public class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int SayfaNo { get; set; }
        public string YayinEvi { get; set; }
        public string Tur { get; set; }
        public string BasimYili { get; set; }
        public decimal Fiyat { get; set; }
        


        ////Listele
        //public Kitap KitapListesi(Kitap book)
        //{
        //    return book;
        //}

    }
}
