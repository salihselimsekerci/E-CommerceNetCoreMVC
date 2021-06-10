using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Mesaj
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Email { get; set; }
        public string FirmaIsmi { get; set; }
        public string Konu { get; set; }

    }
}
