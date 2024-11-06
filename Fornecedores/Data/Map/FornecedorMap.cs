using SistemaListaFornecedores.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaListaFornecedores.Data.Map
{
    public class FornecedorMap : IEntityTypeConfiguration<FornecedoresModel>
    {
        public void Configure(EntityTypeBuilder<FornecedoresModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeFornecedor).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoContato).IsRequired().HasMaxLength(255);
            builder.Property(x => x.NomeFantasia).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CEP).IsRequired().HasMaxLength(128);
            builder.Property(x => x.UF).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Municipio).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Numero).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Pais).IsRequired().HasMaxLength(128);
            builder.Property(x => x.InscricaoMunicipal).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Celular).IsRequired().HasMaxLength(128);
            builder.Property(x => x.CpfCnpj).HasMaxLength(128);
            builder.Property(x => x.Email).HasMaxLength(128);
            //Id da Empresa no fornecedor, vinculando um fornecedor a uma empresa.
            builder.Property(x => x.EmpresaId);

            builder.HasOne(x => x.Empresa);
        }
    }
}
