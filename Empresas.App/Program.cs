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

            Console.WriteLine(empresa1.Id); // get
            Console.WriteLine(empresa1.Nome); // get
            Console.WriteLine(empresa1.Endereco); // get
            Console.WriteLine(empresa1.Telefone); // get
            Console.WriteLine(empresa1.Slug); // get

            Produto produto1 = new Produto(empresa1);
            produto1.Nome = "geladeira";
            produto1.Preco = 1000.50M; //M para decimal

            //empresa1.Produtos.Add(produto1); //NÃO FAZER DESSA MANEIRA!

            Console.WriteLine(produto1.Nome);
            Console.WriteLine(produto1.Preco);
            Console.WriteLine(produto1.Empresa.Nome);

            foreach (Produto produto in empresa1.Produtos)
            {
                Console.WriteLine(produto.Nome);
            }
        }
    }
}
