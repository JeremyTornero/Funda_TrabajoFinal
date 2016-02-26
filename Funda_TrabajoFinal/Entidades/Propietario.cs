using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Propietario
    {
        public int IdPropietario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public ObjetoEncontrado Objeto { get; set; }
        public string Fecha_Ingreso { get; set; }
        public string Fecha_Devolucion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
