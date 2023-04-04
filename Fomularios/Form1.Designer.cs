
namespace wCWdrmApp
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnTraslado = new System.Windows.Forms.Button();
            this.btnValeViatico = new System.Windows.Forms.Button();
            this.btnMttoVehicular = new System.Windows.Forms.Button();
            this.panelMenuAuxiliar = new System.Windows.Forms.Panel();
            this.panelMttoVhicular = new System.Windows.Forms.Panel();
            this.btnMttoVehiculo = new System.Windows.Forms.Button();
            this.btnNivel = new System.Windows.Forms.Button();
            this.btnEstatus = new System.Windows.Forms.Button();
            this.btnTipo = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnResguardo = new System.Windows.Forms.Button();
            this.btnPoliza = new System.Windows.Forms.Button();
            this.btnChofer = new System.Windows.Forms.Button();
            this.btnPlaca = new System.Windows.Forms.Button();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFechaTrabajo = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblAreaTrabajo = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.panelMttoVales = new System.Windows.Forms.Panel();
            this.btnVales = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panelMttoTraslado = new System.Windows.Forms.Panel();
            this.btnTraslados = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMenuPrincipal.SuspendLayout();
            this.panelMenuAuxiliar.SuspendLayout();
            this.panelMttoVhicular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMttoVales.SuspendLayout();
            this.panelMttoTraslado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenuPrincipal.Controls.Add(this.btnTraslado);
            this.panelMenuPrincipal.Controls.Add(this.btnValeViatico);
            this.panelMenuPrincipal.Controls.Add(this.btnMttoVehicular);
            this.panelMenuPrincipal.Location = new System.Drawing.Point(3, 4);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(200, 975);
            this.panelMenuPrincipal.TabIndex = 0;
            this.panelMenuPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTraslado
            // 
            this.btnTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnTraslado.Location = new System.Drawing.Point(34, 464);
            this.btnTraslado.Name = "btnTraslado";
            this.btnTraslado.Size = new System.Drawing.Size(128, 51);
            this.btnTraslado.TabIndex = 2;
            this.btnTraslado.Text = "Traslado";
            this.btnTraslado.UseVisualStyleBackColor = true;
            this.btnTraslado.Click += new System.EventHandler(this.btnTraslado_Click);
            // 
            // btnValeViatico
            // 
            this.btnValeViatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnValeViatico.Location = new System.Drawing.Point(34, 376);
            this.btnValeViatico.Name = "btnValeViatico";
            this.btnValeViatico.Size = new System.Drawing.Size(128, 51);
            this.btnValeViatico.TabIndex = 1;
            this.btnValeViatico.Text = "Vales y Víaticos";
            this.btnValeViatico.UseVisualStyleBackColor = true;
            this.btnValeViatico.Click += new System.EventHandler(this.btnValeViatico_Click);
            // 
            // btnMttoVehicular
            // 
            this.btnMttoVehicular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnMttoVehicular.Location = new System.Drawing.Point(34, 290);
            this.btnMttoVehicular.Name = "btnMttoVehicular";
            this.btnMttoVehicular.Size = new System.Drawing.Size(128, 51);
            this.btnMttoVehicular.TabIndex = 0;
            this.btnMttoVehicular.Text = "Mantenimiento\r\nVehicular";
            this.btnMttoVehicular.UseVisualStyleBackColor = true;
            this.btnMttoVehicular.Click += new System.EventHandler(this.btnMttoVehicular_Click);
            // 
            // panelMenuAuxiliar
            // 
            this.panelMenuAuxiliar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuAuxiliar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenuAuxiliar.Controls.Add(this.panelMttoTraslado);
            this.panelMenuAuxiliar.Controls.Add(this.panelMttoVales);
            this.panelMenuAuxiliar.Controls.Add(this.panelMttoVhicular);
            this.panelMenuAuxiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.panelMenuAuxiliar.Location = new System.Drawing.Point(1058, 6);
            this.panelMenuAuxiliar.Name = "panelMenuAuxiliar";
            this.panelMenuAuxiliar.Size = new System.Drawing.Size(200, 975);
            this.panelMenuAuxiliar.TabIndex = 1;
            // 
            // panelMttoVhicular
            // 
            this.panelMttoVhicular.Controls.Add(this.btnMttoVehiculo);
            this.panelMttoVhicular.Controls.Add(this.btnNivel);
            this.panelMttoVhicular.Controls.Add(this.btnEstatus);
            this.panelMttoVhicular.Controls.Add(this.btnTipo);
            this.panelMttoVhicular.Controls.Add(this.btnProveedor);
            this.panelMttoVhicular.Controls.Add(this.btnResguardo);
            this.panelMttoVhicular.Controls.Add(this.btnPoliza);
            this.panelMttoVhicular.Controls.Add(this.btnChofer);
            this.panelMttoVhicular.Controls.Add(this.btnPlaca);
            this.panelMttoVhicular.Controls.Add(this.btnVehiculo);
            this.panelMttoVhicular.Location = new System.Drawing.Point(8, 16);
            this.panelMttoVhicular.Name = "panelMttoVhicular";
            this.panelMttoVhicular.Size = new System.Drawing.Size(189, 951);
            this.panelMttoVhicular.TabIndex = 0;
            this.panelMttoVhicular.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMttoVhicular_Paint);
            // 
            // btnMttoVehiculo
            // 
            this.btnMttoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnMttoVehiculo.Location = new System.Drawing.Point(35, 651);
            this.btnMttoVehiculo.Name = "btnMttoVehiculo";
            this.btnMttoVehiculo.Size = new System.Drawing.Size(128, 51);
            this.btnMttoVehiculo.TabIndex = 9;
            this.btnMttoVehiculo.Text = "Mtto Vehicular";
            this.btnMttoVehiculo.UseVisualStyleBackColor = true;
            this.btnMttoVehiculo.Click += new System.EventHandler(this.btnMttoVehiculo_Click);
            // 
            // btnNivel
            // 
            this.btnNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnNivel.Location = new System.Drawing.Point(35, 561);
            this.btnNivel.Name = "btnNivel";
            this.btnNivel.Size = new System.Drawing.Size(128, 51);
            this.btnNivel.TabIndex = 8;
            this.btnNivel.Text = "Nivel Educativo";
            this.btnNivel.UseVisualStyleBackColor = true;
            this.btnNivel.Click += new System.EventHandler(this.btnNivel_Click);
            // 
            // btnEstatus
            // 
            this.btnEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEstatus.Location = new System.Drawing.Point(35, 493);
            this.btnEstatus.Name = "btnEstatus";
            this.btnEstatus.Size = new System.Drawing.Size(128, 51);
            this.btnEstatus.TabIndex = 7;
            this.btnEstatus.Text = "Estatus";
            this.btnEstatus.UseVisualStyleBackColor = true;
            // 
            // btnTipo
            // 
            this.btnTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnTipo.Location = new System.Drawing.Point(35, 427);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(128, 51);
            this.btnTipo.TabIndex = 6;
            this.btnTipo.Text = "Tipo Genérico";
            this.btnTipo.UseVisualStyleBackColor = true;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnProveedor.Location = new System.Drawing.Point(35, 358);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(128, 51);
            this.btnProveedor.TabIndex = 5;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnResguardo
            // 
            this.btnResguardo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnResguardo.Location = new System.Drawing.Point(35, 285);
            this.btnResguardo.Name = "btnResguardo";
            this.btnResguardo.Size = new System.Drawing.Size(128, 51);
            this.btnResguardo.TabIndex = 4;
            this.btnResguardo.Text = "Resguardo";
            this.btnResguardo.UseVisualStyleBackColor = true;
            this.btnResguardo.Click += new System.EventHandler(this.btnResguardo_Click);
            // 
            // btnPoliza
            // 
            this.btnPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnPoliza.Location = new System.Drawing.Point(35, 216);
            this.btnPoliza.Name = "btnPoliza";
            this.btnPoliza.Size = new System.Drawing.Size(128, 51);
            this.btnPoliza.TabIndex = 3;
            this.btnPoliza.Text = "Póliza Seguro";
            this.btnPoliza.UseVisualStyleBackColor = true;
            this.btnPoliza.Click += new System.EventHandler(this.btnPoliza_Click);
            // 
            // btnChofer
            // 
            this.btnChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnChofer.Location = new System.Drawing.Point(35, 142);
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Size = new System.Drawing.Size(128, 51);
            this.btnChofer.TabIndex = 2;
            this.btnChofer.Text = "Chofer";
            this.btnChofer.UseVisualStyleBackColor = true;
            this.btnChofer.Click += new System.EventHandler(this.btnChofer_Click);
            // 
            // btnPlaca
            // 
            this.btnPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnPlaca.Location = new System.Drawing.Point(35, 73);
            this.btnPlaca.Name = "btnPlaca";
            this.btnPlaca.Size = new System.Drawing.Size(128, 51);
            this.btnPlaca.TabIndex = 1;
            this.btnPlaca.Text = "Placa";
            this.btnPlaca.UseVisualStyleBackColor = true;
            this.btnPlaca.Click += new System.EventHandler(this.btnPlaca_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnVehiculo.Location = new System.Drawing.Point(35, 5);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(128, 51);
            this.btnVehiculo.TabIndex = 0;
            this.btnVehiculo.Text = "Vehículo";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(279, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(653, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Administración de Control Vehicular";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(539, 136);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(334, 295);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblUsuario.Location = new System.Drawing.Point(282, 504);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(179, 24);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Nombre del Usuario";
            // 
            // lblFechaTrabajo
            // 
            this.lblFechaTrabajo.AutoSize = true;
            this.lblFechaTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFechaTrabajo.Location = new System.Drawing.Point(282, 643);
            this.lblFechaTrabajo.Name = "lblFechaTrabajo";
            this.lblFechaTrabajo.Size = new System.Drawing.Size(64, 24);
            this.lblFechaTrabajo.TabIndex = 7;
            this.lblFechaTrabajo.Text = "Fecha";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblHoraActual.Location = new System.Drawing.Point(282, 779);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(105, 24);
            this.lblHoraActual.TabIndex = 9;
            this.lblHoraActual.Text = "Hora actual";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblEmpresa.Location = new System.Drawing.Point(669, 504);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(214, 24);
            this.lblEmpresa.TabIndex = 11;
            this.lblEmpresa.Text = "Nombre de la Secretaría";
            // 
            // lblAreaTrabajo
            // 
            this.lblAreaTrabajo.AutoSize = true;
            this.lblAreaTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblAreaTrabajo.Location = new System.Drawing.Point(669, 643);
            this.lblAreaTrabajo.Name = "lblAreaTrabajo";
            this.lblAreaTrabajo.Size = new System.Drawing.Size(146, 24);
            this.lblAreaTrabajo.TabIndex = 13;
            this.lblAreaTrabajo.Text = "Area de Trabajo";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.linkLabel1.Location = new System.Drawing.Point(502, 928);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 24);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "adcove@yucatan.gob.mx";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFecha.Location = new System.Drawing.Point(282, 693);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 24);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblHora.Location = new System.Drawing.Point(282, 826);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(105, 24);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "Hora actual";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(282, 554);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(179, 24);
            this.lblNombreUsuario.TabIndex = 19;
            this.lblNombreUsuario.Text = "Nombre del Usuario";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(669, 554);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(74, 24);
            this.lblNombreEmpresa.TabIndex = 20;
            this.lblNombreEmpresa.Text = "SEGEY";
            this.lblNombreEmpresa.Click += new System.EventHandler(this.lblNombreEmpresa_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblArea.Location = new System.Drawing.Point(669, 693);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(238, 24);
            this.lblArea.TabIndex = 21;
            this.lblArea.Text = "RECURSOS MATERIALES";
            // 
            // panelMttoVales
            // 
            this.panelMttoVales.Controls.Add(this.btnVales);
            this.panelMttoVales.Controls.Add(this.button10);
            this.panelMttoVales.Location = new System.Drawing.Point(4, 13);
            this.panelMttoVales.Name = "panelMttoVales";
            this.panelMttoVales.Size = new System.Drawing.Size(193, 933);
            this.panelMttoVales.TabIndex = 22;
            // 
            // btnVales
            // 
            this.btnVales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnVales.Location = new System.Drawing.Point(35, 85);
            this.btnVales.Name = "btnVales";
            this.btnVales.Size = new System.Drawing.Size(128, 51);
            this.btnVales.TabIndex = 9;
            this.btnVales.Text = "Vales";
            this.btnVales.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button10.Location = new System.Drawing.Point(35, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 51);
            this.button10.TabIndex = 0;
            this.button10.Text = "Vehículo";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            // 
            // panelMttoTraslado
            // 
            this.panelMttoTraslado.Controls.Add(this.btnTraslados);
            this.panelMttoTraslado.Controls.Add(this.button2);
            this.panelMttoTraslado.Location = new System.Drawing.Point(5, 13);
            this.panelMttoTraslado.Name = "panelMttoTraslado";
            this.panelMttoTraslado.Size = new System.Drawing.Size(189, 951);
            this.panelMttoTraslado.TabIndex = 23;
            // 
            // btnTraslados
            // 
            this.btnTraslados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnTraslados.Location = new System.Drawing.Point(35, 85);
            this.btnTraslados.Name = "btnTraslados";
            this.btnTraslados.Size = new System.Drawing.Size(128, 51);
            this.btnTraslados.TabIndex = 9;
            this.btnTraslados.Text = "Traslado";
            this.btnTraslados.UseVisualStyleBackColor = true;
            this.btnTraslados.Click += new System.EventHandler(this.btnTraslados_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button2.Location = new System.Drawing.Point(35, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 51);
            this.button2.TabIndex = 0;
            this.button2.Text = "Vehículo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1262, 985);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblAreaTrabajo);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblHoraActual);
            this.Controls.Add(this.lblFechaTrabajo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelMenuAuxiliar);
            this.Controls.Add(this.panelMenuPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "SEGEY - CONTROL VEHICULAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenuPrincipal.ResumeLayout(false);
            this.panelMenuAuxiliar.ResumeLayout(false);
            this.panelMttoVhicular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMttoVales.ResumeLayout(false);
            this.panelMttoTraslado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Button btnMttoVehicular;
        private System.Windows.Forms.Panel panelMenuAuxiliar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTraslado;
        private System.Windows.Forms.Button btnValeViatico;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFechaTrabajo;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblAreaTrabajo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Panel panelMttoVhicular;
        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnResguardo;
        private System.Windows.Forms.Button btnPoliza;
        private System.Windows.Forms.Button btnChofer;
        private System.Windows.Forms.Button btnPlaca;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnMttoVehiculo;
        private System.Windows.Forms.Button btnNivel;
        private System.Windows.Forms.Button btnEstatus;
        private System.Windows.Forms.Panel panelMttoVales;
        private System.Windows.Forms.Button btnVales;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panelMttoTraslado;
        private System.Windows.Forms.Button btnTraslados;
        private System.Windows.Forms.Button button2;
    }
}

