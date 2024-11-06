using SistemaListaFornecedores.Models;
using SistemaListaFornecedores.Data;
using SistemaListaFornecedores.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace SistemaListaFornecedores.Repositorios
{
    public class EmpresaRepositorio : IEmpresaRepositorio
    {
        private readonly SistemaListaFornecedoresDBContext _dbContext;

        public EmpresaRepositorio(SistemaListaFornecedoresDBContext EmpresaDBContext) 
        { 
            _dbContext = EmpresaDBContext;

        }
        //Busca todas as Empresas cadastradas no banco de dados.
        public async Task<List<EmpresaModel>> BuscarTodasEmpresas()
        {
            try
            {
                return await _dbContext.Empresa.ToListAsync();
            }
            catch (Exception ex)
            {
                //Tratamento de erro simplificado, o correto seria um tratamento padronizado por código e salvamento do log.
                //Feito dessa forma só para agilizar o processo.
                throw new Exception(ex.InnerException.Message);
            }
        }
        //Busca uma Empresa por ID.
        public async Task<EmpresaModel> BuscarEmpresaPorId(int id)
        {
            try
            {
                return await _dbContext.Empresa.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                //Tratamento de erro simplificado, o correto seria um tratamento padronizado por código e salvamento do log.
                //Feito dessa forma só para agilizar o processo.
                throw new Exception(ex.InnerException.Message);
            }
        }
        //Adiciona uma nova Empresa.
        public async Task<EmpresaModel> AdicionarEmpresa(EmpresaModel empresa)
        {
            try
            {
                await _dbContext.Empresa.AddAsync(empresa);
                await _dbContext.SaveChangesAsync();

                return empresa;
            }
            catch (Exception ex)
            {
                //Tratamento de erro simplificado, o correto seria um tratamento padronizado por código e salvamento do log.
                //Feito dessa forma só para agilizar o processo.
                throw new Exception(ex.InnerException.Message);
            }
        }
        //Realiza o update em uma Empresa especifica.
        public async Task<EmpresaModel> AtualizarEmpresa(EmpresaModel empresa, int id)
        {
            try
            {
                EmpresaModel EmpresaPorId = await BuscarEmpresaPorId(id);

                if (EmpresaPorId == null)
                {
                    throw new Exception($"Empresa para o ID: {id} não foi localizado.");
                }

                EmpresaPorId.NomeEmpresa = empresa.NomeEmpresa;
                EmpresaPorId.NomeFantasia = empresa.NomeFantasia;
                EmpresaPorId.RamoAtividade = empresa.RamoAtividade;

                _dbContext.Empresa.Update(EmpresaPorId);
                await _dbContext.SaveChangesAsync();

                return EmpresaPorId;

            }
            catch (Exception ex)
            {
                //Tratamento de erro simplificado, o correto seria um tratamento padronizado por código e salvamento do log.
                //Feito dessa forma só para agilizar o processo.
                throw new Exception(ex.InnerException.Message);
            }
        }
        //Realiza um delete de uma Empresa especifica.
        public async Task<bool> DeletarEmpresa(int id)
        {
            try
            {
                EmpresaModel EmpresaPorId = await BuscarEmpresaPorId(id);

                if (EmpresaPorId == null)
                {
                    throw new Exception($"Empresa para o ID: {id} não foi localizado.");
                }

                _dbContext.Empresa.Remove(EmpresaPorId);
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
