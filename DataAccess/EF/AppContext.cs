using DataAccess.EF.Entityes;
using System.Data.Entity;

namespace DataAccess.EF
{
    public class AppContext : DbContext
    {
        public AppContext()
          : base("DbConnection")
        { }

        public DbSet<Comment> Comments { get; set; }
    }
}
