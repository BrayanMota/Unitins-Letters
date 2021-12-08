using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A2.Models
{
    [Table("Clientes")]
    public class Cliente : Usuario
    {
        [Required]
        [Display(Name = "CPF")]
        public string cpf { get; set; }
    }
}