using AR.Domain;
using Microsoft.EntityFrameworkCore;

namespace AR.Data
{
    public class ContextoPrincípal : DbContext
    {
        public ContextoPrincípal(DbContextOptions options)
             : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
