using System;
using InlasoftWeb.Extensions;
using InlasoftWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InlasoftWeb.Database.Configurations
{
    public class BaseModelConfiguration : EntityTypeConfiguration<BaseModel>
    {
        public override void Map(EntityTypeBuilder<BaseModel> builder)
        {
            //builder.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
            builder.Property(p => p.CreatedDate).HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.LastModifiedDate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAddOrUpdate();
            builder.Property(p => p.IsActive).HasDefaultValue(true).IsRequired();
        }
    }
}
