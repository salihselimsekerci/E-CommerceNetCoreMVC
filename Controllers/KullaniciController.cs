using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore.Data;
using Microsoft.EntityFrameworkCore;
using NetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCore.Controllers
{

    public class KullaniciController : Controller
    {
        private readonly NetCoreDbContext db; //dbcontext olustur
        public KullaniciController(NetCoreDbContext dbx)
        {
            db = dbx; //icini doldur
        }

        public ActionResult DilSecim(int? kid, int? kurid, IFormCollection gelen)
        {
            int? dilid = Convert.ToInt32(gelen["Adi"]);

            if (kid != null && dilid != null && kurid != null)
                  return RedirectToAction("Anasayfa", "Kullanici", new { kid = kid, dilid = dilid, kurid = kurid });
            if (kid != null && dilid != null)
                 return RedirectToAction("Anasayfa", "Kullanici", new { kid = kid, dilid = dilid });
            if (dilid != null && kurid != null)
                 return RedirectToAction("Anasayfa", "Kullanici", new { dilid = dilid, kurid = kurid });
            if (dilid != null)
                return RedirectToAction("Anasayfa", "Kullanici", new { dilid = dilid });
            else
                return RedirectToAction("Anasayfa", "Kullanici");

        }

        public ActionResult KurSecim(int? kid, int? dilid, IFormCollection gelen)
        {
            int? kurid = Convert.ToInt32(gelen["Birim"]);

            if (kid != null && dilid != null && kurid != null)
                return RedirectToAction("Anasayfa", "Kullanici", new { kid = kid, dilid = dilid, kurid = kurid });
            if (kid != null && kurid != null)
                return RedirectToAction("Anasayfa", "Kullanici", new { kid = kid, kurid = kurid });
            if (dilid != null && kurid != null)
                return RedirectToAction("Anasayfa", "Kullanici", new { dilid = dilid, kurid = kurid });
            if (kurid != null)
                return RedirectToAction("Anasayfa", "Kullanici", new { kurid = kurid });
            else
                return RedirectToAction("Anasayfa", "Kullanici");
        }


        public ActionResult Anasayfa(int? kid,  int? dilid, int? kurid)
        {
            if(dilid != null) 
            {
                ViewBag.Dil = db.Dil.Find(dilid);
            }

            if (kurid != null)
            {
                ViewBag.Kur = db.Kur.Find(kurid);
            }

            ViewBag.Kursecim = new SelectList(db.Kur.ToList(), "Id", "Adi");
            ViewBag.Dilsecim = new SelectList(db.Dil.ToList(), "Id", "Adi");

            ViewBag.Kid = kid;
            ViewBag.Fiyat = db.Fiyat.ToList();
            ViewBag.Slide = db.Slide.ToList();

            if (db.Site.Any() == true)
            {
                ViewBag.Site = db.Site.First();
            }
            else
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
                };
                db.Site.Add(S);
                db.SaveChanges();
                ViewBag.Site = db.Site.First();
            }



            if (kid != null) {  //Kullanici Rol kontrol 
                ViewBag.Sepet = db.Sepet.Where(x => x.KullaniciId == kid && x.Aktif == true).Count();

            if (db.Rol.Find(db.Kullanici.Find(kid).RolID).RolAdi == "Admin")
                ViewBag.Admin = 1;
            else
                ViewBag.Admin = 0;
            }

            if (db.Urun.Count() > 2) {
                ViewBag.YeniUrunler = db.Urun.ToList().TakeLast(3);

                if (db.Urun.Where(x => x.EnCokGoruntulenen == true).Count() >= 2)
                    ViewBag.EnCokGoruntulenen = db.Urun.Where(x => x.EnCokGoruntulenen == true).ToList().TakeLast(2);
                else
                    ViewBag.EnCokGoruntulenen = null;

                if (db.Urun.Where(x => x.EnCokSatan == true).Count() >= 2)
                    ViewBag.EnCokSatan = db.Urun.Where(x => x.EnCokSatan == true).ToList().TakeLast(2);
                else
                    ViewBag.EnCokSatan = null;

                if (db.Urun.Where(x => x.YeniUrun == true).Count() >= 2)
                    ViewBag.EnYeni = db.Urun.Where(x => x.YeniUrun == true).ToList().TakeLast(2);
                else
                    ViewBag.YeniUrun = null;
            }
            else
            { 
                ViewBag.YeniUrunler = null;
                ViewBag.EnCokGoruntulenen = null;
                ViewBag.EnCokSatan = null;
                ViewBag.YeniUrun = null;
            }

            if(db.Marka.Count() > 0)
                ViewBag.Marka = db.Marka.ToList();
            else
                ViewBag.Marka = null;

            return View();
        }



        public ActionResult Giris()
        {
            return View();
        }



        [HttpPost]
        public ActionResult DbYenile()
        { 
            DbInitializer.Initialize(db, 0); 
            return RedirectToAction("Giris", "Kullanici");
        }

        [HttpPost]
        public ActionResult Giris(IFormCollection gelen)
        {
            string kullaniciAdi = gelen["kullaniciAdi"].ToString(); 
            string sifre = gelen["sifre"].ToString(); /* gelen veriyi string'lere yaz*/

            if (kullaniciAdi != null && sifre != null) /* bos degilse*/
            { 
               var kullanici = db.Kullanici.Where(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre).FirstOrDefault(); //giris yapan kullaniciyi bul
                if (kullanici != null)  //kullanıcı doğru ise
                { //giris basarili
                    var rol = db.Rol.Where(x => kullanici.RolID == x.Id).FirstOrDefault();  //rol'unu bul

                    if (rol.RolAdi == "Admin") //Kullanici Admin ise
                        return RedirectToAction("Panel", "Kullanici", new { kid = kullanici.Id });  //Admin panele gönder
                    else
                        return RedirectToAction("Anasayfa", "Kullanici", new { kid = kullanici.Id }); //KullaniciUrunListele'ye gönder
                }
            }
            else { //Giris basarisiz
                if (sifre != null)  //kullaniciAdi bos
                    System.Diagnostics.Debug.WriteLine("Kullanici Adi Bos");
                else  //sifre bos 
                    System.Diagnostics.Debug.WriteLine("Sifre Bos");
            }
            return View();
        }

     
        public ActionResult Panel(int? kid)
        {
            if(kid != null)
            {
                ViewBag.admin = db.Kullanici.Find(kid).KullaniciAdi;
                ViewBag.Kullanici = db.Kullanici.Count();
                ViewBag.Urun = db.Urun.Count();
                ViewBag.Kat = db.Kategori.Count();
                return View();
            }

            return RedirectToAction("Giris", "Kullanici");
        }

        #region   /*----------------------Kullanci islemleri------------------------------------------*/

        public ActionResult ProfilSayfasi(int kid)
        {
            ViewBag.Site = db.Site.First();
            ViewBag.Gelen = db.Kullanici.Find(kid); //kullaniciyi bul

            return View();
        }


        public ActionResult SifreUnuttum()
        {
            ViewBag.Site = db.Site.First();
            return View();
        }


        [HttpPost]
        public ActionResult SifreUnuttum(IFormCollection gelen)
        {
            ViewBag.Site = db.Site.First();
            string gkullaniciAdi = gelen["kullaniciAdi"].ToString();

            Kullanici k = db.Kullanici.Where(x=> x.KullaniciAdi == gkullaniciAdi).FirstOrDefault(); //kullaniciyi bul
            k.sifreBekliyor = true; //sifre bekliyor durumunu true yap
            db.SaveChanges();
            return RedirectToAction("Giris", "Kullanici");
        }

        public ActionResult SifreGonder(int id)
        {
           Kullanici k = db.Kullanici.Find(id); //kullaniciyi bul
            k.sifreBekliyor = false; //sifre bekliyor durumunu false yap
            db.SaveChanges();
            return RedirectToAction("KullaniciListele", "Kullanici");
        }




        public ActionResult KullaniciListele()
        {
            var model = db.Kullanici.ToList(); //kullanici listesi olustur
            return View(model); //view'e gönder
        }
        
        public ActionResult Ekle(int admin)
        {
            ViewBag.Site = db.Site.First();
            ViewBag.Admin = admin;
            ViewBag.Rol = new SelectList(db.Rol.ToList(), "Id", "RolAdi"); //Rol'leri listele ve viewbag'e ekle
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(IFormCollection gelen, int admin)
        {
            ViewBag.Site = db.Site.First();
            string gkullaniciAdi = gelen["kullaniciAdi"].ToString();
            string gsifre = gelen["sifre"].ToString();  /* gelen veriyi string'lere yaz*/
            string email = gelen["kullaniciemail"].ToString();
            string isim = gelen["kullaniciisim"].ToString();
            string soyisim = gelen["kullanicisoyisim"].ToString();
            string adres = gelen["kullaniciadres"].ToString();
            string resimUrl = gelen["kullaniciresimUrl"].ToString();


            int rolId;

            if (admin != 1)
            {
                rolId = db.Rol.Where(x => x.RolAdi == "Kullanici").FirstOrDefault().Id;
            }
            else
            {
                rolId = Convert.ToInt32(gelen["Rol"]);
            }

            if (gkullaniciAdi != null && gsifre != null) //bos değilse
            {
                Kullanici x = new Kullanici() //yeni kullanici olustur
                {
                    KullaniciAdi = gkullaniciAdi,
                    RolID = rolId,
                    email = email,
                    sifreBekliyor = false,
                    Adres = adres,
                    Isim = isim,
                    Soyisim = soyisim,
                    ResimUrl = resimUrl,
                    Sifre = gsifre

                };
                db.Kullanici.Add(x); //kullaniciyi ekle
                db.SaveChanges(); //veritabanına değişikliği kaydet

                if (admin != 1)
                {
                    return RedirectToAction("Giris", "Kullanici");  
                }
                else
                {
                    return RedirectToAction("KullaniciListele", "Kullanici");  //kullanicilistele'ye gönder
                }
                
            }
            else{
            //hata
            }
                return View();
        }

         
        public ActionResult Duzenle(int id, int admin)
        {
            ViewBag.Site = db.Site.First();
            ViewBag.Admin = admin;
          ViewBag.gelen = db.Kullanici.Find(id); // id'den kullaniciyi bulup, viewbag'e ekle
          ViewBag.Rol = new SelectList(db.Rol.ToList(), "Id", "RolAdi");


            return View();
        }

        [HttpPost]
        public ActionResult Duzenle(IFormCollection gelen, int id, int admin)
        {
            ViewBag.Site = db.Site.First();
            string ykullaniciAdi = gelen["kullaniciAdi"].ToString();
            string ysifre = gelen["sifre"].ToString();  /*gelen veriyi string'lere yaz*/
            string email = gelen["kullaniciemail"].ToString();
            string isim = gelen["kullaniciisim"].ToString();
            string soyisim = gelen["kullanicisoyisim"].ToString();
            string adres = gelen["kullaniciadres"].ToString();
            string resimUrl = gelen["kullaniciresimUrl"].ToString();

            int rolId;

            if (admin != 1) {
                rolId = db.Rol.Where(x=> x.RolAdi == "Kullanici").FirstOrDefault().Id;
            }
            else {
                rolId = Convert.ToInt32(gelen["Rol"]);
            }
            if (ykullaniciAdi != null && ysifre != null) /*bos değilse*/
            {
                Kullanici gelenk = db.Kullanici.Find(id); //kullaniciyi bul

                gelenk.KullaniciAdi = ykullaniciAdi; //
                gelenk.RolID = rolId;
                gelenk.email = email;
                gelenk.Sifre = ysifre; 
                gelenk.Isim = isim;
                gelenk.Soyisim = soyisim;
                gelenk.ResimUrl = resimUrl;
                gelenk.Adres = adres; //gelen veri ile veritabanındaki veriyi güncelle

                db.SaveChanges(); //veritabanına değişikliği kaydet

                if (admin == 1) { 
                return RedirectToAction("KullaniciListele", "Kullanici");  //kullanicilistele'ye gönder
                }
                else
                {
                    return RedirectToAction("KullaniciUrunListele", "Urun", new { kid = id });
                }
            }
            else {
                //hata
            }
            return View();
        }

        public ActionResult Sil(int id)
        {
            db.Kullanici.Remove(db.Kullanici.Find(id)); //kullaniciyi bul ve sil
            db.SaveChanges(); //veritabanına değişikliği kaydet
            return RedirectToAction("KullaniciListele", "Kullanici"); //kullanicilistele'ye gönder
        }

        public ActionResult Detay(int id)
        {
            ViewBag.gelen = db.Kullanici.Find(id); //kullaniciyi bul
            return View(); 
        }

        #endregion


        public ActionResult AboneEkle(int? kid, IFormCollection Abo)
        {
            string _mail = Abo["Email"].ToString();
            Abone A = new Abone();
            A.email = _mail;
            db.Abone.Add(A);
            db.SaveChanges();


          if(kid != null)
                return RedirectToAction("Anasayfa", "Kullanici", new { kid = kid });
          else
                return RedirectToAction("Anasayfa", "Kullanici");
        }


        public ActionResult AboneListele()
        {
            var model = db.Abone.ToList();
            return View(model);
        }


    }
}