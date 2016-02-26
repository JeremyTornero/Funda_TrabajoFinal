using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Funciones
{
    public class nObjetoEncontrado
    {
         dObjetoEncontrado objetoEncontrado;

        public nObjetoEncontrado()
        {
            objetoEncontrado = new dObjetoEncontrado(); 
        }

        public string Registrarobjeto(string nombre_objeto, string fecha)
        {
            ObjetoEncontrado objeto = new ObjetoEncontrado()
            {
                NombreObjetoEncontrado = nombre_objeto,
                Fecha=fecha
            };
            return objetoEncontrado.Insertar(objeto);
        }

        public string Modificarobjeto(int idobjeto, string nombreobjeto, string fecha)
        {
            ObjetoEncontrado objeto = new ObjetoEncontrado()
            {
                IdObjetoEncontrado = idobjeto,
                NombreObjetoEncontrado = nombreobjeto,
                Fecha=fecha
            };
            return objetoEncontrado.Modificar(objeto);
        }

        public string Eliminarobjeto(int id)
        {
            return objetoEncontrado.Eliminar(id);
        }

        public List<ObjetoEncontrado> Listarobjeto()
        {
            return objetoEncontrado.ListarTodo();
        }
    }
}
