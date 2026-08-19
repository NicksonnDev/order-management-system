namespace OrderManagement.Domain.Entities
{
    public class ItemPedido
    {
        public long Id { get; set; }

        public long PedidoId { get; set; }

        public long ProdutoId { get; set; }

        public string NomeProduto { get; set; } = string.Empty;

        public int Quantidade { get; set; }

        public decimal PrecoUnitario { get; set; }

        public decimal ValorTotal { get; set; }
    }
}