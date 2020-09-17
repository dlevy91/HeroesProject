using Microsoft.EntityFrameworkCore;
using Heroes.Models;
namespace Heroes.DAO
{
    public class HeroDbContext : DbContext
    {
        public HeroDbContext(DbContextOptions<HeroDbContext> options) : base (options)
        {
        }
        
        public DbSet<HeroesModel> heroes {get; set;}
        public DbSet<VillainsModel> villains {get; set;}
    }
}