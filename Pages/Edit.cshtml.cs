using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MercadinhoChapadao.Data;
using MercadinhoChapadao.Models;
using System.Threading.Tasks;

namespace MercadinhoChapadao.Pages.Produtos
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
            Produto = new Produto(); // Inicializa a propriedade Produto
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == id);

            if (produto == null)
            {
                return NotFound();
            }

            Produto = produto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoToUpdate = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == id);

            if (produtoToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Produto>(
                produtoToUpdate,
                "produto",
                p => p.Nome, p => p.Descricao, p => p.Preco, p => p.QuantidadeEmEstoque)) // Inclua a propriedade QuantidadeEmEstoque
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produtoToUpdate.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToPage("./Index");
            }

            return Page();
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
