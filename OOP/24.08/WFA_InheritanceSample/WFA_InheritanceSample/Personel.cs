using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_InheritanceSample
{
    public class Personel:Base
    {
        //public string Ad { get; set; }
        public string Soyad { get; set; }
        public Departman Departman { get; set; }
    }
}
