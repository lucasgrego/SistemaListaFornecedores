using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaListaFornecedores.Migrations
{
    /// <inheritdoc />
    public partial class AlteraçãoModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Fornecedores_FornecedorId",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_FornecedorId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "RamoAtividade",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Fornecedores",
                newName: "PessoContato");

            migrationBuilder.RenameColumn(
                name: "RazaoSocial",
                table: "Empresa",
                newName: "NomeFantasia");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CpfCnpj",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Fornecedores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InscricaoMunicipal",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeFantasia",
                table: "Fornecedores",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeFornecedor",
                table: "Fornecedores",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Fornecedores",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_EmpresaId",
                table: "Fornecedores",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_Empresa_EmpresaId",
                table: "Fornecedores",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_Empresa_EmpresaId",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedores_EmpresaId",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "CpfCnpj",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "InscricaoMunicipal",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "NomeFantasia",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "NomeFornecedor",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Fornecedores");

            migrationBuilder.RenameColumn(
                name: "PessoContato",
                table: "Fornecedores",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "NomeFantasia",
                table: "Empresa",
                newName: "RazaoSocial");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Fornecedores",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RamoAtividade",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Empresa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_FornecedorId",
                table: "Empresa",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Fornecedores_FornecedorId",
                table: "Empresa",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id");
        }
    }
}
