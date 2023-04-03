
namespace wCWdrmApp
{
    partial class frmChofer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvChofer = new System.Windows.Forms.DataGridView();
            this.iIdConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLicenciaFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daInicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daTermina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iHoraRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtiChofer = new System.Windows.Forms.TextBox();
            this.lblChofer = new System.Windows.Forms.Label();
            this.txtcNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoChofer = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTermina = new System.Windows.Forms.Label();
            this.lblInicia = new System.Windows.Forms.Label();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.txtHorarioTermina = new System.Windows.Forms.TextBox();
            this.lblHorarioTermina = new System.Windows.Forms.Label();
            this.txtHorarioInicia = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.dtpInicia = new System.Windows.Forms.DateTimePicker();
            this.dtpTermina = new System.Windows.Forms.DateTimePicker();
            this.panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChofer)).BeginInit();
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
            this.panelMenuPrincipal.Location = new System.Drawing.Point(2, 3);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(200, 444);
            this.panelMenuPrincipal.TabIndex = 0;
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // dgvChofer
            // 
            this.dgvChofer.AllowUserToAddRows = false;
            this.dgvChofer.AllowUserToDeleteRows = false;
            this.dgvChofer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChofer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChofer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIdConductor,
            this.cNombre,
            this.iIdTipo,
            this.cLicenciaFolio,
            this.daInicia,
            this.daTermina,
            this.cObservaciones,
            this.daRegistro,
            this.iHoraRegistro,
            this.cIdUsuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChofer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChofer.Location = new System.Drawing.Point(201, 3);
            this.dgvChofer.Name = "dgvChofer";
            this.dgvChofer.ReadOnly = true;
            this.dgvChofer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChofer.Size = new System.Drawing.Size(634, 257);
            this.dgvChofer.TabIndex = 2;
            this.dgvChofer.SelectionChanged += new System.EventHandler(this.dgvChofer_SelectionChanged);
            // 
            // iIdConductor
            // 
            this.iIdConductor.DataPropertyName = "iIdConductor";
            this.iIdConductor.HeaderText = "Chofer #";
            this.iIdConductor.Name = "iIdConductor";
            this.iIdConductor.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "cNombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // iIdTipo
            // 
            this.iIdTipo.DataPropertyName = "iIdTipo";
            this.iIdTipo.HeaderText = "Tipo";
            this.iIdTipo.Name = "iIdTipo";
            this.iIdTipo.ReadOnly = true;
            // 
            // cLicenciaFolio
            // 
            this.cLicenciaFolio.DataPropertyName = "cLicenciaFolio";
            this.cLicenciaFolio.HeaderText = "Licencia";
            this.cLicenciaFolio.Name = "cLicenciaFolio";
            this.cLicenciaFolio.ReadOnly = true;
            // 
            // daInicia
            // 
            this.daInicia.DataPropertyName = "daInicia";
            this.daInicia.HeaderText = "Fecha Inicia";
            this.daInicia.Name = "daInicia";
            this.daInicia.ReadOnly = true;
            // 
            // daTermina
            // 
            this.daTermina.DataPropertyName = "daTermina";
            this.daTermina.HeaderText = "Fecha Termina";
            this.daTermina.Name = "daTermina";
            this.daTermina.ReadOnly = true;
            // 
            // cObservaciones
            // 
            this.cObservaciones.DataPropertyName = "cObservaciones";
            this.cObservaciones.HeaderText = "Observaciones";
            this.cObservaciones.Name = "cObservaciones";
            this.cObservaciones.ReadOnly = true;
            // 
            // daRegistro
            // 
            this.daRegistro.DataPropertyName = "daRegistro";
            this.daRegistro.HeaderText = "Fecha Registro";
            this.daRegistro.Name = "daRegistro";
            this.daRegistro.ReadOnly = true;
            // 
            // iHoraRegistro
            // 
            this.iHoraRegistro.DataPropertyName = "iHoraRegistro";
            this.iHoraRegistro.HeaderText = "Hora Registro";
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
            // txtiChofer
            // 
            this.txtiChofer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiChofer.Enabled = false;
            this.txtiChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiChofer.Location = new System.Drawing.Point(291, 266);
            this.txtiChofer.MaxLength = 6;
            this.txtiChofer.Name = "txtiChofer";
            this.txtiChofer.Size = new System.Drawing.Size(69, 29);
            this.txtiChofer.TabIndex = 4;
            this.txtiChofer.Text = "0";
            this.txtiChofer.UseWaitCursor = true;
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblChofer.Location = new System.Drawing.Point(248, 269);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(40, 24);
            this.lblChofer.TabIndex = 0;
            this.lblChofer.Text = "Id #";
            this.lblChofer.UseWaitCursor = true;
            // 
            // txtcNombre
            // 
            this.txtcNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcNombre.Enabled = false;
            this.txtcNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcNombre.Location = new System.Drawing.Point(290, 297);
            this.txtcNombre.Name = "txtcNombre";
            this.txtcNombre.Size = new System.Drawing.Size(545, 29);
            this.txtcNombre.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTipo.Location = new System.Drawing.Point(365, 269);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 24);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.UseWaitCursor = true;
            // 
            // cmbTipoChofer
            // 
            this.cmbTipoChofer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoChofer.Enabled = false;
            this.cmbTipoChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbTipoChofer.FormattingEnabled = true;
            this.cmbTipoChofer.Items.AddRange(new object[] {
            "VENTO",
            "ESCARABAJO"});
            this.cmbTipoChofer.Location = new System.Drawing.Point(416, 267);
            this.cmbTipoChofer.Name = "cmbTipoChofer";
            this.cmbTipoChofer.Size = new System.Drawing.Size(419, 28);
            this.cmbTipoChofer.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNombre.Location = new System.Drawing.Point(206, 299);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.UseWaitCursor = true;
            // 
            // lblTermina
            // 
            this.lblTermina.AutoSize = true;
            this.lblTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTermina.Location = new System.Drawing.Point(614, 332);
            this.lblTermina.Name = "lblTermina";
            this.lblTermina.Size = new System.Drawing.Size(23, 24);
            this.lblTermina.TabIndex = 0;
            this.lblTermina.Text = "A";
            this.lblTermina.UseWaitCursor = true;
            // 
            // lblInicia
            // 
            this.lblInicia.AutoSize = true;
            this.lblInicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblInicia.Location = new System.Drawing.Point(381, 332);
            this.lblInicia.Name = "lblInicia";
            this.lblInicia.Size = new System.Drawing.Size(34, 24);
            this.lblInicia.TabIndex = 0;
            this.lblInicia.Text = "De";
            this.lblInicia.UseWaitCursor = true;
            // 
            // txtLicencia
            // 
            this.txtLicencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicencia.Enabled = false;
            this.txtLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtLicencia.Location = new System.Drawing.Point(290, 329);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(91, 29);
            this.txtLicencia.TabIndex = 4;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblLicencia.Location = new System.Drawing.Point(208, 332);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(80, 24);
            this.lblLicencia.TabIndex = 0;
            this.lblLicencia.Text = "Licencia";
            this.lblLicencia.UseWaitCursor = true;
            // 
            // txtHorarioTermina
            // 
            this.txtHorarioTermina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHorarioTermina.Enabled = false;
            this.txtHorarioTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtHorarioTermina.Location = new System.Drawing.Point(467, 361);
            this.txtHorarioTermina.MaxLength = 8;
            this.txtHorarioTermina.Name = "txtHorarioTermina";
            this.txtHorarioTermina.Size = new System.Drawing.Size(82, 29);
            this.txtHorarioTermina.TabIndex = 8;
            this.txtHorarioTermina.Text = "00:00:00";
            // 
            // lblHorarioTermina
            // 
            this.lblHorarioTermina.AutoSize = true;
            this.lblHorarioTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblHorarioTermina.Location = new System.Drawing.Point(440, 364);
            this.lblHorarioTermina.Name = "lblHorarioTermina";
            this.lblHorarioTermina.Size = new System.Drawing.Size(23, 24);
            this.lblHorarioTermina.TabIndex = 0;
            this.lblHorarioTermina.Text = "A";
            this.lblHorarioTermina.UseWaitCursor = true;
            // 
            // txtHorarioInicia
            // 
            this.txtHorarioInicia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHorarioInicia.Enabled = false;
            this.txtHorarioInicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtHorarioInicia.Location = new System.Drawing.Point(291, 361);
            this.txtHorarioInicia.MaxLength = 8;
            this.txtHorarioInicia.Name = "txtHorarioInicia";
            this.txtHorarioInicia.Size = new System.Drawing.Size(77, 29);
            this.txtHorarioInicia.TabIndex = 7;
            this.txtHorarioInicia.Text = "00:00:00";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblHorario.Location = new System.Drawing.Point(217, 364);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(72, 24);
            this.lblHorario.TabIndex = 0;
            this.lblHorario.Text = "Horario";
            this.lblHorario.UseWaitCursor = true;
            // 
            // txtNota
            // 
            this.txtNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNota.Enabled = false;
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtNota.Location = new System.Drawing.Point(290, 392);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(545, 55);
            this.txtNota.TabIndex = 9;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNota.Location = new System.Drawing.Point(238, 395);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(49, 24);
            this.lblNota.TabIndex = 0;
            this.lblNota.Text = "Nota";
            this.lblNota.UseWaitCursor = true;
            // 
            // dtpInicia
            // 
            this.dtpInicia.Location = new System.Drawing.Point(412, 334);
            this.dtpInicia.Name = "dtpInicia";
            this.dtpInicia.Size = new System.Drawing.Size(200, 20);
            this.dtpInicia.TabIndex = 10;
            // 
            // dtpTermina
            // 
            this.dtpTermina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTermina.Location = new System.Drawing.Point(635, 334);
            this.dtpTermina.Name = "dtpTermina";
            this.dtpTermina.Size = new System.Drawing.Size(200, 20);
            this.dtpTermina.TabIndex = 11;
            this.dtpTermina.ValueChanged += new System.EventHandler(this.dtpTermina_ValueChanged);
            // 
            // frmChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.dtpTermina);
            this.Controls.Add(this.dtpInicia);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtHorarioTermina);
            this.Controls.Add(this.lblHorarioTermina);
            this.Controls.Add(this.txtHorarioInicia);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblTermina);
            this.Controls.Add(this.lblInicia);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.lblLicencia);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipoChofer);
            this.Controls.Add(this.txtcNombre);
            this.Controls.Add(this.txtiChofer);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.dgvChofer);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Name = "frmChofer";
            this.Text = "frmChofer";
            this.panelMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChofer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvChofer;
        private System.Windows.Forms.TextBox txtiChofer;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.TextBox txtcNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoChofer;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTermina;
        private System.Windows.Forms.Label lblInicia;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.TextBox txtHorarioTermina;
        private System.Windows.Forms.Label lblHorarioTermina;
        private System.Windows.Forms.TextBox txtHorarioInicia;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.DateTimePicker dtpInicia;
        private System.Windows.Forms.DateTimePicker dtpTermina;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLicenciaFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn daInicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn daTermina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn daRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn iHoraRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdUsuario;
    }
}