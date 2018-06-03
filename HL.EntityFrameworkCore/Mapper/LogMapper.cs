using System;
using HL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Text;

namespace HL.EntityFrameworkCore.Mapper
{
   public class LogMapper : IEntityTypeConfiguration<Log>
    {
        void IEntityTypeConfiguration<Log>.Configure(EntityTypeBuilder<Log> builder)
        {
            builder.ToTable("Log");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OpType);
            builder.Property(x => x.Content).HasColumnType("varchar(500)").HasMaxLength(500);
            builder.Property(x => x.OpUserId);
            builder.Property(x => x.GenTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
        }
    }
}
