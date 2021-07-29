using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Contexts
{
    public class ProjetoContext : DbContext
    {
        public DbSet<UsuarioInterno> Usuario { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }

        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioInterno>(x =>
            {
                x.HasKey(y => y.UsuarioId);
                x.ToTable("usuariointerno");
            });
        }
    }
}
