using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MercadinhoChapadao.Data;
using MercadinhoChapadao.Models;
using System.Threading.Tasks;

namespace MercadinhoChapadao.Pages.Produtos
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
            Produto = new Produto(); // Inicializa a propriedade Produto
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produtos.Add(Produto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
