using System.Collections.Generic;
using Empresas.Domain.DTOs;
using Empresas.Domain.Entities;
using Empresas.Domain.Ports;

namespace Empresas.Domain.Services
{
    // Programar para interfaces, não para implementações.
    public class EmpresaService : IEmpresaService
    {
        public void CriaUmEmpresa(Empresa empresa)
        {
            // regras de negócio
            // Exemplo: Não pode haver duas empresas com o mesmo slug.
        }

        public IEnumerable<EmpresaDTO> ObtemTodasAsEmpresas()
        {
            // regras de negócio
            // Exemplos: 
            // - Não exibir produtos sem estoque.
            // - Exibir empresas com mais quantidade de vendas.
            return null;
        }
    }
}