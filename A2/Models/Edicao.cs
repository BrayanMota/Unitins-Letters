using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A2.Models
{
    [Table("Edicoes")]
    public class Edicao : Livro
    {
        [Required]
        [Display(Name = "Preço")]
        public double preco { get; set; }
        [Required]
        [Display(Name = "Ano de lançamento")]
        public string ano { get; set; }
        [Required]
        [Display(Name = "Quantidade de páginas")]
        public int paginas { get; set; }
    }
}