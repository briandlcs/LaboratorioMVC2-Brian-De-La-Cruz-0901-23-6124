using Microsoft.Reporting.WinForms;
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

namespace CapaVista_Competiciones.Reportes
{
    public partial class FrmReporteCompeticiones : Form
    {
        private ModeloCompeticiones competiciones = new ModeloCompeticiones();
        public FrmReporteCompeticiones()
        {
            InitializeComponent();
        }

        private void FrmReporteCompeticiones_Load(object sender, EventArgs e)
        {
            // 1. Asignar el recurso embebido del reporte
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Competiciones.Reportes.ReporteCompeticiones.rdlc";

            // 2. Limpiar orígenes previos
            reportViewer1.LocalReport.DataSources.Clear();

            // 3. Crear el ReportDataSource usando "DataSet1" (el nombre exacto que espera el rdlc)
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", competiciones.GetAll());

            // 4. Agregar el origen de datos y refrescar
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
