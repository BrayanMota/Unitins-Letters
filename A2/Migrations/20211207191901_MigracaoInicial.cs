using Microsoft.EntityFrameworkCore.Migrations;

namespace A2.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Edicoes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: true),
                    autor = table.Column<string>(nullable: true),
                    sinopse = table.Column<string>(nullable: true),
                    preco = table.Column<double>(nullable: false),
                    ano = table.Column<string>(nullable: true),
                    paginas = table.Column<int>(nullable: false),
                    EditoraID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edicoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Editoras",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    telefone = table.Column<string>(nullable: false),
                    endereco = table.Column<string>(nullable: false),
                    senha = table.Column<string>(maxLength: 100, nullable: false),
                    cnpj = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoras", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Edicoes");

            migrationBuilder.DropTable(
                name: "Editoras");
        }
    }
}
