using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NetCore.Data;
using NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    public class UrunController : Controller
    {
        private readonly NetCoreDbContext db; //dbcontext olustur
        public UrunController(NetCoreDbContext dbx)
        {
            db = dbx; //icini doldur
        }


        public ActionResult KategorilerYeni(int? Kid, int? katid)
        {
            if (db.Urun.Count() > 2)
            {
                if(katid == null)
                { 
                ViewBag.YeniUrunler = db.Urun.ToList().TakeLast(3);

                if (db.Urun.Where(x => x.GelecekUrun == true).Count() >= 2)
                    ViewBag.GelecekUrun = db.Urun.Where(x => x.GelecekUrun == true).ToList();
                else
                    ViewBag.GelecekUrun = null;
                }
                else
                {
                    ViewBag.YeniUrunler = db.Urun.Where(x=> x.KategoriId == katid).ToList().TakeLast(3);

                    if (db.Urun.Where(x => x.KategoriId == katid && x.GelecekUrun == true).Count() >= 2)
                        ViewBag.GelecekUrun = db.Urun.Where(x =>  x.KategoriId == katid &&  x.GelecekUrun == true).ToList();
                    else
                        ViewBag.GelecekUrun = null;
                }
            }
            else
            {
                ViewBag.YeniUrunler = null;
                ViewBag.GelecekUrun = null;
            }


            ViewBag.Kategoriler = db.Kategori.ToList();
            ViewBag.Slide = db.Slide.ToList();
            ViewBag.Site = db.Site.First();
            ViewBag.Kid = Kid;
            ViewBag.Fiyat = db.Fiyat.ToList();

            return View();
        }

            public ActionResult KatUrunListele(IFormCollection gelen)
        {
            ViewBag.Site = db.Site.First();
            ViewBag.Kat = new SelectList(db.Kategori.ToList(), "Id", "KategoriAdi");
            ViewBag.Alis = new SelectList(db.Fiyat.ToList(), "Id", "Alis");
            ViewBag.Satis = new SelectList(db.Fiyat.ToList(), "Id", "Satis");
            ViewBag.Marka = new SelectList(db.Marka.ToList(), "Id", "MarkaAdi"); //kategori-alis-satis-marka adi'ni listele viewbaglere doldur
            ViewBag.admin = 1; //admin
            ViewBag.Kat2 = db.Kategori.ToList();
            int katid = Convert.ToInt32(gelen["Kategori"]); //gelen verileri degiskenlere yaz
            ViewBag.Urunler = db.Urun.Where(x => x.KategoriId == katid).ToList(); //secilen kategorideki urunleri listele, bu listeyi viewbag'in icine yaz
            return View();
        }
        public ActionResult KullaniciUrunListele(int kid, int? katid,  int? secim) //kullanicilar icin urun listesi
        {
            ViewBag.Site = db.Site.First();
            ViewBag.Sepet = db.Sepet.Where(x => x.KullaniciId == kid && x.Aktif == true).Count(); //sepet sayisi
            ViewBag.kullanici = kid; //kullanici id
            ViewBag.Kat = new SelectList(db.Kategori.ToList(), "Id", "KategoriAdi");
            ViewBag.Alis = new SelectList(db.Fiyat.ToList(), "Id", "Alis");
            ViewBag.Satis = new SelectList(db.Fiyat.ToList(), "Id", "Satis");
            ViewBag.Marka = new SelectList(db.Marka.ToList(), "Id", "MarkaAdi"); //kategori-alis-satis-marka adi'ni listele viewbaglere doldur
            ViewBag.admin = 0; //kullanici

            if (katid != null)
            {
                ViewBag.Urunler = db.Urun.Where(x => x.KategoriId == katid).ToList();
            }
           else if(secim != null && secim == 1)
            {
                ViewBag.Urunler = db.Urun.Where(x => x.EnCokSatan == true).ToList();
            }
           else if (secim != null && secim == 2)
            {
                ViewBag.Urunler = db.Urun.Where(x => x.EnCokGoruntulenen == true).ToList();
            }
            else if (secim != null && secim == 3)
            {
                ViewBag.Urunler = db.Urun.Where(x => x.YeniUrun == true).ToList();
            }
            else
                {
                    ViewBag.Urunler = db.Urun.ToList();  //Urunler viewbag'ine tum urunleri liste olarak yaz
                }

            ViewBag.Kat2 = db.Kategori.ToList();
            return View("~/Views/Urun/KatUrunListele.cshtml"); //KatUrunListele' view'ine gonder
        }

        [HttpPost]
        public ActionResult KullaniciUrunListele(int kid, IFormCollection gelen) //kullanicilar icin urun listesi (kategori'ye gore sirala)
        {
            ViewBag.Site = db.Site.First();
            ViewBag.Sepet = db.Sepet.Where(x => x.KullaniciId == kid && x.Aktif == true).Count(); //sepet sayisi
            ViewBag.kullanici = kid;  //kullanici id
            ViewBag.Kat = new SelectList(db.Kategori.ToList(), "Id", "KategoriAdi");
            ViewBag.Alis = new SelectList(db.Fiyat.ToList(), "Id", "Alis");
            ViewBag.Satis = new SelectList(db.Fiyat.ToList(), "Id", "Satis");
            ViewBag.Marka = new SelectList(db.Marka.ToList(), "Id", "MarkaAdi"); //kategori-alis-satis-marka adi'ni listele viewbaglere doldur
            ViewBag.admin = 0; //kullanici
            ViewBag.Kat2 = db.Kategori.ToList();
            int katid = Convert.ToInt32(gelen["Kategori"]); //gelen verileri degiskenlere yaz
            ViewBag.Urunler = db.Urun.Where(x => x.KategoriId == katid).ToList(); //secilen kategorideki urunleri listele, bu listeyi viewbag'in icine yaz
            return View("~/Views/Urun/KatUrunListele.cshtml"); //KatUrunListele' view'ine gonder
        }
        public ActionResult UrunDetay(int uid, int kullanici, int? kid)
        {
            ViewBag.Site = db.Site.First();
            Urun gelen = db.Urun.Find(uid); //id'sinden urunu bul
            ViewBag.kat = db.Kategori.Find(gelen.KategoriId);//urun'un kategoriID'si ile eslesen kategoriyi bul
            ViewBag.Fiyat = db.Fiyat.Find(gelen.FiyatId); //urun'un fiyatID'si ile eslesen fiyat'i bul
            ViewBag.Marka = db.Marka.Find(gelen.MarkaId); //urun'un markaID'si ile eslesen markayi bul
            ViewBag.admin = kullanici;
            ViewBag.gelen = gelen;
            ViewBag.kullanici = kid;
            return View();
        }

        #region  /*----------------------------------------------------Ürün Islemleri-------------------------------------------------------------------------------*/
        public ActionResult UrunListele()
        {
            var model = db.Urun.ToList(); //urun listesi olustur, model'e yaz
            ViewBag.Kat = new SelectList(db.Kategori.ToList(), "Id", "KategoriAdi");
            ViewBag.Alis = new SelectList(db.Fiyat.ToList(), "Id","Alis");
            ViewBag.Satis = new SelectList(db.Fiyat.ToList(), "Id", "Satis");
            ViewBag.Marka = new SelectList(db.Marka.ToList(), "Id", "MarkaAdi"); //kategori-alis-satis-marka listelerini viewbag'e ekleyip gonder
            return View(model); //modeli view'e gönder
        }
        public ActionResult UrunEkle()
        {
            ViewBag.Kat = new SelectList(db.Kategori.ToList(), "Id", "KategoriAdi");
            ViewBag.Marka = new SelectList(db.Marka.ToList(), "Id", "MarkaAdi"); //kategori ve marka listelerini viewbag'e ekleyip gonder
            return View();
        }

        [HttpPost]
        public ActionResult UrunEkle(IFormCollection urun)
        {
            string urunAdi = urun["urunAdi"].ToString();
            string urunAciklama = urun["urunAciklama"].ToString();
            int urunAdet = Convert.ToInt32(urun["urunAdet"]);
            string fiyatAlis = urun["fiyatAlis"].ToString();
            string fiyatSatis = urun["fiyatSatis"].ToString();
            string resimUrl = urun["resimUrl"].ToString();
            string _EnCokSatan = urun["EnCokSatan"].ToString();
            string _EnCokGoruntulenen = urun["EnCokGoruntulenen"].ToString();
            string _GelecekUrun = urun["GelecekUrun"].ToString();


            int katid = Convert.ToInt32(urun["Kategori"]);
            int markaid = Convert.ToInt32(urun["Marka"]); //gelen verileri degiskenlere yaz




            if (urunAdi != null && fiyatAlis != null && fiyatSatis != null) //urun adi ve fiyatlar bos değilse
            {
                Fiyat f = new Fiyat() //yeni Fiyat olustur
            {
                Alis = fiyatAlis,
                Satis = fiyatSatis
            };

              
              

                db.Fiyat.Add(f);
            db.SaveChanges();

                Urun x = new Urun() //yeni urun olustur
                {
                    UrunAdi = urunAdi,
                    Aciklama = urunAciklama,
                    Adet = urunAdet,
                    FiyatId = db.Fiyat.Where(x => x.Alis == f.Alis && x.Satis == f.Satis).FirstOrDefault().Id,
                    MarkaId = markaid, 
                    ResimUrl = resimUrl,
                    KategoriId = katid,
                    OzellikBaslik1 = urun["OzellikBaslik1".ToString()],
                    OzellikAciklama1 = urun["OzellikAciklama1".ToString()],
                    OzellikBaslik2 = urun["OzellikBaslik2".ToString()],
                    OzellikAciklama2 = urun["OzellikAciklama2".ToString()],
                    OzellikBaslik3 = urun["OzellikBaslik3".ToString()],
                    OzellikAciklama3 = urun["OzellikAciklama3".ToString()]
                };

                if (_GelecekUrun == "on")
                    x.GelecekUrun = true;
                else
                    x.GelecekUrun = false;
                if (_EnCokGoruntulenen == "on")
                    x.EnCokGoruntulenen = true;
                else
                    x.EnCokGoruntulenen = false;
                if (_EnCokSatan == "on")
                    x.EnCokSatan = true;
                else
                    x.EnCokSatan = false;

                            db.Urun.Add(x); //urunu ekle
                db.SaveChanges(); //veritabanına değişikliği kaydet
                return RedirectToAction("UrunListele", "Urun");  //urunlistele'ye gönder
            }
            else
            {
                //hata
            }
            return View();
        }

        public ActionResult UrunDuzenle(int id)
        {
            Urun gelen = db.Urun.Find(id); //id'den urunu bulup
            ViewBag.gelen = gelen; // viewbag'e ekle
            ViewBag.Fiyat = db.Fiyat.Find(gelen.FiyatId); //urunun fiyatIdsi ile eslesen fiyati'i bul -- viewbag'e ekle
            ViewBag.Marka = new SelectList(db.Marka.ToList(), "Id", "MarkaAdi"); //markalari listele -- viewbag'e ekle
            ViewBag.Kat = new SelectList(db.Kategori.ToList(), "Id", "KategoriAdi"); //kategorileri listele -- viewbag'e ekle
            return View();
        }

        [HttpPost]
        public ActionResult UrunDuzenle(IFormCollection urun, int id)
        {
            string urunadi = urun["urunAdi"].ToString();
            string urunAciklama = urun["urunAciklama"].ToString();
            int urunAdet = Convert.ToInt32(urun["urunAdet"]);
            string fiyatSatis = urun["satisFiyati"].ToString();
            string fiyatAlis = urun["alisFiyati"].ToString();
            string resimUrl = urun["resimUrl"].ToString();
            int markaid = Convert.ToInt32(urun["Marka"]);
            int katid = Convert.ToInt32(urun["Kategori"]);//gelen verileri degiskenlere yaz

            string _EnCokSatan = urun["EnCokSatan"].ToString();
            string _EnCokGoruntulenen = urun["EnCokGoruntulenen"].ToString();
            string _GelecekUrun = urun["GelecekUrun"].ToString();



            if (urunadi != null && fiyatAlis != null && fiyatSatis != null) /*bos değilse*/
            {
                Urun gelen = db.Urun.Find(id); //urunu bul
                gelen.UrunAdi = urunadi;
                gelen.Adet = urunAdet;
                gelen.Aciklama = urunAciklama;
                gelen.KategoriId = katid;
                gelen.MarkaId = markaid;
                gelen.ResimUrl = resimUrl;
                gelen.OzellikBaslik1 = urun["OzellikBaslik1".ToString()];
                   gelen.OzellikAciklama1 = urun["OzellikAciklama1".ToString()];
                    gelen.OzellikBaslik2 = urun["OzellikBaslik2".ToString()];
                    gelen.OzellikAciklama2 = urun["OzellikAciklama2".ToString()];
                    gelen.OzellikBaslik3 = urun["OzellikBaslik3".ToString()];
                   gelen.OzellikAciklama3 = urun["OzellikAciklama3".ToString()];

                if (_GelecekUrun == "on")
                    gelen.GelecekUrun = true;
                else
                    gelen.GelecekUrun = false;
                if (_EnCokGoruntulenen == "on")
                    gelen.EnCokGoruntulenen = true;
                else
                    gelen.EnCokGoruntulenen = false;
                if (_EnCokSatan == "on")
                    gelen.EnCokSatan = true;
                else
                    gelen.EnCokSatan = false;


                Fiyat f = db.Fiyat.Find(gelen.FiyatId);
                f.Alis = fiyatAlis;
                f.Satis = fiyatSatis;

                db.SaveChanges(); //veritabanına değişikliği kaydet
                return RedirectToAction("UrunListele", "Urun");  //urunlistele'ye gönder
            }
            else
            {
                //hata
            }
            return View();
        }


        public ActionResult UrunSil(int id)
        {
            Urun gelen = db.Urun.Find(id);  //urunu bul
            db.Fiyat.Remove(db.Fiyat.Find(gelen.FiyatId)); //fiyati bul ve sil
            db.Urun.Remove(gelen); //urunu sil
            db.SaveChanges(); //veritabanına değişikliği kaydet
            return RedirectToAction("UrunListele", "Urun"); //urunlistele'ye gönder
        }
#endregion

        #region  /*-----------------------------------------------------Kategori Islemleri-------------------------------------------------------------------------*/
        public ActionResult KategoriListele()
        {
            var model = db.Kategori.ToList(); //kategori listesi olustur
            return View(model); //view'e gönder
        }
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(IFormCollection kat)
        {
            string kategoriAdi = kat["kategoriAdi"].ToString();
            bool kategoriDurum;

            if (kat["kategoriDurum"].ToString() == "on") //checkbox secili ise
                kategoriDurum = true; //aktif
            else //degil ise
                kategoriDurum = false; //pasif

            if (kategoriAdi != null) //bos değilse
            {
                Kategori x = new Kategori() //yeni kategori olustur
                {
                    KategoriAdi = kategoriAdi,
                    Durum = kategoriDurum

                };
                db.Kategori.Add(x); //kategori ekle
                db.SaveChanges(); //veritabanına değişikliği kaydet
                return RedirectToAction("KategoriListele", "Urun");  //KategoriListele'ye gönder
            }
            else
            {
                //hata
            }
            return View();
        }

        public ActionResult KategoriDuzenle(int id)
        {
            ViewBag.gelen = db.Kategori.Find(id); // id'den kategoriyi bulup, viewbag'e ekle
            return View();
        }

        [HttpPost]
        public ActionResult KategoriDuzenle(IFormCollection kat, int id)
        {
            string katadi = kat["kategoriAdi"].ToString();
            bool kategoriDurum;

            if (kat["kategoriDurum"].ToString() == "on") //checkbox secili ise
                kategoriDurum = true; //aktif
            else //degilse
                kategoriDurum = false; //pasif

            if (katadi != null) /*bos değilse*/
            {
                Kategori gelen = db.Kategori.Find(id); //kategoriyi bul
                gelen.KategoriAdi = katadi;
                gelen.Durum = kategoriDurum;
                db.SaveChanges(); //veritabanına değişikliği kaydet
                return RedirectToAction("KategoriListele", "Urun");  //KategoriListele'ye gönder
            }
            else
            {
                //hata
            }
            return View();
        }

        public ActionResult KategoriSil(int id)
        {
            db.Kategori.Remove(db.Kategori.Find(id)); //Kategori'yi bul ve sil
            db.SaveChanges(); //veritabanına değişikliği kaydet
            return RedirectToAction("KategoriListele", "Urun"); //KategoriListele'ye gönder
        }
#endregion

        #region  /*----------------------------------------------------Marka Islemleri-------------------------------------------------------------------------------*/

        public ActionResult MarkaListele()
        {
            var model = db.Marka.ToList(); //kategori listesi olustur
            return View(model); //view'e gönder
        }

        public ActionResult MarkaEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MarkaEkle(IFormCollection mar)
        {
            string madi = mar["MarkaAdi"].ToString();
            string resimUrl = mar["ResimUrl"].ToString();

            Marka M = new Marka() { MarkaAdi = madi, ResimUrl = resimUrl };
            db.Marka.Add(M);
            db.SaveChanges();
            return RedirectToAction("MarkaListele", "Urun");
        }

        public ActionResult MarkaDuzenle(int id)
        {
            ViewBag.gelen = db.Marka.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult MarkaDuzenle(IFormCollection mar, int id)
        {
            string madi = mar["MarkaAdi"].ToString();
            string resimUrl = mar["ResimUrl"].ToString();

            Marka G = db.Marka.Find(id);
            G.MarkaAdi = madi;
            G.ResimUrl = resimUrl;
            db.SaveChanges();
            return RedirectToAction("MarkaListele", "Urun");
        }

        public ActionResult MarkaSil(int id)
        {
            db.Marka.Remove(db.Marka.Find(id));
            db.SaveChanges();
            return RedirectToAction("MarkaListele", "Urun");
        }
        #endregion

        #region  /*----------------------------------------------------Sepet Islemleri-------------------------------------------------------------------------------*/

        public ActionResult Sepet(int kid)
        {
            ViewBag.Site = db.Site.First();
            List<Urun> model = new List<Urun>(); //urun listesi olustur
            List<Urun> Urunler = db.Urun.ToList(); //db.urunleri urunler listesine ekle
            List<Sepet> S = new List<Sepet>();

            int fiyattoplam = 0;
           
            foreach (var sepet in db.Sepet) //db sepet'in icinde dön
            {
                if(sepet.KullaniciId == kid && sepet.Aktif == true && sepet.Siparis == false) //eger kullanici ID'si giris yapan kullanici ile aynı ise
                {
                    Urun u = Urunler.Where(x=> x.Id == sepet.UrunId).FirstOrDefault(); //Urun ID'si sepetteki urun ile ayni olani bul 
                    model.Add(u); //urun listesine ekle
                    S.Add(sepet);
                }
            }

            foreach (var item in model)
            {
               Sepet xSep = db.Sepet.Where(x=> x.UrunId == item.Id && x.KullaniciId == kid).First();
               Fiyat f = db.Fiyat.Find(item.FiyatId);
                int fiyat = Convert.ToInt32(f.Satis) * xSep.Adet;
                fiyattoplam += fiyat;
            }

            ViewBag.Toplam = fiyattoplam.ToString();
            ViewBag.Satis = new SelectList(db.Fiyat.ToList(), "Id", "Satis"); //fiyatlari getir & viewbag'e ekle
            ViewBag.Kullanici = kid; //kullanici id'sini viewbag'e ekle
            ViewBag.Sepet = S;

            return View(model); //model'i (sepetteki urunlerin listesini) view'e gonder
        }



        public ActionResult SepetEkle(int uid, int kid)
        {
            
            if(db.Sepet.Where(x => x.KullaniciId == kid && x.UrunId == uid && x.Aktif == true && x.Siparis == false).Any() == true)
            {
                Sepet x = db.Sepet.Where(x => x.KullaniciId == kid && x.UrunId == uid && x.Aktif == true && x.Siparis == false).First();
                x.Adet = x.Adet + 1;

                if(x.Adet == 0)
                {
                    x.Adet = 2;
                }
            }
            else { 
            Sepet x = new Sepet(); //sepet objesi olustur
            x.KullaniciId = kid;
            x.UrunId = uid; //gelen verileri yaz
            x.Aktif = true;
            x.Siparis = false;
            x.Adet = 1;
            db.Sepet.Add(x); //ekle
            }

            db.SaveChanges(); //kaydet
            return RedirectToAction("KullaniciUrunListele", "Urun", new { kid = kid }); //urun listesine geri gonder
        }

        public ActionResult SepetSil(int uid, int kid)
        {
            db.Sepet.Remove(db.Sepet.Where(x => x.KullaniciId == kid && x.UrunId == uid).FirstOrDefault()); //sepeti bul & sil
            db.SaveChanges(); //degisiklikleri kaydet
            return RedirectToAction("Sepet", "Urun", new { kid = kid }); //sepet'e geri gonder
        }





        #endregion

        #region  /*----------------------------------------------------Siparis Islemleri-------------------------------------------------------------------------------*/
        public ActionResult SiparisOlustur(int kid, int fiyat, IFormCollection Sip)
        {

            string _Ulke = Sip["Ulke"].ToString();
            string _Isim = Sip["Isim"].ToString();
            string _Soyisim = Sip["Soyisim"].ToString();
            string _FirmaIsmi = Sip["FirmaIsmi"].ToString();
            string _Adres = Sip["Adres"].ToString();
            string _Email = Sip["Email"].ToString();
            string _Tel = Sip["Tel"].ToString();

            string _kupon = Sip["KuponKodu"].ToString();



            string odeme = "";
            foreach (var item in Sip["Odeme"])
            {
                odeme = item;
            }



            Siparis _Siparis = new Siparis()
            {
                KullaniciId = kid,
                ToplamFiyat = fiyat,
                Onaylandi = false,
                Ulke = _Ulke,
                Isim = _Isim,
                Soyisim = _Soyisim,
                FirmaIsmi = _FirmaIsmi,
                Adres = _Adres,
                Email = _Email,
                Telefon = _Tel,
                Aktif = true 
                
            };//siparis olustur

            if(_kupon != "")
            _Siparis.KuponKodu = _kupon;


            if (odeme == "K")
            {
                _Siparis.OdemeTipi = "Kredi Kartı";
                _Siparis.KrediKarti = true;
            }
            else if (odeme == "H") {
                _Siparis.OdemeTipi = "Havale";
                _Siparis.Havale = true;
            }


            db.Siparis.Add(_Siparis);//siparisi ekle
            db.SaveChanges(); //degisikligi kaydet
            Siparis s = db.Siparis.OrderBy(x=> x.id).LastOrDefault(); //son siparisi getir

            foreach (Sepet item in db.Sepet) //sepetlerin icinde don
            {
                if (item.KullaniciId == kid && item.Siparis == false && item.Aktif == true) { //eger sepet aktif ise
                    item.Siparis = true; 
                    item.Aktif = false; 
                    item.SiparisId = s.id; //siparis id'sini son siparis id'si olarak degistir
                }
            }
            db.SaveChanges(); //degisikligi kaydet 

            return RedirectToAction("Sepet", "Urun", new { kid = kid }); //sepete don
        }


        public ActionResult SiparisListele()
        {
            var model = db.Siparis.Where(x=> x.Aktif == true).ToList();  // aktif  siparisleri getir modele ekle
            ViewBag.Kullanici = db.Kullanici.ToList(); //kullanicilari listele

            return View(model); //modeli view'e gönder
        }

        public ActionResult SiparisOnay(int sid)
        {
            Siparis gelen = db.Siparis.Find(sid); //gelen siparisi bul
            gelen.Onaylandi = true; //onaylandi durumunu true yap

           List<Sepet> SepetListesi =  db.Sepet.Where(x => x.SiparisId == sid).ToList();
            foreach (Sepet item in SepetListesi)
            {
                Urun X = db.Urun.Find(item.UrunId);
                if (X.Adet >= 1)
                    X.Adet--;
                else
                    X.Adet = 0;
            }


            db.SaveChanges(); //deg. kaydet 

            return RedirectToAction("SiparisListele", "Urun"); //siparis listele'ye don
        }


        public ActionResult SiparisDetay(int sid)
        {
            var model = db.Siparis.Find(sid); //siparisi bul modele ekle

            ViewBag.Fiyat = db.Fiyat.ToList();
            ViewBag.Sepet = db.Sepet.Where(x => x.SiparisId == sid).ToList(); //siparisid'si ayni olan sepetleri getir 
            ViewBag.Urunler = db.Urun.ToList(); //urunleri getir
            ViewBag.Kullanici = db.Kullanici.ToList();  //kullanicilari getir

            return View(model); //modeli view'e gönder
        }

        public ActionResult SiparisSil(int sid)
        {
            
            db.Siparis.Remove(db.Siparis.Find(sid)); //siparisi bul & sil
            db.SaveChanges(); //kaydet

            return RedirectToAction("SiparisListele", "Urun");//siparis listele'ye don
        }

        #endregion
    }
}
