using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_PersonelEkleme
{
    public class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string TelefonNo { get; set; }
        public string Departman { get; set; }
        public string SGKNo { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public decimal MaasBrut { get; set; }
        public decimal MaasNet { get; set; }
        public string Adres { get; set; }

        public void VeritabaninaKaydet(List<Personel> personneller)
        {
            foreach (var p in personneller)
            {
                //veritabanına kaydetme komutu...
            }
        }

        void ZamYap()
        {

        }

        void IstenCikar()
        {

        }

        void YillikIzın()
        {

        }
    }
}
