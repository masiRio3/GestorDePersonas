using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePersonas.Modelos
{
    public sealed class Desempleado : Persona
    {

        public string UltimaOcupacion { get; set; }
        public string UltimaEmpresa { get; set; }
        public bool esDiscapacitado { get; set; }
        
        public int ObtenerValorDePension ()
        {
            if (esDiscapacitado)
            {
                return 13000;
            }

            else
            {
                return 10000;
            }
        }

    }
}
