using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2 
{
    public interface IRecetaRepository
    {
        void add(Receta receta);

		Receta lee(string Nombre);

		IList<Receta> lista();

		void update(Receta receta);

		void delete(string nombre);
    }
}
