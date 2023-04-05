
namespace wCWdrmApp
{
    partial class frmBitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.iIdBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBitacoraDetalle = new System.Windows.Forms.DataGridView();
            this.iIdBitacoraDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIdConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFolioPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFolioSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAreaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCantidadPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iKmRecorrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deCombutible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deViatico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFolioViatico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistroDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdUsuarioDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenuPrincipal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenuPrincipal.Controls.Add(this.btnImprimir);
            this.panelMenuPrincipal.Controls.Add(this.btnBuscar);
            this.panelMenuPrincipal.Controls.Add(this.btnCancelar);
            this.panelMenuPrincipal.Controls.Add(this.btnGuardar);
            this.panelMenuPrincipal.Controls.Add(this.btnBorrar);
            this.panelMenuPrincipal.Controls.Add(this.btnEditar);
            this.panelMenuPrincipal.Controls.Add(this.btnNuevo);
            this.panelMenuPrincipal.Location = new System.Drawing.Point(3, 3);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(200, 583);
            this.panelMenuPrincipal.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnImprimir.Location = new System.Drawing.Point(34, 346);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 51);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnBuscar.Location = new System.Drawing.Point(34, 294);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 51);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCancelar.Location = new System.Drawing.Point(34, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 51);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGuardar.Location = new System.Drawing.Point(34, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 51);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnBorrar.Location = new System.Drawing.Point(34, 137);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(128, 51);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEditar.Location = new System.Drawing.Point(34, 85);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 51);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnNuevo.Location = new System.Drawing.Point(34, 33);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(128, 51);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIdBitacora,
            this.iArea,
            this.dtBitacora,
            this.cObservaciones,
            this.dtRegistro,
            this.cIdUsuario});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBitacora.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBitacora.Location = new System.Drawing.Point(205, 3);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(749, 292);
            this.dgvBitacora.TabIndex = 2;
            // 
            // iIdBitacora
            // 
            this.iIdBitacora.DataPropertyName = "iIdBitacora";
            this.iIdBitacora.HeaderText = "Bitacora #";
            this.iIdBitacora.Name = "iIdBitacora";
            this.iIdBitacora.ReadOnly = true;
            // 
            // iArea
            // 
            this.iArea.DataPropertyName = "iArea";
            this.iArea.HeaderText = "Area #";
            this.iArea.Name = "iArea";
            this.iArea.ReadOnly = true;
            // 
            // dtBitacora
            // 
            this.dtBitacora.DataPropertyName = "dtBitacora";
            this.dtBitacora.HeaderText = "Fecha";
            this.dtBitacora.Name = "dtBitacora";
            this.dtBitacora.ReadOnly = true;
            // 
            // cObservaciones
            // 
            this.cObservaciones.DataPropertyName = "cObservaciones";
            this.cObservaciones.HeaderText = "Observaciones";
            this.cObservaciones.Name = "cObservaciones";
            this.cObservaciones.ReadOnly = true;
            this.cObservaciones.Width = 200;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            this.dtRegistro.HeaderText = "Fecha Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            // 
            // cIdUsuario
            // 
            this.cIdUsuario.DataPropertyName = "cIdUsuario";
            this.cIdUsuario.HeaderText = "Usuario";
            this.cIdUsuario.Name = "cIdUsuario";
            this.cIdUsuario.ReadOnly = true;
            // 
            // dgvBitacoraDetalle
            // 
            this.dgvBitacoraDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBitacoraDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoraDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIdBitacoraDetalle,
            this.iLinea,
            this.iIdConductor,
            this.cFolioPlaca,
            this.iFolioSolicitud,
            this.iAreaSolicitud,
            this.dtSalida,
            this.cDestino,
            this.dtRetorno,
            this.iCantidadPersona,
            this.iKmRecorrer,
            this.deCombutible,
            this.deViatico,
            this.iFolioViatico,
            this.dtRegistroDetalle,
            this.cIdUsuarioDetalle});
            this.dgvBitacoraDetalle.Location = new System.Drawing.Point(205, 303);
            this.dgvBitacoraDetalle.Name = "dgvBitacoraDetalle";
            this.dgvBitacoraDetalle.Size = new System.Drawing.Size(749, 283);
            this.dgvBitacoraDetalle.TabIndex = 3;
            // 
            // iIdBitacoraDetalle
            // 
            this.iIdBitacoraDetalle.DataPropertyName = "iIdBitacora";
            this.iIdBitacoraDetalle.HeaderText = "Bitacora #";
            this.iIdBitacoraDetalle.Name = "iIdBitacoraDetalle";
            // 
            // iLinea
            // 
            this.iLinea.DataPropertyName = "iLinea";
            this.iLinea.HeaderText = "Linea #";
            this.iLinea.Name = "iLinea";
            // 
            // iIdConductor
            // 
            this.iIdConductor.DataPropertyName = "iIdConductor";
            this.iIdConductor.HeaderText = "Conductor #";
            this.iIdConductor.Name = "iIdConductor";
            // 
            // cFolioPlaca
            // 
            this.cFolioPlaca.DataPropertyName = "cFolioPlaca";
            this.cFolioPlaca.HeaderText = "Placa";
            this.cFolioPlaca.Name = "cFolioPlaca";
            // 
            // iFolioSolicitud
            // 
            this.iFolioSolicitud.DataPropertyName = "iFolioSolicitud";
            this.iFolioSolicitud.HeaderText = "Solicitud #";
            this.iFolioSolicitud.Name = "iFolioSolicitud";
            // 
            // iAreaSolicitud
            // 
            this.iAreaSolicitud.DataPropertyName = "iAreaSolicitud";
            this.iAreaSolicitud.HeaderText = "Area Solicita";
            this.iAreaSolicitud.Name = "iAreaSolicitud";
            // 
            // dtSalida
            // 
            this.dtSalida.DataPropertyName = "dtSalida";
            this.dtSalida.HeaderText = "Salida";
            this.dtSalida.Name = "dtSalida";
            // 
            // cDestino
            // 
            this.cDestino.DataPropertyName = "cDestino";
            this.cDestino.HeaderText = "Destino";
            this.cDestino.Name = "cDestino";
            // 
            // dtRetorno
            // 
            this.dtRetorno.DataPropertyName = "dtRetorno";
            this.dtRetorno.HeaderText = "Retorno";
            this.dtRetorno.Name = "dtRetorno";
            // 
            // iCantidadPersona
            // 
            this.iCantidadPersona.DataPropertyName = "iCantidaPersona";
            this.iCantidadPersona.HeaderText = "Ctd Personas";
            this.iCantidadPersona.Name = "iCantidadPersona";
            // 
            // iKmRecorrer
            // 
            this.iKmRecorrer.DataPropertyName = "iKmRecorrer";
            this.iKmRecorrer.HeaderText = "Km Recorrer";
            this.iKmRecorrer.Name = "iKmRecorrer";
            // 
            // deCombutible
            // 
            this.deCombutible.DataPropertyName = "deCombustible";
            this.deCombutible.HeaderText = "Combustible $";
            this.deCombutible.Name = "deCombutible";
            // 
            // deViatico
            // 
            this.deViatico.DataPropertyName = "deViatico";
            this.deViatico.HeaderText = "Viático $";
            this.deViatico.Name = "deViatico";
            // 
            // iFolioViatico
            // 
            this.iFolioViatico.DataPropertyName = "iFolioViatico";
            this.iFolioViatico.HeaderText = "Folio Viático";
            this.iFolioViatico.Name = "iFolioViatico";
            // 
            // dtRegistroDetalle
            // 
            this.dtRegistroDetalle.DataPropertyName = "dtRegistro";
            this.dtRegistroDetalle.HeaderText = "Fecha Registro";
            this.dtRegistroDetalle.Name = "dtRegistroDetalle";
            // 
            // cIdUsuarioDetalle
            // 
            this.cIdUsuarioDetalle.DataPropertyName = "cIdUsuario";
            this.cIdUsuarioDetalle.HeaderText = "Usuario";
            this.cIdUsuarioDetalle.Name = "cIdUsuarioDetalle";
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 590);
            this.Controls.Add(this.dgvBitacoraDetalle);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Name = "frmBitacora";
            this.Text = "BITÁCORA";
            this.panelMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoraDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.DataGridView dgvBitacoraDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdBitacoraDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFolioPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn iFolioSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAreaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCantidadPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn iKmRecorrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn deCombutible;
        private System.Windows.Forms.DataGridViewTextBoxColumn deViatico;
        private System.Windows.Forms.DataGridViewTextBoxColumn iFolioViatico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistroDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdUsuarioDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn iArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn cObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdUsuario;
    }
}