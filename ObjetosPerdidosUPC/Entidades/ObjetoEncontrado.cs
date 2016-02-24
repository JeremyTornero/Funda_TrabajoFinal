using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class ObjetoEncontrado
    {
        public int IdObjetoEncontrado { get; set; }
        public string NombreObjetoEncontrado { get; set; }

        public override string ToString()
        {
            return NombreObjetoEncontrado;
        }
    }
}
