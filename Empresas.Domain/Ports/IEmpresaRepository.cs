using System.Collections.Generic;
using Empresas.Domain.Entities;

namespace Empresas.Domain.Ports
{
    public interface IEmpresaRepository
    {
        Empresa Create(Empresa empresa);
        Empresa Read(string slug);
        IEnumerable<Empresa> ReadEmpresasComEstoque();
    }
}