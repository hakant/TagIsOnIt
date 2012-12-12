using System.Data.Entity;
using EtiketiUstunde.Data.Model;

namespace EtiketiUstunde.Data
{
    public class EtiketiUstundeDbContext : DbContext
    {
        public IDbSet<Product> Products { get; set; }

        public IDbSet<Division> Divisions { get; set; }

        public IDbSet<CategoryGroup> CategoryGroups { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<UserProfile> UserProfiles { get; set; }
    }
}
