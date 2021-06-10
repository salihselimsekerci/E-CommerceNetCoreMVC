using NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Data
{
    public static class DbInitializer
    {
       


            public static void Initialize(NetCoreDbContext context, int x)
        {
            if (x== 0) //x 0 ise
            {
                context.Database.EnsureDeleted();  //db'i kontrol et -> varsa sil
                context.Database.EnsureCreated(); //db'i kontrol et -> yoksa olustur
            }

            context.Database.EnsureCreated(); //db'i kontrol et yoksa olustur

            if (context.Kullanici.Any())//Kullanıcı içeriğini kontrol et
            {
                if (context.Kullanici.Any() == true && context.Rol.Any() == false)  //kullanici verisi var ama rol yok ise
                {
                    context.Database.EnsureDeleted();  //db'i kontrol et -> varsa sil
                    context.Database.EnsureCreated(); //db'i kontrol et -> yoksa olustur
                }
                //Veri var
                return;
            }

            //veri yok: 

            //rolleri oluştur
            Rol rAdmin = new Rol() {RolAdi = "Admin" }; 
            Rol rKullanici = new Rol() { RolAdi = "Kullanici" };
            Rol rTest = new Rol() { RolAdi = "test" }; 

            context.Rol.Add(rAdmin);
            context.Rol.Add(rKullanici);
            context.Rol.Add(rTest);
            //kategorileri oluştur
            Kategori K = new Kategori() { KategoriAdi = "KategoriTest1", Durum=true };
            Kategori K2 = new Kategori() { KategoriAdi = "KategoriTest2", Durum=true };
            context.Kategori.Add(K);
            context.Kategori.Add(K2);

            //marka olustur
            Marka MA = new Marka() { MarkaAdi = "Marka1", ResimUrl= "https://keestalkstech.com/wp-content/uploads/2019/08/1200px-.NET_Core_Logo.svg.png" };
            Marka MA2 = new Marka() { MarkaAdi = "Marka2", ResimUrl = "https://via.placeholder.com/150" };
            Marka MA3 = new Marka() { MarkaAdi = "Marka3", ResimUrl = "https://via.placeholder.com/150" };
            context.Marka.Add(MA);
            context.Marka.Add(MA2);
            context.Marka.Add(MA3);

            //fiyat olustur
            Fiyat F0 = new Fiyat() { Alis = "1300", Satis = "5000" };
            Fiyat F1 = new Fiyat() { Alis = "1400", Satis = "6000" };
            Fiyat F2 = new Fiyat() { Alis = "5300", Satis = "7000" };
            Fiyat F3 = new Fiyat() { Alis = "6300", Satis = "8000" };
            context.Fiyat.Add(F0);
            context.Fiyat.Add(F1);
            context.Fiyat.Add(F2);
            context.Fiyat.Add(F3);

            context.SaveChanges(); //degisikligi kaydet

            //kategori ID'lerini bul
            K = context.Kategori.Where(x => x.KategoriAdi == "KategoriTest1").FirstOrDefault();
            K2 = context.Kategori.Where(x => x.KategoriAdi == "KategoriTest2").FirstOrDefault();
            F0 = context.Fiyat.Where(x => x.Alis == F0.Alis && x.Satis == F0.Satis).FirstOrDefault();
            F1 = context.Fiyat.Where(x => x.Alis == F1.Alis && x.Satis == F1.Satis).FirstOrDefault();
            F2 = context.Fiyat.Where(x => x.Alis == F2.Alis && x.Satis == F2.Satis).FirstOrDefault();
            F3 = context.Fiyat.Where(x => x.Alis == F3.Alis && x.Satis == F3.Satis).FirstOrDefault();
            MA = context.Marka.FirstOrDefault();

            //urunleri olustur
            Urun U = new Urun() { UrunAdi = "UrunTest 1", Aciklama = "Urun 1 Test Aciklama", OzellikBaslik1 = "Renk", OzellikAciklama1 = "Mavi", OzellikBaslik2 = "Genişlik", OzellikAciklama2 = "3M", OzellikBaslik3 = "Agirlik", OzellikAciklama3 = "5KG", Adet = 10, FiyatId = F0.Id, MarkaId = MA3.Id, KategoriId = K.Id, ResimUrl = "https://via.placeholder.com/150", EnCokGoruntulenen = true };
            Urun U2 = new Urun() { UrunAdi = "UrunTest 2", Aciklama = "Urun 2 Test Aciklama", OzellikBaslik1 = "Renk", OzellikAciklama1 = "Kırmızı", OzellikBaslik2 = "Genişlik", OzellikAciklama2 = "3M", OzellikBaslik3 = "Agirlik", OzellikAciklama3 = "5KG", Adet = 5, FiyatId = F1.Id, MarkaId = MA2.Id, KategoriId = K.Id, ResimUrl = "https://via.placeholder.com/160", EnCokSatan = true};
            Urun U3 = new Urun() { UrunAdi = "UrunTest 3", Aciklama = "Urun 3 Test Aciklama", OzellikBaslik1 = "Renk", OzellikAciklama1 = "Turuncu", OzellikBaslik2 = "Genişlik", OzellikAciklama2 = "3M", OzellikBaslik3 = "", OzellikAciklama3 = "", Adet = 20, FiyatId = F2.Id, MarkaId = MA2.Id, KategoriId = K2.Id, ResimUrl = "https://via.placeholder.com/130", YeniUrun=true, EnCokSatan = true, EnCokGoruntulenen = true };
            Urun U4 = new Urun() { UrunAdi = "UrunTest 4", Aciklama = "Urun 4 Test Aciklama", OzellikBaslik1= "Renk", OzellikAciklama1="Sarı", OzellikBaslik2 = "Genişlik", OzellikAciklama2 = "3M", Adet = 1, FiyatId = F3.Id, MarkaId = MA.Id, KategoriId = K2.Id, ResimUrl = "https://via.placeholder.com/120", YeniUrun = true };
            context.Urun.Add(U);
            context.Urun.Add(U2);
            context.Urun.Add(U3);
            context.Urun.Add(U4);


            Slide Slide1 = new Slide() { ResimUrl = "https://via.placeholder.com/1200x500" };
            Slide Slide2 = new Slide() { ResimUrl = "https://via.placeholder.com/1200x500" };
            context.Slide.Add(Slide1);
            context.Slide.Add(Slide2);


            //kullanici olustur
            rAdmin = context.Rol.Where(x => x.RolAdi == "Admin").FirstOrDefault(); //admin rolunu bul
            rKullanici = context.Rol.Where(x => x.RolAdi == "Kullanici").FirstOrDefault(); //admin rolunu bul

            Kullanici Admin = new Kullanici() { KullaniciAdi = "Admin", Sifre = "1234", email = "admin@admin.com", sifreBekliyor = false, RolID = rAdmin.Id }; //kullanici Oluştur
            Kullanici User = new Kullanici() { KullaniciAdi = "1", Sifre = "1", email = "1@1.com", sifreBekliyor = false, RolID = rKullanici.Id };

            context.Kullanici.Add(User);
            context.Kullanici.Add(Admin); // kullaniciyi ekle

            context.SaveChanges(); // degisikligi kaydet

            
        }
    }
}