using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class PersonelCFG :IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                   .HasColumnName("PersonelID");

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
        }
    }
}
