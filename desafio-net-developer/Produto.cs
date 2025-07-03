namespace TesteDesenvolvimento
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
