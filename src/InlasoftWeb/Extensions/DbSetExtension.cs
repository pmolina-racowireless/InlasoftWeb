using System.Linq;
using InlasoftWeb.Models;

namespace InlasoftWeb.Extensions
{
    public static class DbSetExtension
    {
        public static IQueryable<T> Active<T>(this IQueryable<T> query) where T : BaseModel
        {
            return query.Where(x => (x.IsActive));
        }
    }
}
