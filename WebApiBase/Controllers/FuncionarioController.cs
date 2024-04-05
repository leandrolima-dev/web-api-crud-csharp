using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
