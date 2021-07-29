using DomainUnico;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class UsuarioInterno : Usuario
    {
        private Usuario _usuario
        {
            get
            {
                UsuarioContext _context = new UsuarioContext();
                return _context.Usuario.Find(UsuarioId);
            }
        }

        [NotMapped]
        public virtual new string Nome { get => _usuario.Nome; }
    }
}
