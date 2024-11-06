using SistemaListaFornecedores.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaListaFornecedores.Data.Map
{
    public class EmpresaMap : IEntityTypeConfiguration<EmpresaModel>
    {
        public void Configure(EntityTypeBuilder<EmpresaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeEmpresa).HasMaxLength(255);
            builder.Property(x => x.NomeFantasia).HasMaxLength(150);
            builder.Property(x => x.RamoAtividade).HasMaxLength(150);

        }
    }
}
