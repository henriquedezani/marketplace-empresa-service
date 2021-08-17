using System;
using Empresas.Domain.Entities;

namespace Empresas.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa1 = new Empresa() {
                Nome = "Empresa 1",
                Endereco = "Rua ABC",
                Telefone = "(17) 123123123",
                Id = 1,
                Slug = "empresa1"
            };


            Console.WriteLine(empresa1.Id); // get
            Console.WriteLine(empresa1.Nome); // get
            Console.WriteLine(empresa1.Endereco); // get
            Console.WriteLine(empresa1.Telefone); // get
            Console.WriteLine(empresa1.Slug); // get
        }
    }
}
