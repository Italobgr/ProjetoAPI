namespace ProjetoAPI.API.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ApartamentoId { get; set; }
        public DateTime DataVenda { get; set; }

        public Cliente Cliente { get; set; }
        public Apartamento Apartamento { get; set; }
    }
}
