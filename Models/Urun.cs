using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Urun     //Urun tablosu
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public int Adet { get; set; }
        public string ResimUrl { get; set; }
        public int? MarkaId { get; set; }
        public int KategoriId { get; set; }
        public int FiyatId { get; set; }
        public string OzellikBaslik1 { get; set; }
        public string OzellikAciklama1 { get; set; }
        public string OzellikBaslik2 { get; set; }
        public string OzellikAciklama2 { get; set; }
        public string OzellikBaslik3 { get; set; }
        public string OzellikAciklama3 { get; set; }

        public bool? YeniUrun { get; set; }
        public bool? EnCokSatan { get; set; }
        public bool? EnCokGoruntulenen { get; set; }
        public bool? GelecekUrun { get; set; }

    }
}
