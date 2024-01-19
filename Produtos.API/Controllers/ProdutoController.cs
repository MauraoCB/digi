using Microsoft.AspNetCore.Mvc;
using Produtos.API.Domain.Entities;
using Produtos.API.Services;
using System.Reflection.Metadata.Ecma335;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Produtos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        [HttpGet] 
        public List<Produto> Get() {

            return ProdutoService.ListProdutos();
        }
    }
}
