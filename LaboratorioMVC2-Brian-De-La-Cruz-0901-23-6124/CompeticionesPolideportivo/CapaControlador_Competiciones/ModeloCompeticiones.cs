using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Competiciones.Contratos;
using CapaModelo_Competiciones.Entidades;
using CapaModelo_Competiciones.Repositorio;
using System.ComponentModel.DataAnnotations;

namespace CapaControlador_Competiciones
{
    public class ModeloCompeticiones
    {
        private int _idPartido;
        private DateTime _fechaPartido;
        private TimeSpan _horaPartido;
        private int _marcadorLocalPartido;
        private int _marcadorVisitantePartido;
        private int _idMejorJugador_Partido;
        private int _idEstadoPartido_Partido;
        private int _idJornada_Partido;
        private int _idCampo_Partido;
        private int _idArbitro_Partido;
        private int _idEquipoLocal_Partido;
        private int _idEquipoVisitante_Partido;
        private IRepositorioCompeticiones RepositorioCompeticiones;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloCompeticiones> ListaCompeticiones;

        public int IdPartido { get => _idPartido; set => _idPartido = value; }

        [Required(ErrorMessage = "El campo numero de identificacion es obligatorio")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo numero de identificacion solo puede contener numeros")]
        [StringLength(maximumLength:10, MinimumLength = 1, ErrorMessage = "El campo numero de identificacion debe tener entre 1 y 10 caracteres")]

        public DateTime FechaPartido { get => _fechaPartido; set => _fechaPartido = value; }

        public TimeSpan HoraPartido { get => _horaPartido; set => _horaPartido = value; }

        public int MarcadorLocalPartido { get => _marcadorLocalPartido; set => _marcadorLocalPartido = value; }

        public int MarcadorVisitantePartido { get => _marcadorVisitantePartido; set => _marcadorVisitantePartido = value; }

        public int IdMejorJugador_Partido { get => _idMejorJugador_Partido; set => _idMejorJugador_Partido = value; }

        public int IdEstadoPartido_Partido { get => _idEstadoPartido_Partido; set => _idEstadoPartido_Partido = value; }

        public int IdJornada_Partido { get => _idJornada_Partido; set => _idJornada_Partido = value; }

        public int IdCampo_Partido { get => _idCampo_Partido; set => _idCampo_Partido = value; }

        public int IdArbitro_Partido { get => _idArbitro_Partido; set => _idArbitro_Partido = value; }

        public int IdEquipoLocal_Partido { get => _idEquipoLocal_Partido; set => _idEquipoLocal_Partido = value; }

        public int IdEquipoVisitante_Partido { get => _idEquipoVisitante_Partido; set => _idEquipoVisitante_Partido = value; }

       public ModeloCompeticiones()
        {
            RepositorioCompeticiones = new RepositorioCompeticiones();
        }
        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var modeloDatosCompeticiones = new Competiciones();
                modeloDatosCompeticiones.IdPartido = _idPartido;
                modeloDatosCompeticiones.FechaPartido = _fechaPartido;
                modeloDatosCompeticiones.HoraPartido = _horaPartido;
                modeloDatosCompeticiones.MarcadorLocalPartido = _marcadorLocalPartido;
                modeloDatosCompeticiones.MarcadorVisitantePartido = _marcadorVisitantePartido;
                modeloDatosCompeticiones.IdMejorJugador_Partido = _idMejorJugador_Partido;
                modeloDatosCompeticiones.IdEstadoPartido_Partido = _idEstadoPartido_Partido;
                modeloDatosCompeticiones.IdJornada_Partido = _idJornada_Partido;
                modeloDatosCompeticiones.IdCampo_Partido = _idCampo_Partido;
                modeloDatosCompeticiones.IdArbitro_Partido = _idArbitro_Partido;
                modeloDatosCompeticiones.IdEquipoLocal_Partido = _idEquipoLocal_Partido;
                modeloDatosCompeticiones.IdEquipoVisitante_Partido = _idEquipoVisitante_Partido;
                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        RepositorioCompeticiones.Agregar(modeloDatosCompeticiones);
                        mensaje = "Registro agregado correctamente";
                        break;
                    case EstadoEntidad.Modified:
                        RepositorioCompeticiones.Editar(modeloDatosCompeticiones);
                        mensaje = "Registro modificado correctamente";
                        break;
                    case EstadoEntidad.Deleted:
                        RepositorioCompeticiones.Remover(modeloDatosCompeticiones);
                        mensaje = "Registro eliminado correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            return mensaje;
        }
        public List<ModeloCompeticiones> GetAll()
        {
            var modeloDatosCompeticiones = RepositorioCompeticiones.GetAll();
            ListaCompeticiones = new List<ModeloCompeticiones>();
            foreach (Competiciones item in modeloDatosCompeticiones)
            {
                var fechaPartido = item.FechaPartido;
                ListaCompeticiones.Add(new ModeloCompeticiones
                {
                    IdPartido = item.IdPartido,
                    FechaPartido = item.FechaPartido,
                    HoraPartido = item.HoraPartido,
                    MarcadorLocalPartido = item.MarcadorLocalPartido,
                    MarcadorVisitantePartido = item.MarcadorVisitantePartido,
                    IdMejorJugador_Partido = item.IdMejorJugador_Partido,
                    IdEstadoPartido_Partido = item.IdEstadoPartido_Partido,
                    IdJornada_Partido = item.IdJornada_Partido,
                    IdCampo_Partido = item.IdCampo_Partido,
                    IdArbitro_Partido = item.IdArbitro_Partido,
                    IdEquipoLocal_Partido = item.IdEquipoLocal_Partido,
                    IdEquipoVisitante_Partido = item.IdEquipoVisitante_Partido
                });
            }
            return ListaCompeticiones;
        }
        public IEnumerable<ModeloCompeticiones> FindbyId(string filter)
        {
            return ListaCompeticiones.FindAll(e=> e.IdPartido.ToString().Contains(filter) || e._idEstadoPartido_Partido.ToString().Contains(filter));
        }


    }
}
