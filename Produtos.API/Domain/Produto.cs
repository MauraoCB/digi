using Newtonsoft.Json;
using System.Text.Json;

namespace Produtos.API.Domain.Entities
{
    public class Produto
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("detail")]
        public string? Detail { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("image")]
        public string? Image { get; set; }

        [JsonProperty("info")]
        public string? Info { get; set; }

        [JsonProperty("offer")]
        public string? Offer { get; set; }
    }
}
