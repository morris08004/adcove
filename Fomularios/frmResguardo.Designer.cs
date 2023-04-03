
namespace wCWdrmApp
{
    partial class frmResguardo
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
            this.txtiResguardo = new System.Windows.Forms.TextBox();
            this.lblidResguardo = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtcResponsable = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvResguardo = new System.Windows.Forms.DataGridView();
            this.iIdResguardo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAreaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iHoraRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtiDireccion = new System.Windows.Forms.TextBox();
            this.txtcDireccion = new System.Windows.Forms.TextBox();
            this.txtcDepartamento = new System.Windows.Forms.TextBox();
            this.txtiDepartamento = new System.Windows.Forms.TextBox();
            this.txtcArea = new System.Windows.Forms.TextBox();
            this.txtiArea = new System.Windows.Forms.TextBox();
            this.panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResguardo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtiResguardo
            // 
            this.txtiResguardo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiResguardo.Enabled = false;
            this.txtiResguardo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiResguardo.Location = new System.Drawing.Point(343, 269);
            this.txtiResguardo.Name = "txtiResguardo";
            this.txtiResguardo.Size = new System.Drawing.Size(69, 29);
            this.txtiResguardo.TabIndex = 1;
            this.txtiResguardo.Text = "0";
            this.txtiResguardo.UseWaitCursor = true;
            // 
            // lblidResguardo
            // 
            this.lblidResguardo.AutoSize = true;
            this.lblidResguardo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblidResguardo.Location = new System.Drawing.Point(300, 272);
            this.lblidResguardo.Name = "lblidResguardo";
            this.lblidResguardo.Size = new System.Drawing.Size(40, 24);
            this.lblidResguardo.TabIndex = 0;
            this.lblidResguardo.Text = "Id #";
            this.lblidResguardo.UseWaitCursor = true;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblResponsable.Location = new System.Drawing.Point(220, 408);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(121, 24);
            this.lblResponsable.TabIndex = 0;
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
            this.txtcResponsable.Location = new System.Drawing.Point(343, 406);
            this.txtcResponsable.Name = "txtcResponsable";
            this.txtcResponsable.Size = new System.Drawing.Size(601, 29);
            this.txtcResponsable.TabIndex = 5;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblArea.Location = new System.Drawing.Point(290, 375);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(50, 24);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Area";
            this.lblArea.UseWaitCursor = true;
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDepto.Location = new System.Drawing.Point(213, 340);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(128, 24);
            this.lblDepto.TabIndex = 0;
            this.lblDepto.Text = "Departamento";
            this.lblDepto.UseWaitCursor = true;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDireccion.Location = new System.Drawing.Point(249, 306);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 24);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.UseWaitCursor = true;
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
            // dgvResguardo
            // 
            this.dgvResguardo.AllowUserToAddRows = false;
            this.dgvResguardo.AllowUserToDeleteRows = false;
            this.dgvResguardo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResguardo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResguardo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResguardo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIdResguardo,
            this.iNodo,
            this.iAreaServicio,
            this.cResponsable,
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
            this.dgvResguardo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResguardo.Location = new System.Drawing.Point(209, 4);
            this.dgvResguardo.Name = "dgvResguardo";
            this.dgvResguardo.ReadOnly = true;
            this.dgvResguardo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResguardo.Size = new System.Drawing.Size(738, 257);
            this.dgvResguardo.TabIndex = 0;
            this.dgvResguardo.SelectionChanged += new System.EventHandler(this.dgvResguardo_SelectionChanged);
            // 
            // iIdResguardo
            // 
            this.iIdResguardo.DataPropertyName = "iIdResguardo";
            this.iIdResguardo.HeaderText = "Resguardo #";
            this.iIdResguardo.Name = "iIdResguardo";
            this.iIdResguardo.ReadOnly = true;
            // 
            // iNodo
            // 
            this.iNodo.DataPropertyName = "iNodo";
            this.iNodo.HeaderText = "Dir./Depto.";
            this.iNodo.Name = "iNodo";
            this.iNodo.ReadOnly = true;
            // 
            // iAreaServicio
            // 
            this.iAreaServicio.DataPropertyName = "iAreaServicio";
            this.iAreaServicio.HeaderText = "Area #";
            this.iAreaServicio.Name = "iAreaServicio";
            this.iAreaServicio.ReadOnly = true;
            // 
            // cResponsable
            // 
            this.cResponsable.DataPropertyName = "cResponsable";
            this.cResponsable.HeaderText = "Responsable";
            this.cResponsable.Name = "cResponsable";
            this.cResponsable.ReadOnly = true;
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
            // txtiDireccion
            // 
            this.txtiDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiDireccion.Enabled = false;
            this.txtiDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiDireccion.Location = new System.Drawing.Point(343, 303);
            this.txtiDireccion.Name = "txtiDireccion";
            this.txtiDireccion.Size = new System.Drawing.Size(69, 29);
            this.txtiDireccion.TabIndex = 2;
            this.txtiDireccion.Text = "0";
            this.txtiDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtiDireccion_KeyDown);
            this.txtiDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtiDireccion_KeyPress);
            // 
            // txtcDireccion
            // 
            this.txtcDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcDireccion.Enabled = false;
            this.txtcDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcDireccion.Location = new System.Drawing.Point(415, 303);
            this.txtcDireccion.Name = "txtcDireccion";
            this.txtcDireccion.Size = new System.Drawing.Size(529, 29);
            this.txtcDireccion.TabIndex = 0;
            // 
            // txtcDepartamento
            // 
            this.txtcDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcDepartamento.Enabled = false;
            this.txtcDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcDepartamento.Location = new System.Drawing.Point(415, 337);
            this.txtcDepartamento.Name = "txtcDepartamento";
            this.txtcDepartamento.Size = new System.Drawing.Size(529, 29);
            this.txtcDepartamento.TabIndex = 0;
            // 
            // txtiDepartamento
            // 
            this.txtiDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiDepartamento.Enabled = false;
            this.txtiDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiDepartamento.Location = new System.Drawing.Point(343, 337);
            this.txtiDepartamento.Name = "txtiDepartamento";
            this.txtiDepartamento.Size = new System.Drawing.Size(69, 29);
            this.txtiDepartamento.TabIndex = 3;
            this.txtiDepartamento.Text = "0";
            this.txtiDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtiDepartamento_KeyDown);
            // 
            // txtcArea
            // 
            this.txtcArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcArea.Enabled = false;
            this.txtcArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcArea.Location = new System.Drawing.Point(415, 372);
            this.txtcArea.Name = "txtcArea";
            this.txtcArea.Size = new System.Drawing.Size(529, 29);
            this.txtcArea.TabIndex = 0;
            this.txtcArea.TextChanged += new System.EventHandler(this.txtcArea_TextChanged);
            // 
            // txtiArea
            // 
            this.txtiArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiArea.Enabled = false;
            this.txtiArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiArea.Location = new System.Drawing.Point(343, 372);
            this.txtiArea.Name = "txtiArea";
            this.txtiArea.Size = new System.Drawing.Size(69, 29);
            this.txtiArea.TabIndex = 4;
            this.txtiArea.Text = "0";
            this.txtiArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtiArea_KeyDown);
            // 
            // frmResguardo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.txtcArea);
            this.Controls.Add(this.txtiArea);
            this.Controls.Add(this.txtcDepartamento);
            this.Controls.Add(this.txtiDepartamento);
            this.Controls.Add(this.txtcDireccion);
            this.Controls.Add(this.txtiDireccion);
            this.Controls.Add(this.dgvResguardo);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Controls.Add(this.txtiResguardo);
            this.Controls.Add(this.lblidResguardo);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtcResponsable);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblDepto);
            this.Controls.Add(this.lblDireccion);
            this.Name = "frmResguardo";
            this.Text = "Mtto a Resguardo";
            this.panelMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResguardo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtiResguardo;
        private System.Windows.Forms.Label lblidResguardo;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtcResponsable;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvResguardo;
        private System.Windows.Forms.TextBox txtiDireccion;
        private System.Windows.Forms.TextBox txtcDireccion;
        private System.Windows.Forms.TextBox txtcDepartamento;
        private System.Windows.Forms.TextBox txtiDepartamento;
        private System.Windows.Forms.TextBox txtcArea;
        private System.Windows.Forms.TextBox txtiArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIdResguardo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAreaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn daRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn iHoraRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdUsuario;
    }
}