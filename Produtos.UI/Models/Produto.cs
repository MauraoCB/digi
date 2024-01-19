namespace Produtos.UI.Models
{
    public class Produto
    {
        public string? Name { get; set; }
        public string? Detail { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public string? Info { get; set; }
        public string? Offer { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get { return Quantity * Price; } }
    }
}
