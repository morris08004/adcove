
namespace wCWdrmApp
{
    partial class frmProveedor
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
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.iIdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIdSidaf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTaller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iArredador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iHoraRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtcNombre = new System.Windows.Forms.TextBox();
            this.txtiProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.chkTaller = new System.Windows.Forms.CheckBox();
            this.chkArrendador = new System.Windows.Forms.CheckBox();
            this.txtiSIDAF = new System.Windows.Forms.TextBox();
            this.lblSIDAF = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtcUbicacion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtcTelefono = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtcResponsable = new System.Windows.Forms.TextBox();
            this.panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
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
            this.panelMenuPrincipal.Location = new System.Drawing.Point(0, 3);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(200, 444);
            this.panelMenuPrincipal.TabIndex = 1;
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
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIdProveedor,
            this.cNombre,
            this.iIdSidaf,
            this.cUbicacion,
            this.cTelefono,
            this.iTaller,
            this.iArredador,
            this.cResponsable,
            this.dtRegistro,
            this.iHoraRegistro,
            this.cIdUsuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedor.Location = new System.Drawing.Point(196, 2);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.Size = new System.Drawing.Size(603, 257);
            this.dgvProveedor.TabIndex = 0;
            this.dgvProveedor.SelectionChanged += new System.EventHandler(this.dgvProveedor_SelectionChanged);
            // 
            // iIdProveedor
            // 
            this.iIdProveedor.DataPropertyName = "iIdProveedor";
            this.iIdProveedor.HeaderText = "Proveedor #";
            this.iIdProveedor.Name = "iIdProveedor";
            this.iIdProveedor.ReadOnly = true;
            this.iIdProveedor.Width = 119;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "cNombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 90;
            // 
            // iIdSidaf
            // 
            this.iIdSidaf.DataPropertyName = "iIdSidaf";
            this.iIdSidaf.HeaderText = "Sidaf #";
            this.iIdSidaf.Name = "iIdSidaf";
            this.iIdSidaf.ReadOnly = true;
            this.iIdSidaf.Width = 84;
            // 
            // cUbicacion
            // 
            this.cUbicacion.DataPropertyName = "cUbicacion";
            this.cUbicacion.HeaderText = "Ubicacion";
            this.cUbicacion.Name = "cUbicacion";
            this.cUbicacion.ReadOnly = true;
            this.cUbicacion.Width = 104;
            // 
            // cTelefono
            // 
            this.cTelefono.DataPropertyName = "cTelefono";
            this.cTelefono.HeaderText = "Teléfono";
            this.cTelefono.Name = "cTelefono";
            this.cTelefono.ReadOnly = true;
            this.cTelefono.Width = 96;
            // 
            // iTaller
            // 
            this.iTaller.DataPropertyName = "iTaller";
            this.iTaller.HeaderText = "Taller #";
            this.iTaller.Name = "iTaller";
            this.iTaller.ReadOnly = true;
            this.iTaller.Width = 85;
            // 
            // iArredador
            // 
            this.iArredador.DataPropertyName = "iArrendador";
            this.iArredador.HeaderText = "Arrendador";
            this.iArredador.Name = "iArredador";
            this.iArredador.ReadOnly = true;
            this.iArredador.Width = 114;
            // 
            // cResponsable
            // 
            this.cResponsable.DataPropertyName = "cResponsable";
            this.cResponsable.HeaderText = "Responsable";
            this.cResponsable.Name = "cResponsable";
            this.cResponsable.ReadOnly = true;
            this.cResponsable.Width = 128;
            // 
            // dtRegistro
            // 
            this.dtRegistro.DataPropertyName = "dtRegistro";
            this.dtRegistro.HeaderText = "Fecha Registro";
            this.dtRegistro.Name = "dtRegistro";
            this.dtRegistro.ReadOnly = true;
            this.dtRegistro.Width = 143;
            // 
            // iHoraRegistro
            // 
            this.iHoraRegistro.DataPropertyName = "iHoraRegistro";
            this.iHoraRegistro.HeaderText = "Hora Registro";
            this.iHoraRegistro.Name = "iHoraRegistro";
            this.iHoraRegistro.ReadOnly = true;
            this.iHoraRegistro.Width = 133;
            // 
            // cIdUsuario
            // 
            this.cIdUsuario.DataPropertyName = "cIdUsuario";
            this.cIdUsuario.HeaderText = "Usuario";
            this.cIdUsuario.Name = "cIdUsuario";
            this.cIdUsuario.ReadOnly = true;
            this.cIdUsuario.Width = 89;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNombre.Location = new System.Drawing.Point(245, 294);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.UseWaitCursor = true;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtcNombre
            // 
            this.txtcNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcNombre.Enabled = false;
            this.txtcNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcNombre.Location = new System.Drawing.Point(327, 291);
            this.txtcNombre.Name = "txtcNombre";
            this.txtcNombre.Size = new System.Drawing.Size(472, 29);
            this.txtcNombre.TabIndex = 7;
            // 
            // txtiProveedor
            // 
            this.txtiProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiProveedor.Enabled = false;
            this.txtiProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiProveedor.Location = new System.Drawing.Point(327, 260);
            this.txtiProveedor.Name = "txtiProveedor";
            this.txtiProveedor.Size = new System.Drawing.Size(69, 29);
            this.txtiProveedor.TabIndex = 8;
            this.txtiProveedor.Text = "0";
            this.txtiProveedor.UseWaitCursor = true;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblProveedor.Location = new System.Drawing.Point(227, 263);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(98, 24);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            this.lblProveedor.UseWaitCursor = true;
            // 
            // chkTaller
            // 
            this.chkTaller.AutoSize = true;
            this.chkTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chkTaller.Location = new System.Drawing.Point(440, 262);
            this.chkTaller.Name = "chkTaller";
            this.chkTaller.Size = new System.Drawing.Size(75, 26);
            this.chkTaller.TabIndex = 1;
            this.chkTaller.Text = "Taller";
            this.chkTaller.UseVisualStyleBackColor = true;
            // 
            // chkArrendador
            // 
            this.chkArrendador.AutoSize = true;
            this.chkArrendador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chkArrendador.Location = new System.Drawing.Point(522, 261);
            this.chkArrendador.Name = "chkArrendador";
            this.chkArrendador.Size = new System.Drawing.Size(119, 26);
            this.chkArrendador.TabIndex = 2;
            this.chkArrendador.Text = "Arrendador";
            this.chkArrendador.UseVisualStyleBackColor = true;
            // 
            // txtiSIDAF
            // 
            this.txtiSIDAF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtiSIDAF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiSIDAF.Enabled = false;
            this.txtiSIDAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiSIDAF.Location = new System.Drawing.Point(730, 260);
            this.txtiSIDAF.Name = "txtiSIDAF";
            this.txtiSIDAF.Size = new System.Drawing.Size(69, 29);
            this.txtiSIDAF.TabIndex = 3;
            this.txtiSIDAF.Text = "0";
            this.txtiSIDAF.UseWaitCursor = true;
            // 
            // lblSIDAF
            // 
            this.lblSIDAF.AutoSize = true;
            this.lblSIDAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSIDAF.Location = new System.Drawing.Point(649, 263);
            this.lblSIDAF.Name = "lblSIDAF";
            this.lblSIDAF.Size = new System.Drawing.Size(79, 24);
            this.lblSIDAF.TabIndex = 0;
            this.lblSIDAF.Text = "SIDAF #";
            this.lblSIDAF.UseWaitCursor = true;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblUbicacion.Location = new System.Drawing.Point(230, 326);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(94, 24);
            this.lblUbicacion.TabIndex = 0;
            this.lblUbicacion.Text = "Ubicación";
            this.lblUbicacion.UseWaitCursor = true;
            // 
            // txtcUbicacion
            // 
            this.txtcUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcUbicacion.Enabled = false;
            this.txtcUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcUbicacion.Location = new System.Drawing.Point(327, 323);
            this.txtcUbicacion.Name = "txtcUbicacion";
            this.txtcUbicacion.Size = new System.Drawing.Size(472, 29);
            this.txtcUbicacion.TabIndex = 14;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTelefono.Location = new System.Drawing.Point(239, 358);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.UseWaitCursor = true;
            // 
            // txtcTelefono
            // 
            this.txtcTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcTelefono.Enabled = false;
            this.txtcTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcTelefono.Location = new System.Drawing.Point(327, 355);
            this.txtcTelefono.Name = "txtcTelefono";
            this.txtcTelefono.Size = new System.Drawing.Size(472, 29);
            this.txtcTelefono.TabIndex = 16;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblResponsable.Location = new System.Drawing.Point(202, 389);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(121, 24);
            this.lblResponsable.TabIndex = 17;
            this.lblResponsable.Text = "Responsable";
            this.lblResponsable.UseWaitCursor = true;
            // 
            // txtcResponsable
            // 
            this.txtcResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcResponsable.Enabled = false;
            this.txtcResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcResponsable.Location = new System.Drawing.Point(327, 386);
            this.txtcResponsable.Name = "txtcResponsable";
            this.txtcResponsable.Size = new System.Drawing.Size(472, 29);
            this.txtcResponsable.TabIndex = 18;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtcResponsable);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtcTelefono);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.txtcUbicacion);
            this.Controls.Add(this.txtiSIDAF);
            this.Controls.Add(this.lblSIDAF);
            this.Controls.Add(this.chkArrendador);
            this.Controls.Add(this.chkTaller);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtcNombre);
            this.Controls.Add(this.txtiProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Name = "frmProveedor";
            this.Text = "Mtto a Proveedores";
            this.panelMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtcNombre;
        private System.Windows.Forms.TextBox txtiProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.CheckBox chkTaller;
        private System.Windows.Forms.CheckBox chkArrendador;
        private System.Windows.Forms.TextBox txtiSIDAF;
        private System.Windows.Forms.Label lblSIDAF;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtcUbicacion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtcTelefono;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtcResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdSidaf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTaller;
        private System.Windows.Forms.DataGridViewTextBoxColumn iArredador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn iHoraRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdUsuario;
    }
}