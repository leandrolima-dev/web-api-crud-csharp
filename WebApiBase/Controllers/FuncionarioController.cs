using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiBase.Models;
using WebApiBase.Services.FuncionarioService;

namespace WebApiBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _fucionarioInterface;
        public FuncionarioController(IFuncionarioInterface fucionarioInterface)
        {
            _fucionarioInterface = fucionarioInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
        {
            return Ok(await _fucionarioInterface.GetFuncionarios());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> GetFuncionarioById(int id)
        {
            ServiceResponse<FuncionarioModel> serviceResponse = await _fucionarioInterface.GetFuncionarioById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            return Ok(await _fucionarioInterface.CreateFuncionario(novoFuncionario));
        }

        [HttpPut("atualizaFuncionario")]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> UpdateFuncionario(FuncionarioModel editatoFuncionario)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _fucionarioInterface.UpdateFuncionario(editatoFuncionario);

            return Ok(serviceResponse);
        }

        [HttpPut("inativaFuncionario")]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> InactiveFuncionario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _fucionarioInterface.InactiveFuncionario(id);

            return Ok(serviceResponse);
        }

        [HttpDelete("deletaFuncionario")]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> DeleteFuncionario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _fucionarioInterface.DeleteFuncionario(id);

            return Ok(serviceResponse);
        }
    }
}
