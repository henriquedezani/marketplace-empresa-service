namespace Empresas.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Empresa Empresa { get; private set; } //composição (has-a)

        public Produto(Empresa empresa)
        {
            this.Empresa = empresa;
            this.Empresa.AddProduto(this);
        }
    }
}