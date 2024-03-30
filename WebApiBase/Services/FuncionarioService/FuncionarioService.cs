using WebApiBase.Models;

namespace WebApiBase.Services.FuncionarioService
{
    public class FuncionarioService : IFuncionarioInterface
    {
        public Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios()
        {
            throw new NotImplementedException();
        }
    }
}
