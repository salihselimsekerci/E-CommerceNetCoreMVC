using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCore.Models;

namespace NetCore.Data
{
    public class NetCoreDbContext : DbContext
    {
        public NetCoreDbContext(DbContextOptions<NetCoreDbContext> options) : base(options)
        {
        }

        public DbSet<Kullanici> Kullanici { get; set; } //kullanici class'ini( models > Kullanici.cs), entity collection olarak ekle 
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Fiyat> Fiyat { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<Slide> Slide { get; set; }
        public DbSet<Mesaj> Mesaj { get; set; }
        public DbSet<Site> Site { get; set; }
        public DbSet<Abone> Abone { get; set; }
        public DbSet<Dil> Dil { get; set; }
        public DbSet<Kur> Kur { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().ToTable("Kullanici"); //<Kullanici> (Entity collection), database tablosuna uyarla 
            modelBuilder.Entity<Kategori>().ToTable("Kategori");
            modelBuilder.Entity<Rol>().ToTable("Rol");
            modelBuilder.Entity<Urun>().ToTable("Urun");
            modelBuilder.Entity<Marka>().ToTable("Marka");
            modelBuilder.Entity<Fiyat>().ToTable("Fiyat");
            modelBuilder.Entity<Sepet>().ToTable("Sepet");
            modelBuilder.Entity<Siparis>().ToTable("Siparis");
            modelBuilder.Entity<Slide>().ToTable("Slide");
            modelBuilder.Entity<Mesaj>().ToTable("Mesaj");
            modelBuilder.Entity<Site>().ToTable("Site");
            modelBuilder.Entity<Abone>().ToTable("Abone");
            modelBuilder.Entity<Dil>().ToTable("Dil");
            modelBuilder.Entity<Kur>().ToTable("Kur");
        }

    }
}
