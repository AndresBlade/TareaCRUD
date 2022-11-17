using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCRUD
{
    public class EquipoFutbol
    {
        public EquipoFutbol(string nombreEquipo, string confederacion, int numParticipaciones, int numFederados)
        {
            NombreEquipo = nombreEquipo;
            Confederacion = confederacion;
            NumParticipaciones = numParticipaciones;
            NumFederados = numFederados;
        }

        public string NombreEquipo { get; set; }
        public string Confederacion { get; set; }
        public int NumParticipaciones { get; set; }
        public int NumFederados { get; set; }
    }
}
