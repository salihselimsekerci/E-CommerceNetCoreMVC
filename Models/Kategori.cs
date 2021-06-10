using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Kategori     //Kategori tablosu
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public bool Durum { get; set; } //aktif-pasif
    }
}
