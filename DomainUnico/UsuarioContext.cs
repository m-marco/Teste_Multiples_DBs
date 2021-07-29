using Microsoft.EntityFrameworkCore;

namespace DomainUnico
{
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public UsuarioContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost;port=3306;database=usuariosdb;uid=root;password=admin", MySqlServerVersion.LatestSupportedServerVersion);
        }

        public UsuarioContext(DbContextOptions<UsuarioContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
