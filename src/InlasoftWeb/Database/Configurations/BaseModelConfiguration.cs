using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InlasoftWeb.Extensions;
using InlasoftWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InlasoftWeb.Database.Configurations
{
    public class BaseModelConfiguration : EntityTypeConfiguration<BaseModel>
    {
        public override void Map(EntityTypeBuilder<BaseModel> builder)
        {
            builder.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
        }
    }
}
