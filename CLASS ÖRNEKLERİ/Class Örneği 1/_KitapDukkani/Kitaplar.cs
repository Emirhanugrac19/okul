using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _KitapDukkani
{
    class Kitaplar
    {
        public string KitapAdi { get; set; }
        public string KitapTuru { get; set; }
        public int SayfaSayisi { get; set; }
        public decimal Fiyat { get; set; }
        public Yazarlar yazar { get; set; }
    }
}
