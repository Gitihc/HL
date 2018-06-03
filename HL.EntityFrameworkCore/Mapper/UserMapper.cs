using HL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HL.EntityFrameworkCore.Mapper
{
    public class UserMapper : IEntityTypeConfiguration<User>
    {
        void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DepartmentId);
            builder.Property(x => x.LoginName).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.Password).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.VseName).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.Mobile).HasColumnType("varchar(20)").HasMaxLength(20);
            builder.Property(x => x.Email).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.GenTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.LoginTime).HasColumnType("datetime");
            builder.Property(x => x.LastLoginTime).HasColumnType("datetime");
            builder.Property(x => x.LoginCount).HasDefaultValue(0);
            builder.Property(x => x.IsDeleted).HasDefaultValue(0);
        }
    }
}
