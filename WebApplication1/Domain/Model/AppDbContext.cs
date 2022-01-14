using Microsoft.EntityFrameworkCore;

namespace HectreMgmt.Domain.Model
{
    public class AppDbContext :DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Chemical> Chemicals { get; set; }
    }
}
