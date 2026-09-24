using Microsoft.EntityFrameworkCore;
using TeendolistaWebApp_13f_2cs_20260923.Models;

namespace TeendolistaWebApp_13f_2cs_20260923.Data
{
    public class TeendoDbContext : DbContext
    {
        public TeendoDbContext(DbContextOptions<TeendoDbContext> options) : base(options)
        {
            
        }
        public DbSet<Teendo> Teendok { get; set; }
    }
}
