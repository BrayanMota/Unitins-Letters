using A2.Models;
using Microsoft.EntityFrameworkCore;

namespace A2.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D6L8ECR\SQLEXPRESS;Initial Catalog=Letters;Integrated Security=True;");
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Livraria> Livrarias { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Edicao> Edicoes { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
    }
}