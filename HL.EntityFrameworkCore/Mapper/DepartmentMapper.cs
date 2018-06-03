using HL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HL.EntityFrameworkCore.Mapper
{
    public class DepartmentMapper : IEntityTypeConfiguration<Department>
    {
        void IEntityTypeConfiguration<Department>.Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ParentId);
            builder.Property(x => x.DapartmentName).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.DapartmentCode).HasColumnType("varchar(64)").HasMaxLength(64);
            builder.Property(x => x.Mange);
            builder.Property(x => x.ContactNumber).HasColumnType("varchar(20)").HasMaxLength(20);
            builder.Property(x => x.Ceator);
            builder.Property(x => x.GenTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.IsDeleted).HasDefaultValue(0);
        }
    }
}
