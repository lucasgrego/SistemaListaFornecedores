using SistemaListaFornecedores.Models;

namespace SistemaListaFornecedores.Repositorios.Interfaces
{
    public interface IEmpresaRepositorio
    {
        Task<List<EmpresaModel>> BuscarTodasEmpresas();
        Task<EmpresaModel> BuscarEmpresaPorId(int id);
        Task<EmpresaModel> AdicionarEmpresa(EmpresaModel empresa);
        Task<EmpresaModel> AtualizarEmpresa(EmpresaModel empresa, int id);
        Task<bool> DeletarEmpresa(int id);

    }
}
