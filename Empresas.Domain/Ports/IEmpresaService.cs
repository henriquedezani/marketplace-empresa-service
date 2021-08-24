using System.Collections.Generic;
using Empresas.Domain.Entities;

namespace Empresas.Domain.Ports
{
    // "Contrato"
    public interface IEmpresaService
    {
        IEnumerable<Empresa> ObtemTodasAsEmpresas();
        Empresa CriaUmEmpresa(Empresa empresa);
    }
}