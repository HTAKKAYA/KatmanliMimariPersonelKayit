using DAL.Configurations;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class PersonelKayitContext :DbContext
    {
        public DbSet<Yonetici> Yoneticiler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<YoneticiPersonel> YoneticiPersoneller { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=PersonelKayıtDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new YoneticiCFG());
            modelBuilder.ApplyConfiguration(new YoneticiPersonelCFG());
            modelBuilder.ApplyConfiguration(new PersonelCFG());
        }
    }
}
