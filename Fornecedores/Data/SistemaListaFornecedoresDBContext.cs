using SistemaListaFornecedores.Models;
using SistemaListaFornecedores.Data.Map;
using Microsoft.EntityFrameworkCore;

namespace SistemaListaFornecedores.Data
{
    public class SistemaListaFornecedoresDBContext : DbContext
    {
      public SistemaListaFornecedoresDBContext(DbContextOptions<SistemaListaFornecedoresDBContext> options) : base(options)
        {

        }
        public DbSet<FornecedoresModel> Fornecedores { get; set; }
        public DbSet<EmpresaModel> Empresa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
