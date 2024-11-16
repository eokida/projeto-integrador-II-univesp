using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MercadinhoChapadao.Data;
using MercadinhoChapadao.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MercadinhoChapadao.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Produto:")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "Descrição:")]
        public string Descricao { get; set; } = string.Empty;

        [Display(Name = "Preço:")]
        public decimal Preco { get; set; }

        [Display(Name = "Quantidade em Estoque:")]
        public int QuantidadeEmEstoque { get; set; }
    }
}
