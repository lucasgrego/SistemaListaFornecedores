using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaListaFornecedores.Migrations
{
    /// <inheritdoc />
    public partial class RemovendoColunasDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Empresa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CNPJ",
                table: "Fornecedores",
                type: "int",
                maxLength: 14,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Telefone",
                table: "Fornecedores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CNPJ",
                table: "Empresa",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Telefone",
                table: "Empresa",
                type: "int",
                nullable: true);
        }
    }
}
