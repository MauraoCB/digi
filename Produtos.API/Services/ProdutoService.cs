using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Produtos.API.Domain.Entities;
using System.Text.Json;
using System.Configuration;
namespace Produtos.API.Services
{
    public static class ProdutoService
    {
        /// <summary>
        /// Retorna a lista de produtos a partir de um arquivo json
        /// </summary>
        /// <returns>List de objetos da classe Produto</returns>
 
        public static List<Produto>? ListProdutos ()
        {
            try
            {
                string jsonPath = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["jsonPath"];

                string jsonString = File.ReadAllText(jsonPath);
                List<Produto>? produtos = JsonConvert.DeserializeObject<List<Produto>>(jsonString);

                return produtos;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao ler arquivo json", ex);
            }
        }
    }
}
