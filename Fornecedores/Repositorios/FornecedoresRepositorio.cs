using SistemaListaFornecedores.Data;
using SistemaListaFornecedores.Models;
using SistemaListaFornecedores.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SistemaListaFornecedores.Repositorios
{
    public class FornecedoresRepositorio : IFornecedoresRepositorio
    {
        private readonly SistemaListaFornecedoresDBContext _dbContext;

        public FornecedoresRepositorio(SistemaListaFornecedoresDBContext fornecedoresDBContext) 
        { 
            _dbContext = fornecedoresDBContext;

        }
        //Busca todos os fornecedores cadastrados no banco de dados.
        public async Task<List<FornecedoresModel>> BuscarTodosFornecedores()
        {
            try
            {
                return await _dbContext.Fornecedores
                            .Include(x => x.Empresa)
                            .ToListAsync();

            }
            catch (Exception ex)
            {
                //Tratamento de erro simplificado, o correto seria um tratamento padronizado por código e salvamento do log.
                //Feito dessa forma só para agilizar o processo.
                throw new Exception(ex.InnerException.Message);
            }
        }

        //Busca um fornecedor por ID.
        public async Task<FornecedoresModel> BuscarFornecedoresPorId(int id)
        {
            try
            {
                return await _dbContext.Fornecedores
                            .Include(x => x.Empresa)
                            .FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                //Tratamento de erro simplificado, o correto seria um tratamento padronizado por código e salvamento do log.
                //Feito dessa forma só para agilizar o processo.
                throw new Exception(ex.InnerException.Message);
            }
        }
        //Adiciona um novo fornecedor.
        public async Task<FornecedoresModel> AdicionarFornecedores(FornecedoresModel fornecedores)
        {
            try
            {
                await _dbContext.Fornecedores.AddAsync(fornecedores);
                await _dbContext.SaveChangesAsync();

                return fornecedores;
            }
            catch (Exception ex)
            {
                //Tratamento de erro simplificado, o correto seria um tratamento padronizado por código e salvamento do log.
                //Feito dessa forma só para agilizar o processo.
                throw new Exception(ex.InnerException.Message);
            }
        }
        //Realiza o update em um fornecedor especifico.
        public async Task<FornecedoresModel> AtualizarFornecedores(FornecedoresModel fornecedores, int id)
        {
            try
            {
                FornecedoresModel FornecedorPorId = await BuscarFornecedoresPorId(id);

                if (FornecedorPorId == null)
                {
                    throw new Exception($"Fornecedor para o ID: {id} não foi localizado.");
                }
                //Seta os novos valores no cadastro dos fornecedores.
                FornecedorPorId.NomeFornecedor = fornecedores.NomeFornecedor;
                FornecedorPorId.PessoContato = fornecedores.PessoContato;
                FornecedorPorId.NomeFantasia = fornecedores.NomeFantasia;
                FornecedorPorId.CEP = fornecedores.CEP;
                FornecedorPorId.UF = fornecedores.UF;
                FornecedorPorId.Municipio = fornecedores.Municipio;
                FornecedorPorId.Logradouro = fornecedores.Logradouro;
                FornecedorPorId.Numero = fornecedores.Numero;
                FornecedorPorId.Pais = fornecedores.Pais;
                FornecedorPorId.InscricaoMunicipal = fornecedores.InscricaoMunicipal;
                FornecedorPorId.Telefone = fornecedores.Telefone;
                FornecedorPorId.Celular = fornecedores.Celular;
                FornecedorPorId.CpfCnpj = fornecedores.CpfCnpj;
                FornecedorPorId.Email = fornecedores.Email;
                //Seta o id da Empresa no fornecedor, vinculando um fornecedor a uma empresa.
                FornecedorPorId.EmpresaId = fornecedores.EmpresaId;

                _dbContext.Fornecedores.Update(FornecedorPorId);
                await _dbContext.SaveChangesAsync();

                return FornecedorPorId;
            }
            catch (Exception ex)
            {
                //Tratamento de erro simplificado, o correto seria um tratamento padronizado por código e salvamento do log.
                //Feito dessa forma só para agilizar o processo.
                throw new Exception(ex.InnerException.Message);
            }
        }

        //Realiza um delete de um fornecedor especifico.
        public async Task<bool> DeletarFornecedores(int id)
        {
            try
            {
                FornecedoresModel FornecedorPorId = await BuscarFornecedoresPorId(id);

                if (FornecedorPorId == null)
                {
                    throw new Exception($"Fornecedor para o ID: {id} não foi localizado.");
                }

                _dbContext.Fornecedores.Remove(FornecedorPorId);
                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                //Tratamento de erro simplificado, o correto seria um tratamento padronizado por código e salvamento do log.
                //Feito dessa forma só para agilizar o processo.
                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
