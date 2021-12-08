using Microsoft.EntityFrameworkCore.Migrations;

namespace A2.Migrations
{
    public partial class RemovendoIDEditora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditoraID",
                table: "Edicoes");

            migrationBuilder.DropColumn(
                name: "cnpj",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "cpf",
                table: "Clientes",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "EditoraID",
                table: "Edicoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "cnpj",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
