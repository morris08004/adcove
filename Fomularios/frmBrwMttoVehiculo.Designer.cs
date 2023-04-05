
namespace wCWdrmApp
{
    partial class frmBrwMttoVehiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvMtto = new System.Windows.Forms.DataGridView();
            this.iIdMtto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIdArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIdDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTipoMovto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIdAreaSolicita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFolioPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMotivoSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cConceptoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iKilometrajeEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iKilometrajeSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtConformidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dePresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIdEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iHoraRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGenerales = new System.Windows.Forms.TabPage();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtcTelefono = new System.Windows.Forms.TextBox();
            this.txtiFolio = new System.Windows.Forms.TextBox();
            this.txtcArea = new System.Windows.Forms.TextBox();
            this.txtiArea = new System.Windows.Forms.TextBox();
            this.txtcDepartamento = new System.Windows.Forms.TextBox();
            this.txtiDepartamento = new System.Windows.Forms.TextBox();
            this.txtcDireccion = new System.Windows.Forms.TextBox();
            this.txtiDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcResponsableArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTipoMtto = new System.Windows.Forms.Label();
            this.cmbTipoMtto = new System.Windows.Forms.ComboBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.tpResguardante = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcConcepto = new System.Windows.Forms.TextBox();
            this.lblMotivoSolicitud = new System.Windows.Forms.Label();
            this.txtcMotivo = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.cmbTipoArrendamiento = new System.Windows.Forms.ComboBox();
            this.lblTipoArrendamiento = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtcResponsable = new System.Windows.Forms.TextBox();
            this.tpConductor = new System.Windows.Forms.TabPage();
            this.txtcTelefonoTaller = new System.Windows.Forms.TextBox();
            this.txtKmSalida = new System.Windows.Forms.TextBox();
            this.lblKmSalida = new System.Windows.Forms.Label();
            this.txtKmEntrada = new System.Windows.Forms.TextBox();
            this.lblKmEntrada = new System.Windows.Forms.Label();
            this.txtdeAsignacion = new System.Windows.Forms.TextBox();
            this.txtdeFactura = new System.Windows.Forms.TextBox();
            this.txtdePresupuesto = new System.Windows.Forms.TextBox();
            this.dtpAsignacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFatura = new System.Windows.Forms.DateTimePicker();
            this.dtpPresupuesto = new System.Windows.Forms.DateTimePicker();
            this.dtpConformidad = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtiAsignacion = new System.Windows.Forms.TextBox();
            this.txtiFactura = new System.Windows.Forms.TextBox();
            this.txtiPresupuesto = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFolios = new System.Windows.Forms.Label();
            this.lblAsignacion = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.lblConformidad = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblTaller = new System.Windows.Forms.Label();
            this.cmbTaller = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcResponsableTaller = new System.Windows.Forms.TextBox();
            this.panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMtto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpGenerales.SuspendLayout();
            this.tpResguardante.SuspendLayout();
            this.tpConductor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenuPrincipal.Controls.Add(this.btnImprimir);
            this.panelMenuPrincipal.Controls.Add(this.btnBuscar);
            this.panelMenuPrincipal.Controls.Add(this.btnCancelar);
            this.panelMenuPrincipal.Controls.Add(this.btnGuardar);
            this.panelMenuPrincipal.Controls.Add(this.btnBorrar);
            this.panelMenuPrincipal.Controls.Add(this.btnEditar);
            this.panelMenuPrincipal.Controls.Add(this.btnNuevo);
            this.panelMenuPrincipal.Location = new System.Drawing.Point(5, 4);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(200, 549);
            this.panelMenuPrincipal.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnImprimir.Location = new System.Drawing.Point(34, 346);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 51);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnBuscar.Location = new System.Drawing.Point(34, 294);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 51);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCancelar.Location = new System.Drawing.Point(34, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 51);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnGuardar.Location = new System.Drawing.Point(34, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 51);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnBorrar.Location = new System.Drawing.Point(34, 137);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(128, 51);
            this.btnBorrar.TabIndex = 3;
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
            this.btnEditar.TabIndex = 2;
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
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvMtto
            // 
            this.dgvMtto.AllowUserToAddRows = false;
            this.dgvMtto.AllowUserToDeleteRows = false;
            this.dgvMtto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMtto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMtto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMtto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIdMtto,
            this.iIdProveedor,
            this.iIdVehiculo,
            this.iIdArea,
            this.iIdDepartamento,
            this.iTipoMovto,
            this.cResponsable,
            this.cTelefono,
            this.cMotivo,
            this.iIdAreaSolicita,
            this.cFolioPlaca,
            this.cMotivoSolicitud,
            this.cConceptoFactura,
            this.cObservaciones,
            this.dtEntrada,
            this.iKilometrajeEntrada,
            this.dtSalida,
            this.iKilometrajeSalida,
            this.dtConformidad,
            this.iPresupuesto,
            this.dtPresupuesto,
            this.dePresupuesto,
            this.iFactura,
            this.dtFactura,
            this.deFactura,
            this.iAsignacion,
            this.dtAsignacion,
            this.deAsignacion,
            this.iIdEstatus,
            this.dtRegistro,
            this.iHoraRegistro,
            this.cIdUsuario});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMtto.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMtto.Location = new System.Drawing.Point(211, 4);
            this.dgvMtto.Name = "dgvMtto";
            this.dgvMtto.ReadOnly = true;
            this.dgvMtto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMtto.Size = new System.Drawing.Size(743, 257);
            this.dgvMtto.TabIndex = 6;
            this.dgvMtto.SelectionChanged += new System.EventHandler(this.dgvMtto_SelectionChanged);
            // 
            // iIdMtto
            // 
            this.iIdMtto.DataPropertyName = "iIdMtto";
            this.iIdMtto.HeaderText = "Mtto #";
            this.iIdMtto.Name = "iIdMtto";
            this.iIdMtto.ReadOnly = true;
            this.iIdMtto.ToolTipText = "Id del Mtto";
            // 
            // iIdProveedor
            // 
            this.iIdProveedor.DataPropertyName = "iIdProveedor";
            this.iIdProveedor.HeaderText = "Proveedor #";
            this.iIdProveedor.Name = "iIdProveedor";
            this.iIdProveedor.ReadOnly = true;
            // 
            // iIdVehiculo
            // 
            this.iIdVehiculo.DataPropertyName = "iIdVehiculo";
            this.iIdVehiculo.HeaderText = "Vehiculo #";
            this.iIdVehiculo.Name = "iIdVehiculo";
            this.iIdVehiculo.ReadOnly = true;
            // 
            // iIdArea
            // 
            this.iIdArea.DataPropertyName = "iIdArea";
            this.iIdArea.HeaderText = "Area #";
            this.iIdArea.Name = "iIdArea";
            this.iIdArea.ReadOnly = true;
            // 
            // iIdDepartamento
            // 
            this.iIdDepartamento.DataPropertyName = "iIdDepartamento";
            this.iIdDepartamento.HeaderText = "Depto #";
            this.iIdDepartamento.Name = "iIdDepartamento";
            this.iIdDepartamento.ReadOnly = true;
            // 
            // iTipoMovto
            // 
            this.iTipoMovto.DataPropertyName = "iTipoMovto";
            this.iTipoMovto.HeaderText = "Tipo Movto";
            this.iTipoMovto.Name = "iTipoMovto";
            this.iTipoMovto.ReadOnly = true;
            // 
            // cResponsable
            // 
            this.cResponsable.DataPropertyName = "cResponsable";
            this.cResponsable.HeaderText = "Responsable";
            this.cResponsable.Name = "cResponsable";
            this.cResponsable.ReadOnly = true;
            // 
            // cTelefono
            // 
            this.cTelefono.DataPropertyName = "cTelefono";
            this.cTelefono.HeaderText = "Telefono";
            this.cTelefono.Name = "cTelefono";
            this.cTelefono.ReadOnly = true;
            // 
            // cMotivo
            // 
            this.cMotivo.DataPropertyName = "cMotivo";
            this.cMotivo.HeaderText = "Motivo";
            this.cMotivo.Name = "cMotivo";
            this.cMotivo.ReadOnly = true;
            // 
            // iIdAreaSolicita
            // 
            this.iIdAreaSolicita.DataPropertyName = "iIdAreaSolicita";
            this.iIdAreaSolicita.HeaderText = "Area Solic. #";
            this.iIdAreaSolicita.Name = "iIdAreaSolicita";
            this.iIdAreaSolicita.ReadOnly = true;
            // 
            // cFolioPlaca
            // 
            this.cFolioPlaca.DataPropertyName = "cFolioPlaca";
            this.cFolioPlaca.HeaderText = "Placa";
            this.cFolioPlaca.Name = "cFolioPlaca";
            this.cFolioPlaca.ReadOnly = true;
            // 
            // cMotivoSolicitud
            // 
            this.cMotivoSolicitud.DataPropertyName = "cMotivoSolicitud";
            this.cMotivoSolicitud.HeaderText = "Motivo Solicitud";
            this.cMotivoSolicitud.Name = "cMotivoSolicitud";
            this.cMotivoSolicitud.ReadOnly = true;
            // 
            // cConceptoFactura
            // 
            this.cConceptoFactura.DataPropertyName = "cConceptoFactura";
            this.cConceptoFactura.HeaderText = "Concepto Factura";
            this.cConceptoFactura.Name = "cConceptoFactura";
            this.cConceptoFactura.ReadOnly = true;
            // 
            // cObservaciones
            // 
            this.cObservaciones.DataPropertyName = "cObservaciones";
            this.cObservaciones.HeaderText = "Observaciones";
            this.cObservaciones.Name = "cObservaciones";
            this.cObservaciones.ReadOnly = true;
            // 
            // dtEntrada
            // 
            this.dtEntrada.DataPropertyName = "dtEntrada";
            this.dtEntrada.HeaderText = "Fecha Ent.";
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.ReadOnly = true;
            // 
            // iKilometrajeEntrada
            // 
            this.iKilometrajeEntrada.DataPropertyName = "iKilometrajeEntrada";
            this.iKilometrajeEntrada.HeaderText = "Km Entrada";
            this.iKilometrajeEntrada.Name = "iKilometrajeEntrada";
            this.iKilometrajeEntrada.ReadOnly = true;
            // 
            // dtSalida
            // 
            this.dtSalida.DataPropertyName = "dtSalida";
            this.dtSalida.HeaderText = "Fecha Sal.";
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.ReadOnly = true;
            // 
            // iKilometrajeSalida
            // 
            this.iKilometrajeSalida.DataPropertyName = "iKilometrajeSalida";
            this.iKilometrajeSalida.HeaderText = "Km Salida";
            this.iKilometrajeSalida.Name = "iKilometrajeSalida";
            this.iKilometrajeSalida.ReadOnly = true;
            // 
            // dtConformidad
            // 
            this.dtConformidad.DataPropertyName = "dtConformidad";
            this.dtConformidad.HeaderText = "Fecha Confor.";
            this.dtConformidad.Name = "dtConformidad";
            this.dtConformidad.ReadOnly = true;
            // 
            // iPresupuesto
            // 
            this.iPresupuesto.DataPropertyName = "iPresupuesto";
            this.iPresupuesto.HeaderText = "Pto #";
            this.iPresupuesto.Name = "iPresupuesto";
            this.iPresupuesto.ReadOnly = true;
            // 
            // dtPresupuesto
            // 
            this.dtPresupuesto.DataPropertyName = "dtPresupuesto";
            this.dtPresupuesto.HeaderText = "Fecha Pto";
            this.dtPresupuesto.Name = "dtPresupuesto";
            this.dtPresupuesto.ReadOnly = true;
            // 
            // dePresupuesto
            // 
            this.dePresupuesto.DataPropertyName = "dePresupuesto";
            this.dePresupuesto.HeaderText = "Presupuesto $";
            this.dePresupuesto.Name = "dePresupuesto";
            this.dePresupuesto.ReadOnly = true;
            // 
            // iFactura
            // 
            this.iFactura.DataPropertyName = "iFactura";
            this.iFactura.HeaderText = "Factura #";
            this.iFactura.Name = "iFactura";
            this.iFactura.ReadOnly = true;
            // 
            // dtFactura
            // 
            this.dtFactura.DataPropertyName = "dtFactura";
            this.dtFactura.HeaderText = "Fecha Fact";
            this.dtFactura.Name = "dtFactura";
            this.dtFactura.ReadOnly = true;
            // 
            // deFactura
            // 
            this.deFactura.DataPropertyName = "deFactura";
            this.deFactura.HeaderText = "Factura $";
            this.deFactura.Name = "deFactura";
            this.deFactura.ReadOnly = true;
            // 
            // iAsignacion
            // 
            this.iAsignacion.DataPropertyName = "iAsignacion";
            this.iAsignacion.HeaderText = "Asigna #";
            this.iAsignacion.Name = "iAsignacion";
            this.iAsignacion.ReadOnly = true;
            // 
            // dtAsignacion
            // 
            this.dtAsignacion.DataPropertyName = "dtAsignacion";
            this.dtAsignacion.HeaderText = "FechaAsig.";
            this.dtAsignacion.Name = "dtAsignacion";
            this.dtAsignacion.ReadOnly = true;
            // 
            // deAsignacion
            // 
            this.deAsignacion.DataPropertyName = "deAsignacion";
            this.deAsignacion.HeaderText = "Asignacion$";
            this.deAsignacion.Name = "deAsignacion";
            this.deAsignacion.ReadOnly = true;
            // 
            // iIdEstatus
            // 
            this.iIdEstatus.DataPropertyName = "iIdEstatus";
            this.iIdEstatus.HeaderText = "Estatus #";
            this.iIdEstatus.Name = "iIdEstatus";
            this.iIdEstatus.ReadOnly = true;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            this.dtRegistro.HeaderText = "Fecha Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            // 
            // iHoraRegistro
            // 
            this.iHoraRegistro.DataPropertyName = "iHoraRegistro";
            this.iHoraRegistro.HeaderText = "Hora  Registro";
            this.iHoraRegistro.Name = "iHoraRegistro";
            this.iHoraRegistro.ReadOnly = true;
            // 
            // cIdUsuario
            // 
            this.cIdUsuario.DataPropertyName = "cIdUsuario";
            this.cIdUsuario.HeaderText = "Usuario";
            this.cIdUsuario.Name = "cIdUsuario";
            this.cIdUsuario.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpGenerales);
            this.tabControl1.Controls.Add(this.tpResguardante);
            this.tabControl1.Controls.Add(this.tpConductor);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(211, 269);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 288);
            this.tabControl1.TabIndex = 7;
            // 
            // tpGenerales
            // 
            this.tpGenerales.Controls.Add(this.lblTelefono);
            this.tpGenerales.Controls.Add(this.txtcTelefono);
            this.tpGenerales.Controls.Add(this.txtiFolio);
            this.tpGenerales.Controls.Add(this.txtcArea);
            this.tpGenerales.Controls.Add(this.txtiArea);
            this.tpGenerales.Controls.Add(this.txtcDepartamento);
            this.tpGenerales.Controls.Add(this.txtiDepartamento);
            this.tpGenerales.Controls.Add(this.txtcDireccion);
            this.tpGenerales.Controls.Add(this.txtiDireccion);
            this.tpGenerales.Controls.Add(this.label1);
            this.tpGenerales.Controls.Add(this.txtcResponsableArea);
            this.tpGenerales.Controls.Add(this.lblArea);
            this.tpGenerales.Controls.Add(this.lblDepto);
            this.tpGenerales.Controls.Add(this.lblDireccion);
            this.tpGenerales.Controls.Add(this.lblTipoMtto);
            this.tpGenerales.Controls.Add(this.cmbTipoMtto);
            this.tpGenerales.Controls.Add(this.lblFolio);
            this.tpGenerales.Location = new System.Drawing.Point(4, 29);
            this.tpGenerales.Name = "tpGenerales";
            this.tpGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenerales.Size = new System.Drawing.Size(740, 255);
            this.tpGenerales.TabIndex = 0;
            this.tpGenerales.Text = "Generales";
            this.tpGenerales.UseVisualStyleBackColor = true;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTelefono.Location = new System.Drawing.Point(48, 180);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 63;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtcTelefono
            // 
            this.txtcTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcTelefono.Enabled = false;
            this.txtcTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcTelefono.Location = new System.Drawing.Point(134, 178);
            this.txtcTelefono.Name = "txtcTelefono";
            this.txtcTelefono.Size = new System.Drawing.Size(601, 29);
            this.txtcTelefono.TabIndex = 62;
            // 
            // txtiFolio
            // 
            this.txtiFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiFolio.Enabled = false;
            this.txtiFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiFolio.Location = new System.Drawing.Point(134, 9);
            this.txtiFolio.MaxLength = 6;
            this.txtiFolio.Name = "txtiFolio";
            this.txtiFolio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtiFolio.Size = new System.Drawing.Size(69, 29);
            this.txtiFolio.TabIndex = 61;
            this.txtiFolio.Text = "0";
            // 
            // txtcArea
            // 
            this.txtcArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcArea.Enabled = false;
            this.txtcArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcArea.Location = new System.Drawing.Point(210, 109);
            this.txtcArea.Name = "txtcArea";
            this.txtcArea.Size = new System.Drawing.Size(525, 29);
            this.txtcArea.TabIndex = 47;
            // 
            // txtiArea
            // 
            this.txtiArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiArea.Enabled = false;
            this.txtiArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiArea.Location = new System.Drawing.Point(134, 109);
            this.txtiArea.MaxLength = 6;
            this.txtiArea.Name = "txtiArea";
            this.txtiArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtiArea.Size = new System.Drawing.Size(69, 29);
            this.txtiArea.TabIndex = 57;
            this.txtiArea.Text = "0";
            // 
            // txtcDepartamento
            // 
            this.txtcDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcDepartamento.Enabled = false;
            this.txtcDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcDepartamento.Location = new System.Drawing.Point(210, 75);
            this.txtcDepartamento.Name = "txtcDepartamento";
            this.txtcDepartamento.Size = new System.Drawing.Size(525, 29);
            this.txtcDepartamento.TabIndex = 48;
            // 
            // txtiDepartamento
            // 
            this.txtiDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiDepartamento.Enabled = false;
            this.txtiDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiDepartamento.Location = new System.Drawing.Point(134, 75);
            this.txtiDepartamento.MaxLength = 6;
            this.txtiDepartamento.Name = "txtiDepartamento";
            this.txtiDepartamento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtiDepartamento.Size = new System.Drawing.Size(69, 29);
            this.txtiDepartamento.TabIndex = 56;
            this.txtiDepartamento.Text = "0";
            // 
            // txtcDireccion
            // 
            this.txtcDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcDireccion.Enabled = false;
            this.txtcDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcDireccion.Location = new System.Drawing.Point(210, 42);
            this.txtcDireccion.Name = "txtcDireccion";
            this.txtcDireccion.Size = new System.Drawing.Size(526, 29);
            this.txtcDireccion.TabIndex = 49;
            // 
            // txtiDireccion
            // 
            this.txtiDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiDireccion.Enabled = false;
            this.txtiDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiDireccion.Location = new System.Drawing.Point(135, 42);
            this.txtiDireccion.MaxLength = 6;
            this.txtiDireccion.Name = "txtiDireccion";
            this.txtiDireccion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtiDireccion.Size = new System.Drawing.Size(69, 29);
            this.txtiDireccion.TabIndex = 55;
            this.txtiDireccion.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Responsable";
            this.label1.UseWaitCursor = true;
            // 
            // txtcResponsableArea
            // 
            this.txtcResponsableArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcResponsableArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcResponsableArea.Enabled = false;
            this.txtcResponsableArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcResponsableArea.Location = new System.Drawing.Point(135, 143);
            this.txtcResponsableArea.Name = "txtcResponsableArea";
            this.txtcResponsableArea.Size = new System.Drawing.Size(601, 29);
            this.txtcResponsableArea.TabIndex = 51;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblArea.Location = new System.Drawing.Point(82, 112);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(50, 24);
            this.lblArea.TabIndex = 52;
            this.lblArea.Text = "Area";
            this.lblArea.UseWaitCursor = true;
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDepto.Location = new System.Drawing.Point(5, 77);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(128, 24);
            this.lblDepto.TabIndex = 53;
            this.lblDepto.Text = "Departamento";
            this.lblDepto.UseWaitCursor = true;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDireccion.Location = new System.Drawing.Point(41, 44);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 24);
            this.lblDireccion.TabIndex = 54;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.UseWaitCursor = true;
            // 
            // lblTipoMtto
            // 
            this.lblTipoMtto.AutoSize = true;
            this.lblTipoMtto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTipoMtto.Location = new System.Drawing.Point(517, 10);
            this.lblTipoMtto.Name = "lblTipoMtto";
            this.lblTipoMtto.Size = new System.Drawing.Size(48, 24);
            this.lblTipoMtto.TabIndex = 46;
            this.lblTipoMtto.Text = "Tipo";
            this.lblTipoMtto.UseWaitCursor = true;
            // 
            // cmbTipoMtto
            // 
            this.cmbTipoMtto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoMtto.Enabled = false;
            this.cmbTipoMtto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbTipoMtto.FormattingEnabled = true;
            this.cmbTipoMtto.Location = new System.Drawing.Point(568, 6);
            this.cmbTipoMtto.Name = "cmbTipoMtto";
            this.cmbTipoMtto.Size = new System.Drawing.Size(166, 32);
            this.cmbTipoMtto.TabIndex = 45;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFolio.Location = new System.Drawing.Point(64, 10);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(67, 24);
            this.lblFolio.TabIndex = 43;
            this.lblFolio.Text = "Folio #";
            this.lblFolio.UseWaitCursor = true;
            // 
            // tpResguardante
            // 
            this.tpResguardante.Controls.Add(this.label6);
            this.tpResguardante.Controls.Add(this.txtcConcepto);
            this.tpResguardante.Controls.Add(this.lblMotivoSolicitud);
            this.tpResguardante.Controls.Add(this.txtcMotivo);
            this.tpResguardante.Controls.Add(this.txtKm);
            this.tpResguardante.Controls.Add(this.lblKm);
            this.tpResguardante.Controls.Add(this.lblTipoVehiculo);
            this.tpResguardante.Controls.Add(this.cmbTipoVehiculo);
            this.tpResguardante.Controls.Add(this.txtModelo);
            this.tpResguardante.Controls.Add(this.lblModelo);
            this.tpResguardante.Controls.Add(this.label2);
            this.tpResguardante.Controls.Add(this.cmbMarca);
            this.tpResguardante.Controls.Add(this.txtPlaca);
            this.tpResguardante.Controls.Add(this.lblPlaca);
            this.tpResguardante.Controls.Add(this.cmbTipoArrendamiento);
            this.tpResguardante.Controls.Add(this.lblTipoArrendamiento);
            this.tpResguardante.Controls.Add(this.lblObservaciones);
            this.tpResguardante.Controls.Add(this.txtcResponsable);
            this.tpResguardante.Location = new System.Drawing.Point(4, 29);
            this.tpResguardante.Name = "tpResguardante";
            this.tpResguardante.Padding = new System.Windows.Forms.Padding(3);
            this.tpResguardante.Size = new System.Drawing.Size(740, 255);
            this.tpResguardante.TabIndex = 1;
            this.tpResguardante.Text = "Resguardante";
            this.tpResguardante.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(405, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 24);
            this.label6.TabIndex = 78;
            this.label6.Text = "Conceptos de Facturacion";
            // 
            // txtcConcepto
            // 
            this.txtcConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcConcepto.Enabled = false;
            this.txtcConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcConcepto.Location = new System.Drawing.Point(369, 119);
            this.txtcConcepto.Multiline = true;
            this.txtcConcepto.Name = "txtcConcepto";
            this.txtcConcepto.Size = new System.Drawing.Size(363, 63);
            this.txtcConcepto.TabIndex = 77;
            // 
            // lblMotivoSolicitud
            // 
            this.lblMotivoSolicitud.AutoSize = true;
            this.lblMotivoSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblMotivoSolicitud.Location = new System.Drawing.Point(132, 94);
            this.lblMotivoSolicitud.Name = "lblMotivoSolicitud";
            this.lblMotivoSolicitud.Size = new System.Drawing.Size(187, 24);
            this.lblMotivoSolicitud.TabIndex = 76;
            this.lblMotivoSolicitud.Text = "Motivo de la Solicitud";
            // 
            // txtcMotivo
            // 
            this.txtcMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcMotivo.Enabled = false;
            this.txtcMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcMotivo.Location = new System.Drawing.Point(11, 119);
            this.txtcMotivo.Multiline = true;
            this.txtcMotivo.Name = "txtcMotivo";
            this.txtcMotivo.Size = new System.Drawing.Size(352, 63);
            this.txtcMotivo.TabIndex = 75;
            // 
            // txtKm
            // 
            this.txtKm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtKm.Location = new System.Drawing.Point(622, 60);
            this.txtKm.Name = "txtKm";
            this.txtKm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKm.Size = new System.Drawing.Size(112, 29);
            this.txtKm.TabIndex = 74;
            this.txtKm.Text = "0";
            this.txtKm.UseWaitCursor = true;
            this.txtKm.Visible = false;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblKm.Location = new System.Drawing.Point(521, 63);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(103, 24);
            this.lblKm.TabIndex = 73;
            this.lblKm.Text = "Kilometraje";
            this.lblKm.UseWaitCursor = true;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(183, 62);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(128, 24);
            this.lblTipoVehiculo.TabIndex = 71;
            this.lblTipoVehiculo.Text = "Tipo Vehiculo";
            this.lblTipoVehiculo.UseWaitCursor = true;
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "VENTO",
            "ESCARABAJO"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(313, 59);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(208, 28);
            this.cmbTipoVehiculo.TabIndex = 72;
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtModelo.Location = new System.Drawing.Point(80, 60);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(92, 29);
            this.txtModelo.TabIndex = 70;
            this.txtModelo.Text = "2022";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblModelo.Location = new System.Drawing.Point(4, 62);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(74, 24);
            this.lblModelo.TabIndex = 69;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(557, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Marca";
            this.label2.UseWaitCursor = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(622, 29);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(112, 28);
            this.cmbMarca.TabIndex = 68;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPlaca.Location = new System.Drawing.Point(81, 28);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(92, 29);
            this.txtPlaca.TabIndex = 66;
            this.txtPlaca.Text = "YXN-519";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPlaca.Location = new System.Drawing.Point(22, 30);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(56, 24);
            this.lblPlaca.TabIndex = 65;
            this.lblPlaca.Text = "Placa";
            this.lblPlaca.UseWaitCursor = true;
            // 
            // cmbTipoArrendamiento
            // 
            this.cmbTipoArrendamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoArrendamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbTipoArrendamiento.FormattingEnabled = true;
            this.cmbTipoArrendamiento.Items.AddRange(new object[] {
            "VENTO",
            "ESCARABAJO"});
            this.cmbTipoArrendamiento.Location = new System.Drawing.Point(313, 28);
            this.cmbTipoArrendamiento.Name = "cmbTipoArrendamiento";
            this.cmbTipoArrendamiento.Size = new System.Drawing.Size(208, 28);
            this.cmbTipoArrendamiento.TabIndex = 63;
            // 
            // lblTipoArrendamiento
            // 
            this.lblTipoArrendamiento.AutoSize = true;
            this.lblTipoArrendamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTipoArrendamiento.Location = new System.Drawing.Point(203, 30);
            this.lblTipoArrendamiento.Name = "lblTipoArrendamiento";
            this.lblTipoArrendamiento.Size = new System.Drawing.Size(109, 24);
            this.lblTipoArrendamiento.TabIndex = 62;
            this.lblTipoArrendamiento.Text = "Adquisición";
            this.lblTipoArrendamiento.UseWaitCursor = true;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblObservaciones.Location = new System.Drawing.Point(7, 188);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(121, 24);
            this.lblObservaciones.TabIndex = 61;
            this.lblObservaciones.Text = "Responsable";
            this.lblObservaciones.UseWaitCursor = true;
            // 
            // txtcResponsable
            // 
            this.txtcResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcResponsable.Enabled = false;
            this.txtcResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcResponsable.Location = new System.Drawing.Point(133, 186);
            this.txtcResponsable.Multiline = true;
            this.txtcResponsable.Name = "txtcResponsable";
            this.txtcResponsable.Size = new System.Drawing.Size(599, 38);
            this.txtcResponsable.TabIndex = 60;
            // 
            // tpConductor
            // 
            this.tpConductor.Controls.Add(this.txtcTelefonoTaller);
            this.tpConductor.Controls.Add(this.txtKmSalida);
            this.tpConductor.Controls.Add(this.lblKmSalida);
            this.tpConductor.Controls.Add(this.txtKmEntrada);
            this.tpConductor.Controls.Add(this.lblKmEntrada);
            this.tpConductor.Controls.Add(this.txtdeAsignacion);
            this.tpConductor.Controls.Add(this.txtdeFactura);
            this.tpConductor.Controls.Add(this.txtdePresupuesto);
            this.tpConductor.Controls.Add(this.dtpAsignacion);
            this.tpConductor.Controls.Add(this.dtpFatura);
            this.tpConductor.Controls.Add(this.dtpPresupuesto);
            this.tpConductor.Controls.Add(this.dtpConformidad);
            this.tpConductor.Controls.Add(this.dtpSalida);
            this.tpConductor.Controls.Add(this.dtpEntrada);
            this.tpConductor.Controls.Add(this.txtiAsignacion);
            this.tpConductor.Controls.Add(this.txtiFactura);
            this.tpConductor.Controls.Add(this.txtiPresupuesto);
            this.tpConductor.Controls.Add(this.lblTotal);
            this.tpConductor.Controls.Add(this.lblFecha);
            this.tpConductor.Controls.Add(this.lblFolios);
            this.tpConductor.Controls.Add(this.lblAsignacion);
            this.tpConductor.Controls.Add(this.lblFactura);
            this.tpConductor.Controls.Add(this.lblPresupuesto);
            this.tpConductor.Controls.Add(this.lblConformidad);
            this.tpConductor.Controls.Add(this.lblSalida);
            this.tpConductor.Controls.Add(this.lblEntrada);
            this.tpConductor.Controls.Add(this.lblTaller);
            this.tpConductor.Controls.Add(this.cmbTaller);
            this.tpConductor.Controls.Add(this.label7);
            this.tpConductor.Controls.Add(this.txtcResponsableTaller);
            this.tpConductor.Location = new System.Drawing.Point(4, 29);
            this.tpConductor.Name = "tpConductor";
            this.tpConductor.Size = new System.Drawing.Size(740, 255);
            this.tpConductor.TabIndex = 2;
            this.tpConductor.Text = "Conductor";
            this.tpConductor.UseVisualStyleBackColor = true;
            // 
            // txtcTelefonoTaller
            // 
            this.txtcTelefonoTaller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcTelefonoTaller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcTelefonoTaller.Enabled = false;
            this.txtcTelefonoTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcTelefonoTaller.Location = new System.Drawing.Point(542, 45);
            this.txtcTelefonoTaller.Name = "txtcTelefonoTaller";
            this.txtcTelefonoTaller.Size = new System.Drawing.Size(190, 29);
            this.txtcTelefonoTaller.TabIndex = 63;
            // 
            // txtKmSalida
            // 
            this.txtKmSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKmSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtKmSalida.HideSelection = false;
            this.txtKmSalida.Location = new System.Drawing.Point(368, 107);
            this.txtKmSalida.MaxLength = 6;
            this.txtKmSalida.Name = "txtKmSalida";
            this.txtKmSalida.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKmSalida.Size = new System.Drawing.Size(112, 29);
            this.txtKmSalida.TabIndex = 48;
            this.txtKmSalida.Text = "0";
            // 
            // lblKmSalida
            // 
            this.lblKmSalida.AutoSize = true;
            this.lblKmSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblKmSalida.Location = new System.Drawing.Point(263, 110);
            this.lblKmSalida.Name = "lblKmSalida";
            this.lblKmSalida.Size = new System.Drawing.Size(103, 24);
            this.lblKmSalida.TabIndex = 62;
            this.lblKmSalida.Text = "Kilometraje";
            // 
            // txtKmEntrada
            // 
            this.txtKmEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKmEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtKmEntrada.HideSelection = false;
            this.txtKmEntrada.Location = new System.Drawing.Point(368, 77);
            this.txtKmEntrada.MaxLength = 6;
            this.txtKmEntrada.Name = "txtKmEntrada";
            this.txtKmEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKmEntrada.Size = new System.Drawing.Size(112, 29);
            this.txtKmEntrada.TabIndex = 47;
            this.txtKmEntrada.Text = "0";
            // 
            // lblKmEntrada
            // 
            this.lblKmEntrada.AutoSize = true;
            this.lblKmEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblKmEntrada.Location = new System.Drawing.Point(263, 80);
            this.lblKmEntrada.Name = "lblKmEntrada";
            this.lblKmEntrada.Size = new System.Drawing.Size(103, 24);
            this.lblKmEntrada.TabIndex = 61;
            this.lblKmEntrada.Text = "Kilometraje";
            // 
            // txtdeAsignacion
            // 
            this.txtdeAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdeAsignacion.Enabled = false;
            this.txtdeAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtdeAsignacion.Location = new System.Drawing.Point(461, 218);
            this.txtdeAsignacion.MaxLength = 12;
            this.txtdeAsignacion.Name = "txtdeAsignacion";
            this.txtdeAsignacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdeAsignacion.Size = new System.Drawing.Size(129, 29);
            this.txtdeAsignacion.TabIndex = 58;
            this.txtdeAsignacion.Text = "0.00";
            // 
            // txtdeFactura
            // 
            this.txtdeFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdeFactura.Enabled = false;
            this.txtdeFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtdeFactura.Location = new System.Drawing.Point(304, 218);
            this.txtdeFactura.MaxLength = 12;
            this.txtdeFactura.Name = "txtdeFactura";
            this.txtdeFactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdeFactura.Size = new System.Drawing.Size(129, 29);
            this.txtdeFactura.TabIndex = 55;
            this.txtdeFactura.Text = "0.00";
            // 
            // txtdePresupuesto
            // 
            this.txtdePresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdePresupuesto.Enabled = false;
            this.txtdePresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtdePresupuesto.Location = new System.Drawing.Point(142, 218);
            this.txtdePresupuesto.MaxLength = 12;
            this.txtdePresupuesto.Name = "txtdePresupuesto";
            this.txtdePresupuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtdePresupuesto.Size = new System.Drawing.Size(129, 29);
            this.txtdePresupuesto.TabIndex = 52;
            this.txtdePresupuesto.Text = "0.00";
            // 
            // dtpAsignacion
            // 
            this.dtpAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAsignacion.Location = new System.Drawing.Point(461, 187);
            this.dtpAsignacion.Name = "dtpAsignacion";
            this.dtpAsignacion.Size = new System.Drawing.Size(129, 29);
            this.dtpAsignacion.TabIndex = 57;
            // 
            // dtpFatura
            // 
            this.dtpFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpFatura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFatura.Location = new System.Drawing.Point(304, 187);
            this.dtpFatura.Name = "dtpFatura";
            this.dtpFatura.Size = new System.Drawing.Size(129, 29);
            this.dtpFatura.TabIndex = 54;
            // 
            // dtpPresupuesto
            // 
            this.dtpPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpPresupuesto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPresupuesto.Location = new System.Drawing.Point(142, 187);
            this.dtpPresupuesto.Name = "dtpPresupuesto";
            this.dtpPresupuesto.Size = new System.Drawing.Size(129, 29);
            this.dtpPresupuesto.TabIndex = 51;
            // 
            // dtpConformidad
            // 
            this.dtpConformidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpConformidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConformidad.Location = new System.Drawing.Point(603, 76);
            this.dtpConformidad.Name = "dtpConformidad";
            this.dtpConformidad.Size = new System.Drawing.Size(129, 29);
            this.dtpConformidad.TabIndex = 49;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(132, 106);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(129, 29);
            this.dtpSalida.TabIndex = 46;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(133, 76);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(129, 29);
            this.dtpEntrada.TabIndex = 45;
            // 
            // txtiAsignacion
            // 
            this.txtiAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiAsignacion.Enabled = false;
            this.txtiAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiAsignacion.Location = new System.Drawing.Point(461, 157);
            this.txtiAsignacion.MaxLength = 6;
            this.txtiAsignacion.Name = "txtiAsignacion";
            this.txtiAsignacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtiAsignacion.Size = new System.Drawing.Size(129, 29);
            this.txtiAsignacion.TabIndex = 56;
            this.txtiAsignacion.Text = "0";
            // 
            // txtiFactura
            // 
            this.txtiFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiFactura.Enabled = false;
            this.txtiFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiFactura.Location = new System.Drawing.Point(304, 156);
            this.txtiFactura.MaxLength = 6;
            this.txtiFactura.Name = "txtiFactura";
            this.txtiFactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtiFactura.Size = new System.Drawing.Size(129, 29);
            this.txtiFactura.TabIndex = 53;
            this.txtiFactura.Text = "0";
            // 
            // txtiPresupuesto
            // 
            this.txtiPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiPresupuesto.Enabled = false;
            this.txtiPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiPresupuesto.Location = new System.Drawing.Point(142, 157);
            this.txtiPresupuesto.MaxLength = 6;
            this.txtiPresupuesto.Name = "txtiPresupuesto";
            this.txtiPresupuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtiPresupuesto.Size = new System.Drawing.Size(129, 29);
            this.txtiPresupuesto.TabIndex = 50;
            this.txtiPresupuesto.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTotal.Location = new System.Drawing.Point(22, 219);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 24);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "Total + IVA $";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFecha.Location = new System.Drawing.Point(75, 189);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 24);
            this.lblFecha.TabIndex = 40;
            this.lblFecha.Text = "Fecha";
            // 
            // lblFolios
            // 
            this.lblFolios.AutoSize = true;
            this.lblFolios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFolios.Location = new System.Drawing.Point(87, 160);
            this.lblFolios.Name = "lblFolios";
            this.lblFolios.Size = new System.Drawing.Size(52, 24);
            this.lblFolios.TabIndex = 33;
            this.lblFolios.Text = "Folio";
            // 
            // lblAsignacion
            // 
            this.lblAsignacion.AutoSize = true;
            this.lblAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblAsignacion.Location = new System.Drawing.Point(475, 132);
            this.lblAsignacion.Name = "lblAsignacion";
            this.lblAsignacion.Size = new System.Drawing.Size(104, 24);
            this.lblAsignacion.TabIndex = 34;
            this.lblAsignacion.Text = "Asignación";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFactura.Location = new System.Drawing.Point(333, 131);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(73, 24);
            this.lblFactura.TabIndex = 36;
            this.lblFactura.Text = "Factura";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPresupuesto.Location = new System.Drawing.Point(150, 133);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(116, 24);
            this.lblPresupuesto.TabIndex = 38;
            this.lblPresupuesto.Text = "Presupuesto";
            // 
            // lblConformidad
            // 
            this.lblConformidad.AutoSize = true;
            this.lblConformidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblConformidad.Location = new System.Drawing.Point(482, 79);
            this.lblConformidad.Name = "lblConformidad";
            this.lblConformidad.Size = new System.Drawing.Size(118, 24);
            this.lblConformidad.TabIndex = 39;
            this.lblConformidad.Text = "Conformidad";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSalida.Location = new System.Drawing.Point(68, 109);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(61, 24);
            this.lblSalida.TabIndex = 41;
            this.lblSalida.Text = "Salida";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblEntrada.Location = new System.Drawing.Point(55, 79);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(75, 24);
            this.lblEntrada.TabIndex = 42;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblTaller
            // 
            this.lblTaller.AutoSize = true;
            this.lblTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTaller.Location = new System.Drawing.Point(74, 19);
            this.lblTaller.Name = "lblTaller";
            this.lblTaller.Size = new System.Drawing.Size(57, 24);
            this.lblTaller.TabIndex = 43;
            this.lblTaller.Text = "Taller";
            // 
            // cmbTaller
            // 
            this.cmbTaller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaller.Enabled = false;
            this.cmbTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbTaller.FormattingEnabled = true;
            this.cmbTaller.Items.AddRange(new object[] {
            "VENTO",
            "ESCARABAJO"});
            this.cmbTaller.Location = new System.Drawing.Point(134, 15);
            this.cmbTaller.Name = "cmbTaller";
            this.cmbTaller.Size = new System.Drawing.Size(598, 28);
            this.cmbTaller.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(9, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Responsable";
            // 
            // txtcResponsableTaller
            // 
            this.txtcResponsableTaller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcResponsableTaller.Enabled = false;
            this.txtcResponsableTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcResponsableTaller.Location = new System.Drawing.Point(133, 45);
            this.txtcResponsableTaller.Name = "txtcResponsableTaller";
            this.txtcResponsableTaller.Size = new System.Drawing.Size(403, 29);
            this.txtcResponsableTaller.TabIndex = 32;
            // 
            // frmBrwMttoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 569);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvMtto);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Name = "frmBrwMttoVehiculo";
            this.Text = "Mtto a Vehiculos";
            this.panelMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMtto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpGenerales.ResumeLayout(false);
            this.tpGenerales.PerformLayout();
            this.tpResguardante.ResumeLayout(false);
            this.tpResguardante.PerformLayout();
            this.tpConductor.ResumeLayout(false);
            this.tpConductor.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvMtto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGenerales;
        private System.Windows.Forms.TabPage tpResguardante;
        private System.Windows.Forms.TabPage tpConductor;
        private System.Windows.Forms.TextBox txtcArea;
        private System.Windows.Forms.TextBox txtiArea;
        private System.Windows.Forms.TextBox txtcDepartamento;
        private System.Windows.Forms.TextBox txtiDepartamento;
        private System.Windows.Forms.TextBox txtcDireccion;
        private System.Windows.Forms.TextBox txtiDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcResponsableArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTipoMtto;
        private System.Windows.Forms.ComboBox cmbTipoMtto;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcConcepto;
        private System.Windows.Forms.Label lblMotivoSolicitud;
        private System.Windows.Forms.TextBox txtcMotivo;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox cmbTipoArrendamiento;
        private System.Windows.Forms.Label lblTipoArrendamiento;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtcResponsable;
        private System.Windows.Forms.TextBox txtiFolio;
        private System.Windows.Forms.TextBox txtcTelefonoTaller;
        private System.Windows.Forms.TextBox txtKmSalida;
        private System.Windows.Forms.Label lblKmSalida;
        private System.Windows.Forms.TextBox txtKmEntrada;
        private System.Windows.Forms.Label lblKmEntrada;
        private System.Windows.Forms.TextBox txtdeAsignacion;
        private System.Windows.Forms.TextBox txtdeFactura;
        private System.Windows.Forms.TextBox txtdePresupuesto;
        private System.Windows.Forms.DateTimePicker dtpAsignacion;
        private System.Windows.Forms.DateTimePicker dtpFatura;
        private System.Windows.Forms.DateTimePicker dtpPresupuesto;
        private System.Windows.Forms.DateTimePicker dtpConformidad;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.TextBox txtiAsignacion;
        private System.Windows.Forms.TextBox txtiFactura;
        private System.Windows.Forms.TextBox txtiPresupuesto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFolios;
        private System.Windows.Forms.Label lblAsignacion;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label lblConformidad;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblTaller;
        private System.Windows.Forms.ComboBox cmbTaller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcResponsableTaller;
        private System.Windows.Forms.TextBox txtcTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdMtto;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTipoMovto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdAreaSolicita;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFolioPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMotivoSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn cConceptoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn iKilometrajeEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn iKilometrajeSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtConformidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dePresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn iFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn deFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn deAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn iHoraRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdUsuario;
    }
}