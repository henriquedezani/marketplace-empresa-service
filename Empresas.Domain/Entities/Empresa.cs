namespace Empresas.Domain.Entities
{
    public class Empresa 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Slug { get; set; }
    }
}
