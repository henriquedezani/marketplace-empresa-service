using System;
using Empresas.Domain.Entities;
using Empresas.Domain.Ports;
using Empresas.Domain.Services;
using Empresas.Infra.Repositories;

namespace Empresas.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmpresaRepository repository = new EmpresaRepository();
            IEmpresaService empresaService = new EmpresaService(repository);

            Empresa empresa1 = new Empresa();
            empresa1.Id = 1;
            empresa1.Nome = "Empresa 1";
            empresa1.Slug = "empresa1";

            Empresa empresaCriada = empresaService.CriaUmEmpresa(empresa1);

            if(empresaCriada != null) 
                Console.WriteLine("Empresa criada com sucesso");
            else
                Console.WriteLine("Já existe uma empresa com este slug");

            Empresa empresa2 = new Empresa();
            empresa2.Id = 1;
            empresa2.Nome = "Empresa 2";
            empresa2.Slug = "empresa2";

            Empresa empresaCriada2 = empresaService.CriaUmEmpresa(empresa2);

            if(empresaCriada2 != null) 
                Console.WriteLine("Empresa criada com sucesso");
            else 
                Console.WriteLine("Já existe uma empresa com este slug");


            var lista = empresaService.ObtemTodasAsEmpresas();

            foreach(var empresa in lista) {
                Console.WriteLine(empresa.Nome);
            }
        }
    }
}
