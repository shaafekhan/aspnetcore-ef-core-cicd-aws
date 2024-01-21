using corewebapi.Entities;
using Microsoft.EntityFrameworkCore;


namespace corewebapi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }


    }
}
