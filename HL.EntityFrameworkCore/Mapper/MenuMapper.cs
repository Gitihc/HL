using System;
using HL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Text;

namespace HL.EntityFrameworkCore.Mapper
{
   public class MenuMapper : IEntityTypeConfiguration<Menu>
    {
        void IEntityTypeConfiguration<Menu>.Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.Type);
            builder.Property(x => x.Link).HasColumnType("varchar(200)").HasMaxLength(200);
            builder.Property(x => x.Icon).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.IsEnable).HasDefaultValue(0);
            builder.Property(x => x.Index);
            builder.Property(x => x.GenTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.Creator);
            builder.Property(x => x.ButtonList).HasColumnType("varchar(300)").HasMaxLength(300);
        }
    }
}
