using Microsoft.EntityFrameworkCore;
using ProjetoAPI.API.Models;

namespace ProjetoAPI.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Apartamento> Apartamentos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
