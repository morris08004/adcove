
namespace wCWdrmApp
{
    partial class frmNivelEducativo
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
            this.dgvNivel = new System.Windows.Forms.DataGridView();
            this.iNodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iHoraRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblNodo = new System.Windows.Forms.Label();
            this.txtcNombre = new System.Windows.Forms.TextBox();
            this.lblPadre = new System.Windows.Forms.Label();
            this.txtcPadre = new System.Windows.Forms.TextBox();
            this.lblF3 = new System.Windows.Forms.Label();
            this.txtiNodo = new System.Windows.Forms.TextBox();
            this.txtiPadre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).BeginInit();
            this.panelMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNivel
            // 
            this.dgvNivel.AllowUserToAddRows = false;
            this.dgvNivel.AllowUserToDeleteRows = false;
            this.dgvNivel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNivel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNivel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNodo,
            this.iPadre,
            this.cNombre,
            this.daRegistro,
            this.iHoraRegistro,
            this.cIdUsuario});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNivel.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNivel.Location = new System.Drawing.Point(201, 3);
            this.dgvNivel.Name = "dgvNivel";
            this.dgvNivel.ReadOnly = true;
            this.dgvNivel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNivel.Size = new System.Drawing.Size(595, 257);
            this.dgvNivel.TabIndex = 0;
            this.dgvNivel.SelectionChanged += new System.EventHandler(this.dgvNivel_SelectionChanged);
            // 
            // iNodo
            // 
            this.iNodo.DataPropertyName = "iNodo";
            this.iNodo.HeaderText = "Nodo";
            this.iNodo.Name = "iNodo";
            this.iNodo.ReadOnly = true;
            // 
            // iPadre
            // 
            this.iPadre.DataPropertyName = "iPadre";
            this.iPadre.HeaderText = "Padre";
            this.iPadre.Name = "iPadre";
            this.iPadre.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.DataPropertyName = "cNombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
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
            this.panelMenuPrincipal.Location = new System.Drawing.Point(1, 3);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(200, 444);
            this.panelMenuPrincipal.TabIndex = 4;
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
            // lblNodo
            // 
            this.lblNodo.AutoSize = true;
            this.lblNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNodo.Location = new System.Drawing.Point(200, 271);
            this.lblNodo.Name = "lblNodo";
            this.lblNodo.Size = new System.Drawing.Size(72, 24);
            this.lblNodo.TabIndex = 0;
            this.lblNodo.Text = "Nodo #";
            this.lblNodo.UseWaitCursor = true;
            // 
            // txtcNombre
            // 
            this.txtcNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcNombre.Enabled = false;
            this.txtcNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcNombre.Location = new System.Drawing.Point(344, 268);
            this.txtcNombre.Name = "txtcNombre";
            this.txtcNombre.Size = new System.Drawing.Size(454, 29);
            this.txtcNombre.TabIndex = 0;
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPadre.Location = new System.Drawing.Point(210, 305);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(60, 24);
            this.lblPadre.TabIndex = 0;
            this.lblPadre.Text = "Padre";
            this.lblPadre.UseWaitCursor = true;
            // 
            // txtcPadre
            // 
            this.txtcPadre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcPadre.Enabled = false;
            this.txtcPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtcPadre.Location = new System.Drawing.Point(377, 303);
            this.txtcPadre.Name = "txtcPadre";
            this.txtcPadre.Size = new System.Drawing.Size(419, 29);
            this.txtcPadre.TabIndex = 0;
            // 
            // lblF3
            // 
            this.lblF3.AutoSize = true;
            this.lblF3.BackColor = System.Drawing.Color.Black;
            this.lblF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblF3.ForeColor = System.Drawing.Color.White;
            this.lblF3.Location = new System.Drawing.Point(340, 307);
            this.lblF3.Name = "lblF3";
            this.lblF3.Size = new System.Drawing.Size(31, 22);
            this.lblF3.TabIndex = 11;
            this.lblF3.Text = "F3";
            // 
            // txtiNodo
            // 
            this.txtiNodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiNodo.Enabled = false;
            this.txtiNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiNodo.Location = new System.Drawing.Point(276, 268);
            this.txtiNodo.MaxLength = 6;
            this.txtiNodo.Name = "txtiNodo";
            this.txtiNodo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtiNodo.Size = new System.Drawing.Size(63, 29);
            this.txtiNodo.TabIndex = 1;
            this.txtiNodo.Text = "0";
            // 
            // txtiPadre
            // 
            this.txtiPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiPadre.Enabled = false;
            this.txtiPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtiPadre.Location = new System.Drawing.Point(276, 303);
            this.txtiPadre.MaxLength = 6;
            this.txtiPadre.Name = "txtiPadre";
            this.txtiPadre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtiPadre.Size = new System.Drawing.Size(63, 29);
            this.txtiPadre.TabIndex = 2;
            this.txtiPadre.Text = "0";
            this.txtiPadre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtiPadre_KeyDown);
            this.txtiPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtiPadre_KeyPress);
            // 
            // frmNivelEducativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtiPadre);
            this.Controls.Add(this.txtiNodo);
            this.Controls.Add(this.lblF3);
            this.Controls.Add(this.txtcPadre);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.txtcNombre);
            this.Controls.Add(this.lblNodo);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Controls.Add(this.dgvNivel);
            this.Name = "frmNivelEducativo";
            this.Text = "Mtto a Nivel Educativo";
            this.Load += new System.EventHandler(this.frmNivelEducativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).EndInit();
            this.panelMenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNivel;
        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblNodo;
        private System.Windows.Forms.TextBox txtcNombre;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.TextBox txtcPadre;
        private System.Windows.Forms.Label lblF3;
        private System.Windows.Forms.TextBox txtiNodo;
        private System.Windows.Forms.TextBox txtiPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn daRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn iHoraRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdUsuario;
    }
}