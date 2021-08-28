using System.Threading.Tasks;
using API_DotNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_DotNet.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class PessoaController
    {
        [HttpGet("oi")]
        public string oi()
        {
            return "Exemplo de criação de Rota";
        }
    }
}