using Microsoft.EntityFrameworkCore;

namespace GroceryFinder.Models
{
    public class GroceryFinderContext : DbContext
    {
        public GroceryFinderContext(DbContextOptions<GroceryFinderContext> options)
          :base(options)
        {
          //code
        }

        public DbSet<Store> Stores { get; set; }
    }
}