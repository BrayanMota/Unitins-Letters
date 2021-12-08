using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A2.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Required]
        [Display(Name = "Autor")]
        public string autor { get; set; }
        [Required]
        [Display(Name = "Sinopse")]
        public string sinopse { get; set; }
    }
}