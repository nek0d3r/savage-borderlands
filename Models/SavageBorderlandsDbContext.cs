using Microsoft.EntityFrameworkCore;

namespace savage_borderlands.Models
{
    public class SavageBorderlandsDbContext : DbContext
    {
        public SavageBorderlandsDbContext (DbContextOptions<SavageBorderlandsDbContext> options) : base(options)
        {
        }
        
        public DbSet<Weapon> Weapon { get; set; }
    }
}