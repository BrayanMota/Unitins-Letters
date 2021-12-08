using Microsoft.EntityFrameworkCore.Migrations;

namespace A2.Migrations
{
    public partial class CriandoModeloEstoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "edicaoIDid",
                table: "Estoques",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "quantidade",
                table: "Estoques",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_edicaoIDid",
                table: "Estoques",
                column: "edicaoIDid");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Edicoes_edicaoIDid",
                table: "Estoques",
                column: "edicaoIDid",
                principalTable: "Edicoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Edicoes_edicaoIDid",
                table: "Estoques");

            migrationBuilder.DropIndex(
                name: "IX_Estoques_edicaoIDid",
                table: "Estoques");

            migrationBuilder.DropColumn(
                name: "edicaoIDid",
                table: "Estoques");

            migrationBuilder.DropColumn(
                name: "quantidade",
                table: "Estoques");
        }
    }
}
