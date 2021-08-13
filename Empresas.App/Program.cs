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

            Empresa empresa1 = new Empresa("Empresa 1");

            empresa1.Nome = "Minha empresa"; // set

            Console.WriteLine(empresa1.Nome); // get
        }
    }
}
