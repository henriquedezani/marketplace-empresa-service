namespace Empresas.Domain.Entities
{
    public class Empresa 
    {
        // estados (campos ou fields)
        private string nome;

        // comportamentos (métodos)
        public void SetNome(string nome)
        {
            // alterar o estado da classe (atributo nome)
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }
    }
}



// tipo_do_retorno nome_do_metodo (tipo1: argumento1, tipo2: argumento2, ...) {
//   lógica do negócio...
//   tipo_do_retorno != void = return
//}