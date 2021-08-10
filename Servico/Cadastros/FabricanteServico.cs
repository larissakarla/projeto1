using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Cadastros;
using Persistencia.DAL.Cadastros;

namespace Servico.Cadastros
{
    public class FabricanteServico
    {
        private FabricanteDAL fabricanteDAL = new FabricanteDAL();
        public IQueryable<Fabricante> ObterFabricantesClassificadosPorNome()
        {
            return fabricanteDAL.ObterFabricantesClassificadosPorNome();
        }

        public Fabricante ObterFabricantePorId(long id)
        {
            return context.Fabricantes.Where(f => f.FabricanteId == id).First();
        }
        public void GravarFabricante(Fabricante fabricante)
        {
            if (fabricante.FabricanteId == 0)
            {
                context.Fabricantes.Add(fabricante);
            }
            else
            {
                context.Entry(fabricante).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Fabricante EliminarFabricantePorId(long id)
        {
            Fabricante fabricante = ObterFabricantePorId(id);
            context.Fabricantes.Remove(fabricante);
            context.SaveChanges();
            return fabricante;
        }
    }
}
