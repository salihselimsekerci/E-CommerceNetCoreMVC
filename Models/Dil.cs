using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Dil
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public string Hesap { get; set; }
        public string UrunListesi { get; set; }
        public string Sepetim { get; set; }
        public string Iletisim { get; set; }
        public string Kategoriler { get; set; }
        public string GirisYap { get; set; }
        public string CikisYap { get; set; }

        public string Iade { get; set; }
        public string UcretsizKargo { get; set; }
        public string GuvenliAlisveris { get; set; }
        public string YeniUrunler { get; set; }


        public string EnCokSatan { get; set; }
        public string EnCokGoruntulenen { get; set; }
        public string EnYeni { get; set; }


    }
}
