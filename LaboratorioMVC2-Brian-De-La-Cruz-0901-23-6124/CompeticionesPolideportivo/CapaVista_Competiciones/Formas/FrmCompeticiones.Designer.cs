namespace CapaVista_Competiciones.Formas
{
    partial class FrmCompeticiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCompeticiones = new System.Windows.Forms.DataGridView();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtIdPartido = new System.Windows.Forms.TextBox();
            this.txtMarcadorVisitante = new System.Windows.Forms.TextBox();
            this.txtMarcadorLocal = new System.Windows.Forms.TextBox();
            this.txtIdMejorJugador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaPartido = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHoraPartido = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdCampo = new System.Windows.Forms.TextBox();
            this.txtIdEstadoPartido = new System.Windows.Forms.TextBox();
            this.txtIdJornada = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdEquipoVisitante = new System.Windows.Forms.TextBox();
            this.txtIdArbitro = new System.Windows.Forms.TextBox();
            this.txtIdEquipoLocal = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panIngresarDatos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompeticiones)).BeginInit();
            this.panIngresarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompeticiones
            // 
            this.dgvCompeticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompeticiones.Location = new System.Drawing.Point(511, 52);
            this.dgvCompeticiones.Name = "dgvCompeticiones";
            this.dgvCompeticiones.RowHeadersWidth = 51;
            this.dgvCompeticiones.RowTemplate.Height = 24;
            this.dgvCompeticiones.Size = new System.Drawing.Size(711, 326);
            this.dgvCompeticiones.TabIndex = 0;
            this.dgvCompeticiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompeticiones_CellContentClick);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(511, 399);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(180, 37);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(697, 399);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(180, 37);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(883, 399);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(180, 37);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtIdPartido
            // 
            this.txtIdPartido.Location = new System.Drawing.Point(0, 28);
            this.txtIdPartido.Name = "txtIdPartido";
            this.txtIdPartido.Size = new System.Drawing.Size(168, 22);
            this.txtIdPartido.TabIndex = 4;
            // 
            // txtMarcadorVisitante
            // 
            this.txtMarcadorVisitante.Location = new System.Drawing.Point(0, 255);
            this.txtMarcadorVisitante.Name = "txtMarcadorVisitante";
            this.txtMarcadorVisitante.Size = new System.Drawing.Size(163, 22);
            this.txtMarcadorVisitante.TabIndex = 5;
            // 
            // txtMarcadorLocal
            // 
            this.txtMarcadorLocal.Location = new System.Drawing.Point(0, 199);
            this.txtMarcadorLocal.Name = "txtMarcadorLocal";
            this.txtMarcadorLocal.Size = new System.Drawing.Size(163, 22);
            this.txtMarcadorLocal.TabIndex = 6;
            // 
            // txtIdMejorJugador
            // 
            this.txtIdMejorJugador.Location = new System.Drawing.Point(0, 323);
            this.txtIdMejorJugador.Name = "txtIdMejorJugador";
            this.txtIdMejorJugador.Size = new System.Drawing.Size(163, 22);
            this.txtIdMejorJugador.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = " Id Partido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = " Fecha Partido";
            // 
            // dtpFechaPartido
            // 
            this.dtpFechaPartido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPartido.Location = new System.Drawing.Point(0, 83);
            this.dtpFechaPartido.Name = "dtpFechaPartido";
            this.dtpFechaPartido.Size = new System.Drawing.Size(173, 22);
            this.dtpFechaPartido.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hora Partido";
            // 
            // dtpHoraPartido
            // 
            this.dtpHoraPartido.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraPartido.Location = new System.Drawing.Point(0, 138);
            this.dtpHoraPartido.Name = "dtpHoraPartido";
            this.dtpHoraPartido.Size = new System.Drawing.Size(173, 22);
            this.dtpHoraPartido.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Marcador Local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Marcador Visitante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mejor Jugador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID Campo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID Jornada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estado Partido";
            // 
            // txtIdCampo
            // 
            this.txtIdCampo.Location = new System.Drawing.Point(239, 152);
            this.txtIdCampo.Name = "txtIdCampo";
            this.txtIdCampo.Size = new System.Drawing.Size(163, 22);
            this.txtIdCampo.TabIndex = 18;
            // 
            // txtIdEstadoPartido
            // 
            this.txtIdEstadoPartido.Location = new System.Drawing.Point(239, 28);
            this.txtIdEstadoPartido.Name = "txtIdEstadoPartido";
            this.txtIdEstadoPartido.Size = new System.Drawing.Size(163, 22);
            this.txtIdEstadoPartido.TabIndex = 17;
            // 
            // txtIdJornada
            // 
            this.txtIdJornada.Location = new System.Drawing.Point(239, 84);
            this.txtIdJornada.Name = "txtIdJornada";
            this.txtIdJornada.Size = new System.Drawing.Size(163, 22);
            this.txtIdJornada.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "ID Equipo Visitante";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "ID Equipo Local";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "ID Arbitro";
            // 
            // txtIdEquipoVisitante
            // 
            this.txtIdEquipoVisitante.Location = new System.Drawing.Point(234, 323);
            this.txtIdEquipoVisitante.Name = "txtIdEquipoVisitante";
            this.txtIdEquipoVisitante.Size = new System.Drawing.Size(163, 22);
            this.txtIdEquipoVisitante.TabIndex = 24;
            // 
            // txtIdArbitro
            // 
            this.txtIdArbitro.Location = new System.Drawing.Point(234, 199);
            this.txtIdArbitro.Name = "txtIdArbitro";
            this.txtIdArbitro.Size = new System.Drawing.Size(163, 22);
            this.txtIdArbitro.TabIndex = 23;
            // 
            // txtIdEquipoLocal
            // 
            this.txtIdEquipoLocal.Location = new System.Drawing.Point(234, 255);
            this.txtIdEquipoLocal.Name = "txtIdEquipoLocal";
            this.txtIdEquipoLocal.Size = new System.Drawing.Size(163, 22);
            this.txtIdEquipoLocal.TabIndex = 22;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(134, 370);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(164, 63);
            this.btnGrabar.TabIndex = 28;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1069, 399);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 37);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(800, 447);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(180, 37);
            this.btnBorrar.TabIndex = 30;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(468, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 39);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(557, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(648, 22);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panIngresarDatos
            // 
            this.panIngresarDatos.Controls.Add(this.label10);
            this.panIngresarDatos.Controls.Add(this.label11);
            this.panIngresarDatos.Controls.Add(this.label12);
            this.panIngresarDatos.Controls.Add(this.txtIdEquipoVisitante);
            this.panIngresarDatos.Controls.Add(this.txtIdArbitro);
            this.panIngresarDatos.Controls.Add(this.label1);
            this.panIngresarDatos.Controls.Add(this.btnGrabar);
            this.panIngresarDatos.Controls.Add(this.txtIdEquipoLocal);
            this.panIngresarDatos.Controls.Add(this.label7);
            this.panIngresarDatos.Controls.Add(this.label8);
            this.panIngresarDatos.Controls.Add(this.label9);
            this.panIngresarDatos.Controls.Add(this.txtIdCampo);
            this.panIngresarDatos.Controls.Add(this.txtIdEstadoPartido);
            this.panIngresarDatos.Controls.Add(this.txtIdJornada);
            this.panIngresarDatos.Controls.Add(this.label6);
            this.panIngresarDatos.Controls.Add(this.label5);
            this.panIngresarDatos.Controls.Add(this.label4);
            this.panIngresarDatos.Controls.Add(this.dtpHoraPartido);
            this.panIngresarDatos.Controls.Add(this.label3);
            this.panIngresarDatos.Controls.Add(this.dtpFechaPartido);
            this.panIngresarDatos.Controls.Add(this.label2);
            this.panIngresarDatos.Controls.Add(this.txtIdMejorJugador);
            this.panIngresarDatos.Controls.Add(this.txtMarcadorLocal);
            this.panIngresarDatos.Controls.Add(this.txtMarcadorVisitante);
            this.panIngresarDatos.Controls.Add(this.txtIdPartido);
            this.panIngresarDatos.Location = new System.Drawing.Point(12, 31);
            this.panIngresarDatos.Name = "panIngresarDatos";
            this.panIngresarDatos.Size = new System.Drawing.Size(450, 440);
            this.panIngresarDatos.TabIndex = 33;
            this.panIngresarDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FrmCompeticiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 497);
            this.Controls.Add(this.panIngresarDatos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.dgvCompeticiones);
            this.Name = "FrmCompeticiones";
            this.Text = "FrmCompeticiones";
            this.Load += new System.EventHandler(this.FrmCompeticiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompeticiones)).EndInit();
            this.panIngresarDatos.ResumeLayout(false);
            this.panIngresarDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompeticiones;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtIdPartido;
        private System.Windows.Forms.TextBox txtMarcadorVisitante;
        private System.Windows.Forms.TextBox txtMarcadorLocal;
        private System.Windows.Forms.TextBox txtIdMejorJugador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaPartido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHoraPartido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdCampo;
        private System.Windows.Forms.TextBox txtIdEstadoPartido;
        private System.Windows.Forms.TextBox txtIdJornada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdEquipoVisitante;
        private System.Windows.Forms.TextBox txtIdArbitro;
        private System.Windows.Forms.TextBox txtIdEquipoLocal;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panIngresarDatos;
    }
}