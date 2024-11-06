using SistemaListaFornecedores.Models;

namespace SistemaListaFornecedores.Repositorios.Interfaces
{
    public interface IFornecedoresRepositorio
    {
        Task<List<FornecedoresModel>> BuscarTodosFornecedores();
        Task<FornecedoresModel> BuscarFornecedoresPorId(int id);
        Task<FornecedoresModel> AdicionarFornecedores(FornecedoresModel fornecedores);
        Task<FornecedoresModel> AtualizarFornecedores(FornecedoresModel fornecedores, int id);
        Task<bool> DeletarFornecedores(int id);
    }
}
