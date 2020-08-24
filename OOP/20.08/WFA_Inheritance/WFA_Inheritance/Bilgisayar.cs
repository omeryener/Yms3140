using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Inheritance
{
    public class Bilgisayar:Urun
    {
        public string IslemciMarka { get; set; }
        public Anakart AnaKart { get; set; }
        public EkranKarti EkranKarti { get; set; }

    }
}
