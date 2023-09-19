using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<RestaurantFood> RestaurantFoods { get; set; }
    
        public RestaurantDbContext(DbContextOptions options) : base(options)
        {
           
        }
    }
}
