using System.Collections.Generic;
using Empresas.Domain.Entities;
using Empresas.Domain.Ports;

namespace Empresas.Domain.Services
{
    // Programar para interfaces, não para implementações.
    public class EmpresaService : IEmpresaService
    {
        private IEmpresaRepository repository;

        // INJEÇÃO DE DEPENDÊNCIAS
        public EmpresaService(IEmpresaRepository repository) 
        {
            this.repository = repository;
        }

        public Empresa CriaUmEmpresa(Empresa empresa)
        {
            // regras de negócio
            // Não pode haver duas empresas com o mesmo slug.
            var _empresa = repository.Read(empresa.Slug);

            if(_empresa != null)
            {
                // já existe um empresa com o slug informado.
                // Fail Fast
                return null;
            }
            else 
            {
                return repository.Create(empresa);
            }
        }

        public IEnumerable<Empresa> ObtemTodasAsEmpresas()
        {
            // regras de negócio
            // Exemplos: 
            // - Não exibir produtos sem estoque.
            return repository.ReadEmpresasComEstoque();
        }
    }
}