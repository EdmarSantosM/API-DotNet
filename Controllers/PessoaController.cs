using System.Threading.Tasks;
using API_DotNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_DotNet.Models;

namespace API_DotNet.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private DataContext dc; /* Acesso  as  funçoes  Create, Update, Delete etc */
        public PessoaController(DataContext context)
        {
            this.dc = context;
        }

        [HttpPost("api")]
        
        /* método  de cadastro */
        public async Task<ActionResult> cadastrar([FromBody]Pessoa p)
        {
            dc.pessoa.Add(p);
            await dc.SaveChangesAsync();

            return Created("Objeto pessoa", p);
        }

        [HttpGet("oi")]
        public string oi()
        {
            return "Exemplo de criação de Rota";
        }
    }
}