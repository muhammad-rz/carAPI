using carApi.Models;
using Microsoft.EntityFrameworkCore;

namespace carApi.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> opt) : base(opt)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}