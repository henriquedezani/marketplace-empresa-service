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
            Console.WriteLine(empresa1.GetNome());
            Console.WriteLine(empresa1.GetSlug() ?? "NULO");

            Empresa empresa2 = new Empresa("Empresa 2", "empresa_2");  // sobrecarga do construtor.
            Console.WriteLine(empresa2.GetNome());
            Console.WriteLine(empresa2.GetNome(true));
            Console.WriteLine(empresa2.GetNome(false));
            Console.WriteLine(empresa2.GetSlug() ?? "NULO");
        }
    }
}
