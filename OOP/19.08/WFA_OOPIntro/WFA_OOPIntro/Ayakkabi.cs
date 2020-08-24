using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WFA_OOPIntro
{
    class Ayakkabi
    {
        //Bir ayakkabının ......'sı olur.

        //Numara
        //Renk
        //TabanCesit
        //Tip
        //Marka
        //Malzeme
        //Fiyat

       //Field: C#'ta alanlar(fields), bir sınıf veya bir sınıfın örneği ile ilişkilendirilmiş değişkenlerdir. Varsayılanda private olarak tanımlanır.

            //Access Modifiers (Erişim Belirleyiciler)
                /*
                    private => private olarak tanımlanan bir yapı sadec e tanımlandığı yerden ulaşılır. 
                    public=> public olarak tanımlanan bir yapı heryerden erişilebilir.
                    internal=> internal olarak tanımlanan bir yapı sadece bağlı bulunduğu projede istenilen yerden kullanılır.
                    ---------------------------------------
                    protected=> sadece miras alınan class içerisinden ulaşılır.
                    protected internal=> sadece bağlı bulunduğu ve miras alınan classlardan ulaşılır.

             */

       public int numara;
       internal string renk;//sadece WFA_OOPIntro isimli projede çağırılabilir.
       public string tabanCesit;
       public string tip;
       public string marka;
       public string malzeme;
       public decimal fiyat;


    }
}
