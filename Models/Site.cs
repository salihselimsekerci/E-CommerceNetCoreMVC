using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        public string Eposta { get; set; }
        public string LogoUrl { get; set; }


        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }

        public bool Twitter { get; set; }
        public bool Facebook { get; set; }
        public bool Instagram { get; set; }


    }
}
