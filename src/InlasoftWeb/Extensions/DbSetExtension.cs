using System.Linq;
using InlasoftWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InlasoftWeb.Extensions
{

    #region Entity Configuration Helpers
    public abstract class EntityTypeConfiguration<TEntity>
    where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }

    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, EntityTypeConfiguration<TEntity> configuration)
            where TEntity : class
        {
            configuration.Map(modelBuilder.Entity<TEntity>());
        }
    }
    #endregion

    public static class DbSetExtension
    {
        public static IQueryable<T> Active<T>(this IQueryable<T> query) where T : BaseModel
        {
            return query.Where(x => (x.IsActive));
        }
    }
}
