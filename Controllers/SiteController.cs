using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore.Data;
using NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class SiteController : Controller
    {

        private readonly NetCoreDbContext db; //dbcontext olustur
        public SiteController(NetCoreDbContext dbx)
        {
            db = dbx; //icini doldur
        }


        public ActionResult SiteAyar()
        {
          if(db.Site.Any() == true) //eger veritabaninda var ise
            {
                ViewBag.Site = db.Site.First(); //ilk veriyi al
            } 
            else //yok ise
            {
                Site S = new Site() 
                {
                    Adres = "",
                    Eposta = "",
                    Telefon = "",
                    Faks = "",
                    LogoUrl = "https://via.placeholder.com/200",

                    FacebookUrl = "https://via.placeholder.com/20",
                    TwitterUrl = "https://via.placeholder.com/20",
                    InstagramUrl = "https://via.placeholder.com/20",
                    Facebook = false,
                    Twitter = false,
                    Instagram = false
                }; //olustur
                db.Site.Add(S); //veritabanina ekle
                db.SaveChanges(); //kaydet
                ViewBag.Site = db.Site.First(); //ilk veriyi al
            }

            return View();
        }

        [HttpPost]
        public ActionResult SiteAyar(IFormCollection Sa)
        {
           
            string _Adres = Sa["Adres"].ToString();
            string _Eposta = Sa["Eposta"].ToString();
            string _Telefon = Sa["Telefon"].ToString();
            string _Faks = Sa["Faks"].ToString();
            string _LogoUrl = Sa["LogoUrl"].ToString();
            string _FacebookUrl = Sa["FacebookUrl"].ToString();
            string _TwitterUrl = Sa["TwitterUrl"].ToString();
            string _InstagramUrl = Sa["InstagramUrl"].ToString();

            string _Facebook = Sa["Facebook"].ToString();
            string _Twitter = Sa["Twitter"].ToString();
            string _Instagram = Sa["Instagram"].ToString(); //gelen veriyi al

            Site S = db.Site.First(); //veritabanindaki ilk veriyi getir
            S.Adres = _Adres;
            S.Eposta = _Eposta;
            S.Telefon = _Telefon;
            S.Faks = _Faks;
            S.LogoUrl = _LogoUrl;
            S.FacebookUrl = _FacebookUrl;
            S.TwitterUrl = _TwitterUrl;
            S.InstagramUrl = _InstagramUrl;

            if (_Facebook == "on")
                S.Facebook = true;
            else
                S.Facebook = false;

            if (_Twitter == "on")
                S.Twitter = true;
            else
                S.Twitter = false;

            if (_Instagram == "on")
                S.Instagram = true;
            else
                S.Instagram = false; //degisiklikleri icine yaz
            


            db.SaveChanges(); //kaydet

            ViewBag.Site = db.Site.First(); //ilk veriyi viewbag'e ekle
            return View();
        }





        public ActionResult SlideListele()
        {
          List<Slide> model =  db.Slide.ToList(); //slide'ları getir, slide listesinin icine yaz

            return View(model);
        }


        public ActionResult SlideEkle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SlideEkle(IFormCollection Sli)
        {
            string Url = Sli["ResimUrl"].ToString();

            Slide S = new Slide(); //yeni slide olustur
            S.ResimUrl = Url;
            db.Slide.Add(S);//veritabanina ekle
            db.SaveChanges(); //degisikligi kaydet

            return View();
        }


        public ActionResult SlideSil(int id)
        {
            db.Slide.Remove(db.Slide.Find(id)); //slide'i bul ve sil
            db.SaveChanges(); //degisikligi kaydet 

            return RedirectToAction("SlideListele", "Site"); //slide listesine geri don
        }



        public ActionResult Iletisim(int? kid)
        {
            ViewBag.Site = db.Site.First();  //veritabanindaki ilk site objesini  viewbag'e ekle

            if (kid != null) //kullanici giris yapmis ise
                ViewBag.Kid = kid; //kullanici id = giris yapan id
          

            return View();
        }


        [HttpPost]
        public ActionResult Iletisim(IFormCollection ile)
        {
           

            if (db.Site.Any() == true) //veritabaninda site objesi var ise
            {
                ViewBag.Site = db.Site.First(); //veritabanindaki ilk site objesini  viewbag'e ekle
            }

            string _email = ile["email"].ToString();
            string _firmaIsmi = ile["firmaIsmi"].ToString();
            string _isim = ile["isim"].ToString();
            string _konu = ile["konu"].ToString();

            Mesaj M = new Mesaj()  //yeni mesaj olustur
            {
                Email = _email,
                FirmaIsmi = _firmaIsmi,
                Isim = _isim,
                Konu = _konu //form'dan gelen verileri yaz
            };

            db.Mesaj.Add(M); //veritabanina ekle
            db.SaveChanges();   //degisikligi kaydet 

            return View();
        }



        public ActionResult MesajListele()
        {
            var model = db.Mesaj.ToList();

            return View(model);
        }




        public ActionResult DilListele()
        {
            var model = db.Dil.ToList();
            return View(model);
        }

        public ActionResult DilEkle()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult DilEkle(IFormCollection gdil)
        {
            Dil Ydil = new Dil()
            {
                Adi = gdil["Adi"].ToString(),
                Hesap = gdil["Hesap"].ToString(),
                UrunListesi = gdil["UrunListesi"].ToString(),
                Sepetim = gdil["Sepetim"].ToString(),
                Iletisim = gdil["Iletisim"].ToString(),
                Kategoriler = gdil["Kategoriler"].ToString(),
                GirisYap = gdil["GirisYap"].ToString(),
                CikisYap = gdil["CikisYap"].ToString(),
                Iade = gdil["Iade"].ToString(),
                UcretsizKargo = gdil["UcretsizKargo"].ToString(),
                GuvenliAlisveris = gdil["GuvenliAlisveris"].ToString(),
                YeniUrunler = gdil["YeniUrunler"].ToString(),
                EnCokSatan = gdil["EnCokSatan"].ToString(),
                EnCokGoruntulenen = gdil["EnCokGoruntulenen"].ToString(),
                EnYeni = gdil["EnYeni"].ToString() //formdan gelen verilerle dil objesi olustur
            };

            db.Dil.Add(Ydil); //veritabanina ekle
            db.SaveChanges();  //degisikligi kaydet 
            return RedirectToAction("DilListele", "Site"); //dil listesine don
        }



        public ActionResult DilSil(int id)
        {
            db.Dil.Remove(db.Dil.Find(id));
            db.SaveChanges();
            return RedirectToAction("DilListele", "Site");
        }

        public ActionResult DilDuzenle(int id)
        {
            ViewBag.Gelen = db.Dil.Find(id);

            return View();
        }

      [HttpPost]
        public ActionResult DilDuzenle(int id, IFormCollection gdil)
        {
          Dil gelen = db.Dil.Find(id);
            gelen.Adi = gdil["Adi"].ToString();
            gelen.Hesap = gdil["Hesap"].ToString();
            gelen.UrunListesi = gdil["UrunListesi"].ToString();
            gelen.Sepetim = gdil["Sepetim"].ToString();
            gelen.Iletisim = gdil["Iletisim"].ToString();
            gelen.Kategoriler = gdil["Kategoriler"].ToString();
            gelen.GirisYap = gdil["GirisYap"].ToString();
            gelen.CikisYap = gdil["CikisYap"].ToString();
            gelen.Iade = gdil["Iade"].ToString();
            gelen.UcretsizKargo = gdil["UcretsizKargo"].ToString();
            gelen.GuvenliAlisveris = gdil["GuvenliAlisveris"].ToString();
            gelen.YeniUrunler = gdil["YeniUrunler"].ToString();
            gelen.EnCokSatan = gdil["EnCokSatan"].ToString();
            gelen.EnCokGoruntulenen = gdil["EnCokGoruntulenen"].ToString();
            gelen.EnYeni = gdil["EnYeni"].ToString();
            db.SaveChanges();
            return RedirectToAction("DilListele", "Site");
        }




        public ActionResult KurListele()
        {
            var model = db.Kur.ToList();
            return View(model);
            
        }

        public ActionResult KurEkle()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult KurEkle(IFormCollection gkur)
        {
            Kur Y = new Kur()
            {
                Adi = gkur["Adi"].ToString(),
                Birim = gkur["Birim"].ToString()
            };
            db.Kur.Add(Y);
            db.SaveChanges();
            return RedirectToAction("KurListele", "Site");
        }


        public ActionResult KurSil(int id)
        {
            db.Kur.Remove(db.Kur.Find(id));
            db.SaveChanges();
            return RedirectToAction("KurListele", "Site");
        }

    }
}
