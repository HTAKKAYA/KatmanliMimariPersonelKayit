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
    internal class YoneticiPersonelCFG :IEntityTypeConfiguration<YoneticiPersonel>
    {
        public void Configure(EntityTypeBuilder<YoneticiPersonel> builder)
        {
            builder.Property(a => a.Id)
                   .HasColumnName("YoneticiPersonelID");

            builder.HasKey(yp => new { yp.YoneticiId, yp.PersonelId });

            builder.HasOne(yp => yp.Yonetici)
                   .WithMany(y => y.YoneticiPersoneller)
                   .HasForeignKey(yp => yp.YoneticiId);

            builder.HasOne(yp => yp.Personel)
                   .WithMany(p => p.YoneticiPersoneller)
                   .HasForeignKey(yp => yp.PersonelId);
        }
    }
}
