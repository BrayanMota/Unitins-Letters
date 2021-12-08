using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A2.Models
{
    [Table("Editoras")]
    public class Editora : Usuario
    {
        [Required]
        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }
    }
}