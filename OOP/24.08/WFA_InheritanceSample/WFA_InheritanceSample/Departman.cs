using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_InheritanceSample
{
    public class Departman:Base
    {
        //public string Ad { get; set; }
        public int PersonelSayisi { get; set; }

        public string DepartmanSorumlusu { get; set; }
        public int DemirbasSayisi { get; set; }

    }
}
