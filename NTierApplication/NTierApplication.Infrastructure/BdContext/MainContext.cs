using Microsoft.EntityFrameworkCore;
using NTierApplication.Domain.Models;

namespace NTierApplication.Infrastructure.BdContext
{ 
    public class MainContext:DbContext
    {
        public DbSet<Item> Items;
        public MainContext(DbContextOptions<MainContext> options):
            base(options) {  }
    }
}
