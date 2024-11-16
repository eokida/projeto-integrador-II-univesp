using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MercadinhoChapadao.Data;
using MercadinhoChapadao.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MercadinhoChapadao.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
            Produtos = new List<Produto>(); // Inicializa a propriedade Produtos
        }

        public IList<Produto> Produtos { get; set; }

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produtos.ToListAsync();
        }
    }
}
