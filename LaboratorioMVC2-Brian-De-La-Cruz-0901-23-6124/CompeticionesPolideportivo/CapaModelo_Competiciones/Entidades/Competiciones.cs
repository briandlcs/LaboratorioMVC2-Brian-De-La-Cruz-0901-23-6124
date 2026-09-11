using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Competiciones.Entidades
{
    public class Competiciones
    {
        public int IdPartido { get; set; }
        public DateTime FechaPartido { get; set; }
        public TimeSpan HoraPartido { get; set; }
        public int MarcadorLocalPartido { get; set; }
        public int MarcadorVisitantePartido { get; set; }
        public int IdMejorJugador_Partido { get; set; }
        public int IdEstadoPartido_Partido { get; set; }
        public int IdJornada_Partido { get; set; }
        public int IdCampo_Partido { get; set; }
        public int IdArbitro_Partido { get; set; }
        public int IdEquipoLocal_Partido { get; set; }
        public int IdEquipoVisitante_Partido { get; set; }
    }
}
