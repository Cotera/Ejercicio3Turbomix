using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaRepository : IRecetaRepository
    {
        private IList<Receta> repositorio = new List<Receta>();

        public void add(Receta receta)
        {
            repositorio.Add(receta);
        }

		public void delete(string nombre)
		{
			throw new NotImplementedException();
		}

		public Receta lee(string Nombre)
		{
			return new Receta("Macarrones", "Tomate", 150F, 50F);
		}

		public IList<Receta> lista()
		{
			return repositorio;
		}

		public void update(Receta receta)
		{
			repositorio.Add(receta);
		}
	}
}
