namespace Empresas.Domain.Entities
{
    public class Empresa 
    {
        // propridade automática (campo + propriedade)
        // public string Nome { get; private set; } // read-only
        // public string Nome { get; } // read-only
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }


        // construtor
        // public Empresa(string nome)
        // {
        //     this.Nome = nome;
        // }

        // propriedades:
        // é o que o compilador gerará usando public string Nome {get; set;}
        // private string nome;
        // public string Nome
        // {
        //     get { return this.nome; } 
        //     set { this.nome = value; }
        // }
    }
}
