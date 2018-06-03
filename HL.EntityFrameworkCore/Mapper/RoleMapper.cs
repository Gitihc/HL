using HL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HL.EntityFrameworkCore.Mapper
{
  public  class RoleMapper : IEntityTypeConfiguration<Role>
    {
        void IEntityTypeConfiguration<Role>.Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ParentId);
            builder.Property(x => x.RoleName).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.GenTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.Description).HasColumnType("varchar(500)").HasMaxLength(500);
            builder.Property(x => x.Creator);
        }
    }
}
