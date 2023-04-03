
namespace wCWdrmApp
{
    partial class frmPoliza
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
            this.txtIdPoliza = new System.Windows.Forms.TextBox();
            this.lblPolizaId = new System.Windows.Forms.Label();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvPoliza = new System.Windows.Forms.DataGridView();
            this.iIdPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iInciso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iHoraRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcFolio = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtiInciso = new System.Windows.Forms.TextBox();
            this.Inciso = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblVence = new System.Windows.Forms.Label();
            this.dtpVence = new System.Windows.Forms.DateTimePicker();
            this.dtpPago = new System.Windows.Forms.DateTimePicker();
            this.panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliza)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPoliza
            // 
            this.txtIdPoliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPoliza.Enabled = false;
            this.txtIdPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtIdPoliza.Location = new System.Drawing.Point(316, 265);
            this.txtIdPoliza.Name = "txtIdPoliza";
            this.txtIdPoliza.Size = new System.Drawing.Size(94, 29);
            this.txtIdPoliza.TabIndex = 1;
            this.txtIdPoliza.Text = "0";
            this.txtIdPoliza.UseWaitCursor = true;
            // 
            // lblPolizaId
            // 
            this.lblPolizaId.AutoSize = true;
            this.lblPolizaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPolizaId.Location = new System.Drawing.Point(230, 268);
            this.lblPolizaId.Name = "lblPolizaId";
            this.lblPolizaId.Size = new System.Drawing.Size(82, 24);
            this.lblPolizaId.TabIndex = 0;
            this.lblPolizaId.Text = "ID Poliza";
            this.lblPolizaId.UseWaitCursor = true;
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
            this.panelMenuPrincipal.Location = new System.Drawing.Point(3, 2);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // dgvPoliza
            // 
            this.dgvPoliza.AllowUserToAddRows = false;
            this.dgvPoliza.AllowUserToDeleteRows = false;
            this.dgvPoliza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPoliza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoliza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIdPoliza,
            this.cFolio,
            this.iInciso,
            this.daVencimiento,
            this.daPago,
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
            this.dgvPoliza.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPoliza.Location = new System.Drawing.Point(209, 5);
            this.dgvPoliza.Name = "dgvPoliza";
            this.dgvPoliza.ReadOnly = true;
            this.dgvPoliza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoliza.Size = new System.Drawing.Size(579, 254);
            this.dgvPoliza.TabIndex = 0;
            this.dgvPoliza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoliza_CellContentClick);
            this.dgvPoliza.SelectionChanged += new System.EventHandler(this.dgvPoliza_SelectionChanged);
            // 
            // iIdPoliza
            // 
            this.iIdPoliza.DataPropertyName = "iIdPoliza";
            this.iIdPoliza.HeaderText = "Poliza #";
            this.iIdPoliza.Name = "iIdPoliza";
            this.iIdPoliza.ReadOnly = true;
            // 
            // cFolio
            // 
            this.cFolio.DataPropertyName = "cFolio";
            this.cFolio.HeaderText = "Folio";
            this.cFolio.Name = "cFolio";
            this.cFolio.ReadOnly = true;
            // 
            // iInciso
            // 
            this.iInciso.DataPropertyName = "iInciso";
            this.iInciso.HeaderText = "Inciso";
            this.iInciso.Name = "iInciso";
            this.iInciso.ReadOnly = true;
            // 
            // daVencimiento
            // 
            this.daVencimiento.DataPropertyName = "daVencimiento";
            this.daVencimiento.HeaderText = "Fecha Vencimiento";
            this.daVencimiento.Name = "daVencimiento";
            this.daVencimiento.ReadOnly = true;
            // 
            // daPago
            // 
            this.daPago.DataPropertyName = "daPago";
            this.daPago.HeaderText = "Fecha pago";
            this.daPago.Name = "daPago";
            this.daPago.ReadOnly = true;
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
            // txtcFolio
            // 
            this.txtcFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcFolio.Enabled = false;
            this.txtcFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcFolio.Location = new System.Drawing.Point(316, 300);
            this.txtcFolio.Name = "txtcFolio";
            this.txtcFolio.Size = new System.Drawing.Size(94, 29);
            this.txtcFolio.TabIndex = 2;
            this.txtcFolio.UseWaitCursor = true;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFolio.Location = new System.Drawing.Point(261, 303);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(52, 24);
            this.lblFolio.TabIndex = 0;
            this.lblFolio.Text = "Folio";
            this.lblFolio.UseWaitCursor = true;
            // 
            // txtiInciso
            // 
            this.txtiInciso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiInciso.Enabled = false;
            this.txtiInciso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiInciso.Location = new System.Drawing.Point(316, 336);
            this.txtiInciso.Name = "txtiInciso";
            this.txtiInciso.Size = new System.Drawing.Size(94, 29);
            this.txtiInciso.TabIndex = 3;
            this.txtiInciso.UseWaitCursor = true;
            // 
            // Inciso
            // 
            this.Inciso.AutoSize = true;
            this.Inciso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Inciso.Location = new System.Drawing.Point(254, 339);
            this.Inciso.Name = "Inciso";
            this.Inciso.Size = new System.Drawing.Size(59, 24);
            this.Inciso.TabIndex = 0;
            this.Inciso.Text = "Inciso";
            this.Inciso.UseWaitCursor = true;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPago.Location = new System.Drawing.Point(258, 408);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(54, 24);
            this.lblPago.TabIndex = 0;
            this.lblPago.Text = "Pago";
            this.lblPago.UseWaitCursor = true;
            // 
            // lblVence
            // 
            this.lblVence.AutoSize = true;
            this.lblVence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblVence.Location = new System.Drawing.Point(246, 374);
            this.lblVence.Name = "lblVence";
            this.lblVence.Size = new System.Drawing.Size(66, 24);
            this.lblVence.TabIndex = 0;
            this.lblVence.Text = "Vence";
            this.lblVence.UseWaitCursor = true;
            // 
            // dtpVence
            // 
            this.dtpVence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpVence.Location = new System.Drawing.Point(317, 372);
            this.dtpVence.Name = "dtpVence";
            this.dtpVence.Size = new System.Drawing.Size(268, 23);
            this.dtpVence.TabIndex = 6;
            // 
            // dtpPago
            // 
            this.dtpPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtpPago.Location = new System.Drawing.Point(317, 406);
            this.dtpPago.Name = "dtpPago";
            this.dtpPago.Size = new System.Drawing.Size(268, 23);
            this.dtpPago.TabIndex = 7;
            // 
            // frmPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpPago);
            this.Controls.Add(this.dtpVence);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblVence);
            this.Controls.Add(this.txtiInciso);
            this.Controls.Add(this.Inciso);
            this.Controls.Add(this.txtcFolio);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.dgvPoliza);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Controls.Add(this.txtIdPoliza);
            this.Controls.Add(this.lblPolizaId);
            this.Name = "frmPoliza";
            this.Text = "Mtto a Polizas";
            this.panelMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdPoliza;
        private System.Windows.Forms.Label lblPolizaId;
        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvPoliza;
        private System.Windows.Forms.TextBox txtcFolio;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox txtiInciso;
        private System.Windows.Forms.Label Inciso;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblVence;
        private System.Windows.Forms.DateTimePicker dtpVence;
        private System.Windows.Forms.DateTimePicker dtpPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn iInciso;
        private System.Windows.Forms.DataGridViewTextBoxColumn daVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn daPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn daRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn iHoraRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdUsuario;
    }
}