using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_Competiciones;

namespace CapaVista_Competiciones.Formas
{
    public partial class FrmCompeticiones : Form
    {
        private ModeloCompeticiones competicion = new ModeloCompeticiones();
        public FrmCompeticiones()
        {
            InitializeComponent();
            panIngresarDatos.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCompeticiones_Load(object sender, EventArgs e)
        {
            listaCompeticiones();
        }

        private void listaCompeticiones()
        {
            try
            {
                dgvCompeticiones.DataSource = competicion.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCompeticiones.DataSource = competicion.FindbyId(txtBuscar.Text);
        }

        private void dgvCompeticiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvCompeticiones.DataSource = competicion.FindbyId(txtBuscar.Text);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Conversiones seguras: Si la caja está vacía se asigna 0 (o el ID existente)
                competicion.IdPartido = string.IsNullOrWhiteSpace(txtIdPartido.Text) ? 0 : Convert.ToInt32(txtIdPartido.Text);
                competicion.MarcadorLocalPartido = string.IsNullOrWhiteSpace(txtMarcadorLocal.Text) ? 0 : Convert.ToInt32(txtMarcadorLocal.Text);
                competicion.MarcadorVisitantePartido = string.IsNullOrWhiteSpace(txtMarcadorVisitante.Text) ? 0 : Convert.ToInt32(txtMarcadorVisitante.Text);

                // Aquí fallaba: si txtIdMejorJugador está vacío se asigna 0
                competicion.IdMejorJugador_Partido = string.IsNullOrWhiteSpace(txtIdMejorJugador.Text) ? 0 : Convert.ToInt32(txtIdMejorJugador.Text);

                competicion.IdEstadoPartido_Partido = string.IsNullOrWhiteSpace(txtIdEstadoPartido.Text) ? 0 : Convert.ToInt32(txtIdEstadoPartido.Text);
                competicion.IdJornada_Partido = string.IsNullOrWhiteSpace(txtIdJornada.Text) ? 0 : Convert.ToInt32(txtIdJornada.Text);
                competicion.IdCampo_Partido = string.IsNullOrWhiteSpace(txtIdCampo.Text) ? 0 : Convert.ToInt32(txtIdCampo.Text);
                competicion.IdArbitro_Partido = string.IsNullOrWhiteSpace(txtIdArbitro.Text) ? 0 : Convert.ToInt32(txtIdArbitro.Text);
                competicion.IdEquipoLocal_Partido = string.IsNullOrWhiteSpace(txtIdEquipoLocal.Text) ? 0 : Convert.ToInt32(txtIdEquipoLocal.Text);
                competicion.IdEquipoVisitante_Partido = string.IsNullOrWhiteSpace(txtIdEquipoVisitante.Text) ? 0 : Convert.ToInt32(txtIdEquipoVisitante.Text);

                competicion.FechaPartido = dtpFechaPartido.Value;
                competicion.HoraPartido = dtpHoraPartido.Value.TimeOfDay;

                // Ejecutar la validación con DataAnnotations
                bool valido = new Ayudas.ValidacionDatos(competicion).Validar();

                if (valido)
                {
                    string resultado = competicion.GrabarCambios();
                    MessageBox.Show(resultado);
                    listaCompeticiones();
                    Reincio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos: " + ex.Message);
            }
        }
        private void Reincio()
        {
            panIngresarDatos.Enabled = false;
            txtIdPartido.Clear();
            txtMarcadorLocal.Clear();
            txtIdEquipoLocal.Clear();
            txtIdEstadoPartido.Clear();
            txtIdMejorJugador.Clear();
            txtIdJornada.Clear();
            txtIdCampo.Clear();
            txtIdArbitro.Clear();
            txtIdEquipoVisitante.Clear();
            txtMarcadorVisitante.Clear();

            dtpFechaPartido.Value = DateTime.Today;
            dtpHoraPartido.Value = DateTime.Now;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panIngresarDatos.Enabled = true;
            competicion.Estado = EstadoEntidad.Added;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCompeticiones.SelectedRows.Count > 0)
            {
                panIngresarDatos.Enabled = true;
                competicion.Estado = EstadoEntidad.Modified;

                competicion.IdPartido = Convert.ToInt32(dgvCompeticiones.CurrentRow.Cells[0].Value);

                txtIdPartido.Text = dgvCompeticiones.CurrentRow.Cells[0].Value.ToString();
                dtpFechaPartido.Value = Convert.ToDateTime(dgvCompeticiones.CurrentRow.Cells[1].Value);

                if (dgvCompeticiones.CurrentRow.Cells[2].Value is TimeSpan horaSpan)
                {
                    dtpHoraPartido.Value = DateTime.Today.Add(horaSpan);
                }

                txtMarcadorLocal.Text = dgvCompeticiones.CurrentRow.Cells[3].Value.ToString();
                txtMarcadorVisitante.Text = dgvCompeticiones.CurrentRow.Cells[4].Value.ToString();
                txtIdMejorJugador.Text = dgvCompeticiones.CurrentRow.Cells[5].Value.ToString();
                txtIdEstadoPartido.Text = dgvCompeticiones.CurrentRow.Cells[6].Value.ToString();
                txtIdJornada.Text = dgvCompeticiones.CurrentRow.Cells[7].Value.ToString();
                txtIdCampo.Text = dgvCompeticiones.CurrentRow.Cells[8].Value.ToString();
                txtIdArbitro.Text = dgvCompeticiones.CurrentRow.Cells[9].Value.ToString();
                txtIdEquipoLocal.Text = dgvCompeticiones.CurrentRow.Cells[10].Value.ToString();
                txtIdEquipoVisitante.Text = dgvCompeticiones.CurrentRow.Cells[11].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvCompeticiones.SelectedRows.Count > 0)
            {
                competicion.Estado = EstadoEntidad.Deleted;

                competicion.IdPartido = Convert.ToInt32(dgvCompeticiones.CurrentRow.Cells[0].Value);

       
                string resultado = competicion.GrabarCambios();
                MessageBox.Show(resultado);

                // 4. Actualizar el DataGridView y limpiar el formulario
                listaCompeticiones();
                Reincio();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
