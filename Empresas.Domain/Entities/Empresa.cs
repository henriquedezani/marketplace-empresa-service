using System.Linq;
using System.Collections.Generic;

namespace Empresas.Domain.Entities
{
    public class Empresa 
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Slug { get; set; }
        public IEnumerable<Produto> Produtos { get; set; } = new List<Produto>();

        public void AddProduto(Produto produto)
        {
            var lista = Produtos.ToList();
            lista.Add(produto);
            this.Produtos = lista;
        }
    }
}
