using System;
using Empresas.Domain.Entities;

namespace Empresas.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando um objeto da classe Empresa (instância da classe).
            //new Empresa() = // método para instanciar a classe = construtor.

            Empresa empresa1 = new Empresa() {
                Nome = "Empresa 1",
                Endereco = "Rua ABC",
                Telefone = "(17) 123123123"
            };

            // empresa1.Nome = "Minha empresa"; // set
            // empresa1.Endereco = "Minha empresa"; // set
            // empresa1.Telefone = "Minha empresa"; // set


            Console.WriteLine(empresa1.Nome); // get
            Console.WriteLine(empresa1.Endereco); // get
            Console.WriteLine(empresa1.Telefone); // get
        }
    }
}
