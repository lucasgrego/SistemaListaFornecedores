using SistemaListaFornecedores.Models;
using SistemaListaFornecedores.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SistemaListaFornecedores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedoresRepositorio _fornecedoresRepositorio;

        public FornecedoresController(IFornecedoresRepositorio fornecedoresRepositorio)
        {
            _fornecedoresRepositorio = fornecedoresRepositorio;
        }
        //GET /api/fornecedores
        [HttpGet]
        public async Task<ActionResult<List<FornecedoresModel>>> BuscarTodosFornecedores()
        {
            List<FornecedoresModel> fornecedores = await _fornecedoresRepositorio.BuscarTodosFornecedores();
            return Ok(fornecedores);
        }
        //GET /api/fornecedores/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<FornecedoresModel>> BuscarFornecedoresPorId(int id)
        {
            FornecedoresModel fornecedores = await _fornecedoresRepositorio.BuscarFornecedoresPorId(id);
            return Ok(fornecedores);
        }
        //POST /api/fornecedores
        [HttpPost]
        public async Task<ActionResult<FornecedoresModel>> Cadastrar([FromBody] FornecedoresModel fornecedorModel)
        {
            FornecedoresModel fornecedor = await _fornecedoresRepositorio.AdicionarFornecedores(fornecedorModel);

            return Ok(fornecedor);
        }
        //PUT /api/fornecedores/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<FornecedoresModel>> AtualizarFornecedores([FromBody] FornecedoresModel fornecedorModel, int id)
        {
            fornecedorModel.Id = id;
            FornecedoresModel fornecedor = await _fornecedoresRepositorio.AtualizarFornecedores(fornecedorModel, id);

            return Ok(fornecedor);
        }
        //DELETE /api/fornecedores/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<FornecedoresModel>> DeletarFornecedores(int id)
        {
            bool apagado = await _fornecedoresRepositorio.DeletarFornecedores(id);

            return Ok(apagado);
        }
    }
}
