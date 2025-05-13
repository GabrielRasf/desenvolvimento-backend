using Microsoft.EntityFrameworkCore;

namespace desenvolvimento_backend.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

    }
}



