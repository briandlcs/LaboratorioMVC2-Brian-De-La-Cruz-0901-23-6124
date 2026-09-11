using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Competiciones.Contratos;
using CapaModelo_Competiciones.Entidades;
using System.Data;

namespace CapaModelo_Competiciones.Repositorio
{
    public class RepositorioCompeticiones : RepositorioMaestro, IRepositorioCompeticiones
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public RepositorioCompeticiones()
        {
            selectAll = "SELECT *FROM Competiciones";
            insert = "INSERT INTO Competiciones value(NULL, ?,?,?,?,?,?,?,?,?,?,?)";
            update = "UPDATE Competiciones SET FechaPartido=?, HoraPartido=?, MarcadorLocalPartido=?, MarcadorVisitantePartido=?, IdMejorJugador_Partido=?, IdEstadoPartido_Partido=?, IdJornada_Partido=?, IdCampo_Partido=?, IdArbitro_Partido=?, IdEquipoLocal_Partido=?, IdEquipoVisitante_Partido=? WHERE IdPartido=?";
            delete = "DELETE FROM Competiciones WHERE IdPartido=?";
        }
        public int Agregar(Competiciones entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_FechaPartido", entidad.FechaPartido));
            _parametros.Add(new OdbcParameter("p_HoraPartido", entidad.HoraPartido));
            _parametros.Add(new OdbcParameter("p_MarcadorLocalPartido", entidad.MarcadorLocalPartido));
            _parametros.Add(new OdbcParameter("p_MarcadorVisitantePartido", entidad.MarcadorVisitantePartido));
            _parametros.Add(new OdbcParameter("p_IdMejorJugador_Partido", entidad.IdMejorJugador_Partido));
            _parametros.Add(new OdbcParameter("p_IdEstadoPartido_Partido", entidad.IdEstadoPartido_Partido));
            _parametros.Add(new OdbcParameter("p_IdJornada_Partido", entidad.IdJornada_Partido));
            _parametros.Add(new OdbcParameter("p_IdCampo_Partido", entidad.IdCampo_Partido));
            _parametros.Add(new OdbcParameter("p_IdArbitro_Partido", entidad.IdArbitro_Partido));
            _parametros.Add(new OdbcParameter("p_IdEquipoLocal_Partido", entidad.IdEquipoLocal_Partido));
            _parametros.Add(new OdbcParameter("p_IdEquipoVisitante_Partido", entidad.IdEquipoVisitante_Partido));
            return EjecucionNonQuery(insert, _parametros, CommandType.Text);
        }
        public int Editar(Competiciones entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_FechaPartido", entidad.FechaPartido));
            _parametros.Add(new OdbcParameter("p_HoraPartido", entidad.HoraPartido));
            _parametros.Add(new OdbcParameter("p_MarcadorLocalPartido", entidad.MarcadorLocalPartido));
            _parametros.Add(new OdbcParameter("p_MarcadorVisitantePartido", entidad.MarcadorVisitantePartido));
            _parametros.Add(new OdbcParameter("p_IdMejorJugador_Partido", entidad.IdMejorJugador_Partido));
            _parametros.Add(new OdbcParameter("p_IdEstadoPartido_Partido", entidad.IdEstadoPartido_Partido));
            _parametros.Add(new OdbcParameter("p_IdJornada_Partido", entidad.IdJornada_Partido));
            _parametros.Add(new OdbcParameter("p_IdCampo_Partido", entidad.IdCampo_Partido));
            _parametros.Add(new OdbcParameter("p_IdArbitro_Partido", entidad.IdArbitro_Partido));
            _parametros.Add(new OdbcParameter("p_IdEquipoLocal_Partido", entidad.IdEquipoLocal_Partido));
            _parametros.Add(new OdbcParameter("p_IdEquipoVisitante_Partido", entidad.IdEquipoVisitante_Partido));
            _parametros.Add(new OdbcParameter("p_IdPartido", entidad.IdPartido));
            return EjecucionNonQuery(update, _parametros, CommandType.Text);
        }
        public int Remover(Competiciones entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_IdPartido", entidad.IdPartido));
            return EjecucionNonQuery(delete, _parametros, CommandType.Text);
        }
        public IEnumerable<Competiciones> GetAll()
        {
            var lstCompeticiones = new List<Competiciones>();
            var TblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in TblTabla.Rows)
            {
                var competiciones = new Competiciones();
                competiciones.IdPartido = Convert.ToInt32(row[0]);
                competiciones.FechaPartido = Convert.ToDateTime(row[1]);
                competiciones.HoraPartido = (TimeSpan)row[2];
                competiciones.MarcadorLocalPartido = Convert.ToInt32(row[3]);
                competiciones.MarcadorVisitantePartido = Convert.ToInt32(row[4]);
                competiciones.IdMejorJugador_Partido = Convert.ToInt32(row[5]); 
                competiciones.IdEstadoPartido_Partido = Convert.ToInt32(row[6]);
                competiciones.IdJornada_Partido = Convert.ToInt32(row[7]);
                competiciones.IdCampo_Partido = Convert.ToInt32(row[8]);
                competiciones.IdArbitro_Partido = Convert.ToInt32(row[9]);
                competiciones.IdEquipoLocal_Partido = Convert.ToInt32(row[10]);
                competiciones.IdEquipoVisitante_Partido = Convert.ToInt32(row[11]);
                lstCompeticiones.Add(competiciones);    
            }
            TblTabla.Clear();
            TblTabla = null;
            return lstCompeticiones;
        }
    }
}
