using Microsoft.EntityFrameworkCore;
using ControleGastos.Models;

namespace ControleGastos.Data{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Despesa> Despesas {get; set; }
    }
    
}