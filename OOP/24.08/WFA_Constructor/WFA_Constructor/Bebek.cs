using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Constructor
{
    public class Bebek
    {

        //Not: Yapıcı metotlar class içerisinde görünmezler.

        //Eğer bir class içerisinde yapıcı metot'a müdahele etmek istiyorsanız class ile aynı isme sahip bir metot tanımlamalısınız. Constructor'ların geri dönüş tipi olmaz.

        //bir metotun başına 3 adet /// eklenirse o metot ile ilgili summary (özet ) oluşturur. Bu sayede metot kullanımını tooltipte görebiliriz.

        /// <summary>
        /// eğer boş bırakırsan sadece doğum tarihi eklenir.
        /// </summary>
        public Bebek()
        {
            DogumTarihi = DateTime.Now;
        }
        /// <summary>
        /// string tipte değer gönderilirse ebeAdi olarak kaydedilir.
        /// </summary>
        /// <param name="ebeAdi"></param>
        public Bebek(string ebeAdi)
        {
            DogumTarihi = DateTime.Now;
            Ebe = ebeAdi;
        }
        /// <summary>
        /// string tipte ebeAdi, string tipte anne adı gönderebilirsin.
        /// </summary>
        /// <param name="ebeAdi"></param>
        /// <param name="anneAdi"></param>
        public Bebek(string ebeAdi,string anneAdi)
        {
            DogumTarihi = DateTime.Now;
            Ebe = ebeAdi;
            AnneAdi = anneAdi;
        }
        public Bebek(string ebeAdi, string anneAdi, string babaAdi)
        {
            DogumTarihi = DateTime.Now;
            Ebe = ebeAdi;
            AnneAdi = anneAdi;
            BabaAdi = babaAdi;
        }

        public Bebek(string ebeAdi, string anneAdi, string BabaAdi, string cinsiyet)
        {
            DogumTarihi = DateTime.Now;
            Ebe = ebeAdi;
            this.BabaAdi = BabaAdi;
            Cinsiyet = cinsiyet;
        }

        public DateTime DogumTarihi { get; set; }
        public string Ebe { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public string Cinsiyet { get; set; }

    }
}
