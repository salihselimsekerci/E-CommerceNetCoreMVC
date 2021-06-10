using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Siparis
    {
        public int id { get; set; }
        public int KullaniciId { get; set; }
        public decimal ToplamFiyat { get; set; }

        public bool Onaylandi { get; set; }
        public bool Aktif { get; set; }

        public string KuponKodu { get; set; }
        public string OdemeTipi { get; set; }
        public bool KrediKarti { get; set; }
        public bool Havale { get; set; }

        public string Ulke { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string FirmaIsmi { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

    }
}
