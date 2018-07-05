using Microsoft.EntityFrameworkCore;

namespace TakeBackTheCourt.Models
{
    public class CourtContext : DbContext
    {
        public CourtContext(DbContextOptions<CourtContext> options) : base(options)
        {
        }

        public DbSet<Resource> Resources { get; set; }
    }
}
