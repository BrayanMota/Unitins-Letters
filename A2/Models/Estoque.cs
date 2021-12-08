using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A2.Models
{
    [Table("Estoques")]
    public class Estoque
    {
        [Key]
        public int id { get; set; }
        public Edicao edicaoID { get; set; }
        [Display(Name = "Quantidade de livros")]
        public int quantidade { get; set; }
    }
}