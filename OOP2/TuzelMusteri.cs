using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Tüzel > Coorporate
    //TuzelMusteri:Musteri bu olaya miras > inheritance: musterinin içindeki tüm özellikler tüzeldede var kabul edilir.

    internal class TuzelMusteri:Musteri
    {
        

        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }
    }
}
