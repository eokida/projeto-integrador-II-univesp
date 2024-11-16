using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MercadinhoChapadao.Data;
using MercadinhoChapadao.Models;
using System.Threading.Tasks;

namespace MercadinhoChapadao.Pages.Produtos
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
            Produto = new Produto(); // Inicializa a propriedade Produto
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            Produto = produto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
