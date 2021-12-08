using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A2.Models
{
    [Table("Carrinhos")]
    public class Carrinho
    {
        [Key]
        public int id { get; set; }
    }
}