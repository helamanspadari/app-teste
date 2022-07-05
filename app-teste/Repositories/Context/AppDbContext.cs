using app_teste.Models.Entities.Marca;
using app_teste.Models.Entities.Proprietario;
using app_teste.Models.Entities.Veiculo;
using Microsoft.EntityFrameworkCore;

namespace app_teste.Repositories.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<MarcaEntities>? Marca { get; set; }
        public DbSet<ProprietarioEntities>? Proprietario { get; set; }
        public DbSet<VeiculoEntities>? Veiculo { get; set; }
    }
}
