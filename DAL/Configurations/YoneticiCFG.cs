using Entities.Enums;
using Entities.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class YoneticiCFG : IEntityTypeConfiguration<Yonetici>
    {
        public void Configure(EntityTypeBuilder<Yonetici> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                   .HasColumnName("YoneticiID");

            builder.Property(a => a.Ad)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(a => a.Soyad)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(a => a.TCNo)
                   .HasColumnType("varchar")
                   .HasMaxLength(11);

            builder.Property(a => a.Email)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.HasData(
                new Yonetici { Id = 1, Ad = "admin", Soyad = "admin", Cinsiyet = Cinsiyet.erkek, Email = "admin@admin.com", Sifre = "240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9", TCNo = "12345678910", Unvan = Unvan.admin, AktifMi = true }
                );
        }
    }
}
