namespace OrderManagement.Domain.Entities
{
    public class Idempotencia
    {
        public long Id { get; set; }

        public string Chave { get; set; } = string.Empty;

        public long PedidoId { get; set; }

        public DateTime DataCriacao { get; set; }

        public long Resposta { get; set; }
    }
}