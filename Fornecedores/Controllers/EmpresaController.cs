using SistemaListaFornecedores.Models;
using SistemaListaFornecedores.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SistemaListaFornecedores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;

        public EmpresaController(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }
        //GET /api/empresa
        [HttpGet]
        public async Task<ActionResult<List<EmpresaModel>>> BuscarTodosFornecedores()
        {
            List<EmpresaModel> empresa = await _empresaRepositorio.BuscarTodasEmpresas();
            return Ok(empresa);
           
        }
        //GET /api/empresa/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpresaModel>> BuscarEmpresaPorId(int id)
        {
            EmpresaModel empresa = await _empresaRepositorio.BuscarEmpresaPorId(id);
            
            return Ok(empresa);
        }
        //POST /api/empresa
        [HttpPost]
        public async Task<ActionResult<EmpresaModel>> Cadastrar([FromBody] EmpresaModel empresaModel)
        {
            EmpresaModel empresa = await _empresaRepositorio.AdicionarEmpresa(empresaModel);

            return Ok(empresa);
        }
        //PUT /api/empresa/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<EmpresaModel>> AtualizarEmpresa([FromBody] EmpresaModel empresaModel, int id)
        {
            empresaModel.Id = id;
            EmpresaModel empresa = await _empresaRepositorio.AtualizarEmpresa(empresaModel, id);

            return Ok(empresa);
        }
        //DELETE /api/empresa/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmpresaModel>> DeletarEmpresa(int id)
        {
            bool apagado = await _empresaRepositorio.DeletarEmpresa(id);

            return Ok(apagado);
        }
    }
}
