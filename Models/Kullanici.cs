using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{

    //Kullanici tablosu
    public class Kullanici 
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int RolID { get; set; }
        public string email { get; set; }
        public bool? sifreBekliyor { get; set; }

        public string ResimUrl { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Adres { get; set; }

    }
}
