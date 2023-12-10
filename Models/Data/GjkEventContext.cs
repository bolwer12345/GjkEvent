using Microsoft.EntityFrameworkCore;

namespace GjkEvent.Models.Data
{
    public class GjkEventContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public GjkEventContext(DbContextOptions<GjkEventContext> options) : base(options)
        {
        }
    }
}
