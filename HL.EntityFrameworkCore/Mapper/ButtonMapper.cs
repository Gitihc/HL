using System;
using HL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Text;

namespace HL.EntityFrameworkCore.Mapper
{
    public class ButtonMapper : IEntityTypeConfiguration<Button>
    {
        void IEntityTypeConfiguration<Button>.Configure(EntityTypeBuilder<Button> builder)
        {
            builder.ToTable("Button");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ButtonID).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.Name).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.Title).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.EventName).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.MethodName).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.Type);
            builder.Property(x => x.Index);
            builder.Property(x => x.GenTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.Creator);
        }
    }
}
