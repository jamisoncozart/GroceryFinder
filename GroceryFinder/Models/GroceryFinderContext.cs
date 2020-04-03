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

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Store>()
            .HasData(
              new Store { StoreId = 1, Name = "FredMeyers", City = "Beaverton", OpenHour = 7, CloseHour = 10, Delivery = false, Description = "Provides some services like ordering your groceries online and at-store pickup where they load the groceries in your car for you. The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks." },
              new Store { StoreId = 2, Name = "Winco", City = "Beaverton", OpenHour = 7, CloseHour = 10, Delivery = false, Description = "Provides some services like ordering your groceries online and at-store pickup where they load the groceries in your car for you. The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks." },
              new Store { StoreId = 3, Name = "Trader Joe's", City = "Beaverton", OpenHour = 9, CloseHour = 7, Delivery = false, Description = "The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks." },
              new Store { StoreId = 4, Name = "Grocery Outlet", City = "Beaverton", OpenHour = 8, CloseHour = 9, Delivery = false, Description = "Provides some services like ordering your groceries online and at-store pickup where they load the groceries in your car for you. The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks." },
              new Store { StoreId = 5, Name = "New Seasons", City = "Beaverton", OpenHour = 8, CloseHour = 8, Delivery = false, Description = "Provides some services like ordering your groceries online and at-store pickup where they load the groceries in your car for you. The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks." }
            );
        }
    }
}