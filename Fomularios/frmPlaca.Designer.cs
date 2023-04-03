
namespace wCWdrmApp
{
    partial class frmPlaca
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
            this.dgvPlaca = new System.Windows.Forms.DataGridView();
            this.cFolioPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtInicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTermina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iHoraRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dtpInicia = new System.Windows.Forms.DateTimePicker();
            this.llInicia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTermina = new System.Windows.Forms.Label();
            this.dtpTermina = new System.Windows.Forms.DateTimePicker();
            this.chkActual = new System.Windows.Forms.CheckBox();
            this.panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaca)).BeginInit();
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
            // dgvPlaca
            // 
            this.dgvPlaca.AllowUserToAddRows = false;
            this.dgvPlaca.AllowUserToDeleteRows = false;
            this.dgvPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFolioPlaca,
            this.dtInicia,
            this.dtTermina,
            this.lActual,
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
            this.dgvPlaca.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlaca.Location = new System.Drawing.Point(202, 3);
            this.dgvPlaca.Name = "dgvPlaca";
            this.dgvPlaca.ReadOnly = true;
            this.dgvPlaca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaca.Size = new System.Drawing.Size(596, 257);
            this.dgvPlaca.TabIndex = 2;
            this.dgvPlaca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResguardo_CellContentClick);
            this.dgvPlaca.SelectionChanged += new System.EventHandler(this.dgvPlaca_SelectionChanged);
            // 
            // cFolioPlaca
            // 
            this.cFolioPlaca.DataPropertyName = "cFolioPlaca";
            this.cFolioPlaca.HeaderText = "Placa";
            this.cFolioPlaca.Name = "cFolioPlaca";
            this.cFolioPlaca.ReadOnly = true;
            // 
            // dtInicia
            // 
            this.dtInicia.DataPropertyName = "dtInicia";
            this.dtInicia.HeaderText = "Fecha inicia";
            this.dtInicia.Name = "dtInicia";
            this.dtInicia.ReadOnly = true;
            // 
            // dtTermina
            // 
            this.dtTermina.DataPropertyName = "dtTermina";
            this.dtTermina.HeaderText = "Fecha Termina";
            this.dtTermina.Name = "dtTermina";
            this.dtTermina.ReadOnly = true;
            // 
            // lActual
            // 
            this.lActual.DataPropertyName = "lActual";
            this.lActual.HeaderText = "Actual";
            this.lActual.Name = "lActual";
            this.lActual.ReadOnly = true;
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
            // txtcPlaca
            // 
            this.txtcPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcPlaca.Enabled = false;
            this.txtcPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcPlaca.Location = new System.Drawing.Point(281, 266);
            this.txtcPlaca.Name = "txtcPlaca";
            this.txtcPlaca.Size = new System.Drawing.Size(123, 29);
            this.txtcPlaca.TabIndex = 4;
            this.txtcPlaca.UseWaitCursor = true;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPlaca.Location = new System.Drawing.Point(206, 269);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(71, 24);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa #";
            this.lblPlaca.UseWaitCursor = true;
            // 
            // dtpInicia
            // 
            this.dtpInicia.Location = new System.Drawing.Point(274, 328);
            this.dtpInicia.Name = "dtpInicia";
            this.dtpInicia.Size = new System.Drawing.Size(200, 20);
            this.dtpInicia.TabIndex = 5;
            // 
            // llInicia
            // 
            this.llInicia.AutoSize = true;
            this.llInicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.llInicia.Location = new System.Drawing.Point(219, 325);
            this.llInicia.Name = "llInicia";
            this.llInicia.Size = new System.Drawing.Size(53, 24);
            this.llInicia.TabIndex = 6;
            this.llInicia.Text = "Inicia";
            this.llInicia.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(424, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vigencia";
            this.label1.UseWaitCursor = true;
            // 
            // lblTermina
            // 
            this.lblTermina.AutoSize = true;
            this.lblTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTermina.Location = new System.Drawing.Point(480, 325);
            this.lblTermina.Name = "lblTermina";
            this.lblTermina.Size = new System.Drawing.Size(80, 24);
            this.lblTermina.TabIndex = 9;
            this.lblTermina.Text = "Termina";
            this.lblTermina.UseWaitCursor = true;
            // 
            // dtpTermina
            // 
            this.dtpTermina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTermina.Location = new System.Drawing.Point(565, 328);
            this.dtpTermina.Name = "dtpTermina";
            this.dtpTermina.Size = new System.Drawing.Size(200, 20);
            this.dtpTermina.TabIndex = 8;
            // 
            // chkActual
            // 
            this.chkActual.AutoSize = true;
            this.chkActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chkActual.Location = new System.Drawing.Point(208, 354);
            this.chkActual.Name = "chkActual";
            this.chkActual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkActual.Size = new System.Drawing.Size(81, 28);
            this.chkActual.TabIndex = 11;
            this.chkActual.Text = "Actual";
            this.chkActual.UseVisualStyleBackColor = true;
            // 
            // frmPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkActual);
            this.Controls.Add(this.lblTermina);
            this.Controls.Add(this.dtpTermina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llInicia);
            this.Controls.Add(this.dtpInicia);
            this.Controls.Add(this.txtcPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.dgvPlaca);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Name = "frmPlaca";
            this.Text = "Mtto a Placas";
            this.Load += new System.EventHandler(this.frmPlaca_Load);
            this.panelMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaca)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPlaca;
        private System.Windows.Forms.TextBox txtcPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.DateTimePicker dtpInicia;
        private System.Windows.Forms.Label llInicia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTermina;
        private System.Windows.Forms.DateTimePicker dtpTermina;
        private System.Windows.Forms.CheckBox chkActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFolioPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtInicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtTermina;
        private System.Windows.Forms.DataGridViewTextBoxColumn lActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn iHoraRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdUsuario;
    }
}