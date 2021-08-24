using System.Collections.Generic;
using Empresas.Domain.Entities;
using Empresas.Domain.Ports;

namespace Empresas.Infra.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        static List<Empresa> empresas = new List<Empresa>();

        public Empresa Create(Empresa empresa)
        {
            // INSERT INTO Empresas ....
            empresas.Add(empresa);
            return empresa;
        }

        public Empresa Read(string slug)
        {
            // SELECT * FROM Empresas WHERE Slug = slug...
            foreach(var empresa in empresas) {
                if (empresa.Slug == slug)
                    return empresa;
            }

            return null;
        }

        public IEnumerable<Empresa> ReadEmpresasComEstoque()
        {
            return empresas;
        }
    }
}