using System;
using Empresas.Domain.Entities;

namespace Empresas.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando um objeto da classe Empresa (instância da classe).
            Empresa objeto = new Empresa();
            objeto.SetNome(args[0]);            
            string nome = objeto.GetNome();

            Console.WriteLine(nome);
        }
    }
}
