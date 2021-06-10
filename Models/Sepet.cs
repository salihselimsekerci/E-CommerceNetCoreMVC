using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Sepet
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public int KullaniciId { get; set; }
        public bool Siparis { get; set; }
        public bool Aktif { get; set; }
        public int Adet { get; set; }
        public int? SiparisId { get; set; }

    }
}
