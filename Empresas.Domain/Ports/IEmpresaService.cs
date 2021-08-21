using System.Collections.Generic;
using Empresas.Domain.DTOs;
using Empresas.Domain.Entities;

namespace Empresas.Domain.Ports
{
    // "Contrato"
    public interface IEmpresaService
    {
        IEnumerable<EmpresaDTO> ObtemTodasAsEmpresas();
        void CriaUmEmpresa(Empresa empresa);
    }
}