using Microsoft.EntityFrameworkCore;
using TemTrampo.Models;

namespace TemTrampo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }

        public DbSet<Vaga> Vagas { get; set; } = default!;
    }
}
