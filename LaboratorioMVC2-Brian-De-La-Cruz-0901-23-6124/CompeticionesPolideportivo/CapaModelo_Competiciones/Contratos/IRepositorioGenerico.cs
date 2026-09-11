using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Competiciones.Contratos
{
    public interface IRepositorioGenerico<Entity> where Entity : class
    {
        int Agregar(Entity entidad); //agregar
        int Editar(Entity entidad); //editar
        int Remover(Entity entidad); //eliminar
        IEnumerable<Entity> GetAll(); //obtener todos
    }
}
