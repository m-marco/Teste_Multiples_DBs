using Domain;
using Infraestructure.Contexts;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Teste_Multiples_DBs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProjetoContext _context;

        public IndexModel(ProjetoContext context)
        {
            _context = context;
        }

        public List<Tarefa> Tarefas { get; set; }

        public async Task OnGet()
        {
            Tarefas = await _context.Tarefa.Include(x => x.Usuario).ToListAsync();
        }
    }
}
