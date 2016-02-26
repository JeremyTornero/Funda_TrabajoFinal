using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Funciones
{
    public class nPropietario
    {
        dPropietario propietario;

        public nPropietario()
        {
            propietario = new dPropietario(); 
        }

        public string Registrarpropietario(string nombrepropietario, string apellido, int idobjeto, string fecha, string fecha_devolucion)
        {
            ObjetoEncontrado objeto = new ObjetoEncontrado()
            {
                IdObjetoEncontrado = idobjeto
            };

            Propietario prop = new Propietario()
            {
                   Nombre=nombrepropietario,
                   Apellidos=apellido,
                   Objeto=objeto,
                   Fecha_Ingreso=fecha,
                   Fecha_Devolucion=fecha_devolucion
            };

            return propietario.Insertar(prop);
        }

        public string Modificarpropietario(int idpropietario, string nombrepropietario, string apellido, int idobjeto,string fecha, string fecha_salida)
        {
            ObjetoEncontrado objeto = new ObjetoEncontrado()
            {
                IdObjetoEncontrado = idobjeto
            };

            Propietario prop = new Propietario()
            {
                IdPropietario = idpropietario,
                Nombre = nombrepropietario,
                Apellidos = apellido,
                Objeto = objeto,
                Fecha_Ingreso=fecha,
                Fecha_Devolucion=fecha_salida
            };
            return propietario.Modificar(prop);
        }

        public string Eliminarpropietario(int id)
        {
            return propietario.Eliminar(id);
        }

        public List<Propietario> Listarpropietario()
        {
            return propietario.ListarTodo();
        }
    }
}
