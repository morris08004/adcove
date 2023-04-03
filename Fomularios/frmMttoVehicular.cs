using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wCWdrmApp
{
    public partial class frmMttoVehicular : Form
    {
        private Conexion mConexion;

        string cm = "";

        //variable publicas
        public string vcAccion { get; set; }
        public int vcValor { get; set; }

        private string vcUsuario;

        public frmMttoVehicular(string pcAccion, int piFolio, string pcUsuario)
        {
            InitializeComponent();

            mConexion = new Conexion();

            vcAccion = pcAccion;
            vcUsuario = pcUsuario;

            poblaCombos();
            //poblarBrowse(dgvMtto);
            if (pcAccion == "N" || pcAccion == "E") { estadoObjeto(true); } else { estadoObjeto(false); }
            
        }

        private void frmMttoVehicular_Load(object sender, EventArgs e)
        {

        }

        private void poblaCombos()
        {
            cmbTipoMtto.Items.Clear();
            cmbTipoArrendamiento.Items.Clear();
            cmbTipoVehiculo.Items.Clear();
            cmbMarca.Items.Clear();
            cmbTaller.Items.Clear();

            string sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'MT' ";
            DataTable dt = new DataTable();

            if (mConexion.getConexion() != null)
            {
                try
                {
                    MySqlCommand commandM = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter daM = new MySqlDataAdapter(commandM);
                    DataTable dtM = new DataTable();
                    daM.Fill(dtM);
                    cmbTipoMtto.DisplayMember = "cDescripcion";
                      cmbTipoMtto.ValueMember = "iIdTipo";
                       cmbTipoMtto.DataSource = dtM;

                    // -----------------------------
                    sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'V' ;";
                    MySqlCommand commandV = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter daV = new MySqlDataAdapter(commandV);
                    DataTable dtV = new DataTable();
                    daV.Fill(dtV);
                    cmbTipoVehiculo.DisplayMember = "cDescripcion";
                    cmbTipoVehiculo.ValueMember = "iIdTipo";
                    cmbTipoVehiculo.DataSource = dtV;

                    // -----------------------------
                    sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'A' ;";
                    MySqlCommand commandA = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter daA = new MySqlDataAdapter(commandA);
                    DataTable dtA = new DataTable();
                    daA.Fill(dtA);
                    cmbTipoArrendamiento.DisplayMember = "cDescripcion";
                    cmbTipoArrendamiento.ValueMember = "iIdTipo";
                    cmbTipoArrendamiento.DataSource = dtA;

                    // -----------------------------
                    sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'M' ;";
                    MySqlCommand commandTC = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dTC = new MySqlDataAdapter(commandTC);
                    DataTable dtTC = new DataTable();
                    dTC.Fill(dtTC);
                    cmbMarca.DisplayMember = "cDescripcion";
                    cmbMarca.ValueMember = "iIdTipo";
                    cmbMarca.DataSource = dtTC;

                    // -----------------------------
                    sql = "SELECT * FROM Proveedor p WHERE p.iTaller = 1";
                    MySqlCommand commandCon = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dCon = new MySqlDataAdapter(commandCon);
                    DataTable dtCon = new DataTable();
                    dCon.Fill(dtCon);
                    cmbTaller.DisplayMember = "cNombre";
                    cmbTaller.ValueMember = "iIdproveedor";
                    cmbTaller.DataSource = dtCon;
                    // -----------------------------
                    sql = "SELECT * FROM estatus";
                    MySqlCommand commandSV = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dSV = new MySqlDataAdapter(commandSV);
                    DataTable dtSV = new DataTable();
                    dSV.Fill(dtSV);
                    cmbEstatus.DisplayMember = "cEstatus";
                    cmbEstatus.ValueMember = "iIdEstatus";
                    cmbEstatus.DataSource = dtSV;                   
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }



            }  // getConexion != null

        }  // poblaCombos

        private void estadoObjeto(bool plEstado)
        {
            if (plEstado == true)
            {
                txtiFolio.Enabled = false;
                txtiDireccion.Enabled = true;
                txtiDepartamento.Enabled = true;
                txtiArea.Enabled = true;
                txtcResponsableArea.Enabled = false;
                cmbTipoMtto.Enabled = true;
                txtcDireccion.Enabled = false;
                txtcDepartamento.Enabled = false;
                txtcArea.Enabled = false;
                txtPlaca.Enabled = true;
                txtModelo.Enabled = false;
                cmbTipoArrendamiento.Enabled = false;
                cmbTipoVehiculo.Enabled = false;
                cmbMarca.Enabled = false;
                txtKm.Enabled = false;
                txtcMotivo.Enabled = true;
                txtcConcepto.Enabled = true;
                txtcResponsable.Enabled = false;
                cmbTaller.Enabled = true;
                dtpEntrada.Enabled = true;
                dtpSalida.Enabled = true;
                dtpConformidad.Enabled = true;
                txtiPresupuesto.Enabled = true;
                dtpPresupuesto.Enabled = true;
                txtdePresupuesto.Enabled = true;
                txtiFactura.Enabled = true;
                dtpFatura.Enabled = true;
                txtdeFactura.Enabled = true;
                txtiAsignacion.Enabled = true;
                txtdeAsignacion.Enabled = true;
                dtpAsignacion.Enabled = true;
                txtKmEntrada.Enabled = true;
                txtKmSalida.Enabled = true;
                txtcResponsableArea.Enabled = true;
                txtcTelefono.Enabled = true;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;                
            }
            else
            {
                txtiFolio.Enabled = false;
                txtiDireccion.Enabled = false;
                txtiDepartamento.Enabled = false;
                txtiArea.Enabled = false;
                txtcResponsableArea.Enabled = false;
                cmbTipoMtto.Enabled = false;
                txtcDireccion.Enabled = false;
                txtcDepartamento.Enabled = false;
                txtcArea.Enabled = false;
                txtPlaca.Enabled = false;
                txtModelo.Enabled = false;
                cmbTipoArrendamiento.Enabled = false;
                cmbTipoVehiculo.Enabled = false;
                cmbMarca.Enabled = false;
                txtKm.Enabled = false;
                txtcMotivo.Enabled = false;
                txtcConcepto.Enabled = false;
                txtcResponsable.Enabled = false;
                cmbTaller.Enabled = false;
                dtpEntrada.Enabled = false;
                dtpSalida.Enabled = false;
                dtpConformidad.Enabled = false;
                txtiPresupuesto.Enabled = false;
                dtpPresupuesto.Enabled = false;
                txtdePresupuesto.Enabled = false;
                txtiFactura.Enabled = false;
                dtpFatura.Enabled = false;
                txtdeFactura.Enabled = false;
                txtiAsignacion.Enabled = false;
                txtdeAsignacion.Enabled = false;
                dtpAsignacion.Enabled = false;
                txtKmEntrada.Enabled = true;
                txtKmSalida.Enabled = true;
                txtcResponsableArea.Enabled = false;
                txtcTelefono.Enabled = false;

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                
            }
        }

        private void txtiDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine whethedr the keystroke is a number from the top of the keyboard.
            if (e.KeyCode == Keys.F3)  // || e.KeyCode > Keys.D9
            {
                e.Handled = true;
                frmConsulta frm = new frmConsulta(0, 1);
                frm.ShowDialog();

                //variable publicas
                string vcIdLocal = frm.vcId;
                string vcNombre = frm.vcValor;

                if (vcIdLocal != "")
                {
                    txtiDireccion.Text = vcIdLocal;
                    txtcDireccion.Text = vcNombre;
                }
            }
        }

        private void txtiDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine whethedr the keystroke is a number from the top of the keyboard.
            if (e.KeyCode == Keys.F3)  // || e.KeyCode > Keys.D9
            {
                int vidireccion = Convert.ToInt32(txtiDireccion.Text);

                e.Handled = true;
                frmConsulta frm = new frmConsulta(0, vidireccion);
                frm.ShowDialog();

                //variable publicas
                string vcIdLocal = frm.vcId;
                string vcNombre = frm.vcValor;

                if (vcIdLocal != "")
                {
                    txtiDepartamento.Text = vcIdLocal;
                    txtcDepartamento.Text = vcNombre;
                }
            }
        }

        private void txtiArea_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine whethedr the keystroke is a number from the top of the keyboard.
            if (e.KeyCode == Keys.F3)  // || e.KeyCode > Keys.D9
            {
                e.Handled = true;
                frmConsulta frm = new frmConsulta(1, 0);
                frm.ShowDialog();

                //variable publicas
                string vcIdLocal = frm.vcId;
                string vcNombre = frm.vcValor;
                txtiArea.Text = vcIdLocal;
                txtcArea.Text = vcNombre;
                txtcResponsableArea.Text = "";

                if (vcIdLocal != "")
                {
                    string sql = "";
                    // -------------  busca su id del resguardo

                    MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

                    con.Open();
                    sql = "SELECT * FROM Resguardo where iAreaServicio=" + vcIdLocal.ToString() +
                          " AND iNodo = " + txtiDepartamento.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //cmd.Parameters.AddWithValue("@producto", piPoliza);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        
                        txtcResponsableArea.Text = reader.GetString(3);
                        
                    } // (reader.Read())
                    con.Close();
                } // (vcIdLocal != "")
            }
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine whethedr the keystroke is a number from the top of the keyboard.
            if (e.KeyCode == Keys.F3)  // || e.KeyCode > Keys.D9
            {
                e.Handled = true;
                frmConsulta frm = new frmConsulta(3, 0);
                frm.ShowDialog();

                //variable publicas
                string vcIdLocal = frm.vcId;
                string vcNombre = frm.vcValor;

                if (vcIdLocal != "")
                {
                    txtPlaca.Text = vcIdLocal;
                    //txtcChofer.Text = vcNombre;


                } // (vcIdLocal != "")
            }

            if (e.KeyCode == Keys.Return)
            {
                dameVehiculo(txtPlaca.Text);
            }
        }

        private void txtiDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiAsignacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdePresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtdeFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtdeAsignacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int viDevuelve = 0;
            /*int viValida = 0;

            viValida = validaObjeto(txtiFolio.Text, cmbTipoMtto.SelectedValue, txtiDireccion.Text, txtiDepartamento.Text, txtiArea.Text,
                                    txtcResponsableArea.Text, txtPlaca.Text, txtModelo.Text, cmbTipoArrendamiento.SelectedValue,
                                    cmbTipoVehiculo.SelectedValue, cmbMarca.SelectedValue, txtKm.Text, txtcMotivo.Text,
                                    txtcConcepto.Text, cmbTaller.SelectedValue, txtcResponsable.Text,
                                    dtpEntrada.Value, dtpSalida.Value, dtpConformidad.Value, txtiPresupuesto.Text,dtpPresupuesto.Value,
                                    txtdePresupuesto.Text,txtiFactura.Text,dtpFatura.Value,txtdeFactura,
                                    txtiAsignacion.Text,dtpAsignacion.Value,txtdeAsignacion.Text);
            if (viValida == 1) // 1 = Error   0 = ok
            {
                MessageBox.Show("ERROR: uno ó mas campos no tienen valor capturado");
                return;
            }*/
            estadoObjeto(false);
            viDevuelve = guardarObjeto(txtiFolio.Text, cmbTipoMtto.SelectedValue.ToString(), txtiDireccion.Text, txtiDepartamento.Text, txtiArea.Text,
                                    txtcResponsableArea.Text, txtPlaca.Text, txtModelo.Text, cmbTipoArrendamiento.SelectedValue.ToString(),
                                    cmbTipoVehiculo.SelectedValue.ToString(), cmbMarca.SelectedValue.ToString(), txtKm.Text, txtcMotivo.Text,
                                    txtcConcepto.Text, cmbTaller.SelectedValue.ToString(), txtcResponsable.Text,
                                    dtpEntrada.Value, dtpSalida.Value, dtpConformidad.Value, txtiPresupuesto.Text, dtpPresupuesto.Value,
                                    txtdePresupuesto.Text, txtiFactura.Text, dtpFatura.Value, txtdeFactura.Text,
                                    txtiAsignacion.Text, dtpAsignacion.Value, txtdeAsignacion.Text, cmbEstatus.SelectedValue.ToString(),
                                    txtiVehiculo.Text,txtcTelefono.Text,"Observaciones",txtKmEntrada.Text,txtKmSalida.Text);

            if (viDevuelve != 0)
            {
                switch (vcAccion)
                {
                    case "N":
                        txtiFolio.Text = viDevuelve.ToString();
                        MessageBox.Show("Mantenimiento a Vehiculo registrado exitosamente");

                        break;
                    case "E":
                        MessageBox.Show("Cambios registrados exitosamente");
                        break;
                }
                vcAccion = "";
                //poblarBrowse(dgvVehiculo);
            }  // viDevuelve!=0
            else
            {
                MessageBox.Show("Adicion/cambio del registro no efectuado");
            }
        }

        private int guardarObjeto(string piFolio, string piTipoMtto, string piDireccion, string piDepto, string piArea,
                                   string pcRespMarca, string pcPlaca, string pcModelo, string piTipoArre, string piTipoVehiculo,
                                   string piMarca, string piKM, string pcMotivo, string pcConcepto,
                                   string piTaller, string pcResponsable, DateTime pdtEntrada, DateTime pdtSalida, DateTime pdtConformidad,
                                   string piPresupuesto, DateTime pdtPresupuesto, string pdePresupuesto,
                                   string piFactura, DateTime pdtFactura, string pdeFactura,
                                   string piAsignacion, DateTime pdtAsignacion, string pdeAsignacion, string piEstatus,string piVehiculo,
                                   string pcTelefono, string pcObservaciones, string piKmEntrada, string piKmSalida)
        {
            int codigoRegistroInsertado = 0;
            string sqlEjecutar = "";

            switch (vcAccion)
            {
                case "N":
                    sqlEjecutar = "insert into mttovehiculo (iIdProveedor,iIdVehiculo,IdArea,iIdDepartamento,iTipoMovto,cResponsable,"
                                 + "cTelefono,cMotivo,iIdAeraSolicita,cFolioPlaca,cMotivoSolicitud,cConceptoFactura,"
                                 + "cObservaciones,dtEntrada,iKilometrajeEntrada,dtSalida,iKilometrajeSalida,dtConformidad,"
                                 + "iPresupuesto,dtPresupuesto,dePresupuesto,iFactura,dtFactura,deFactura,iAsignacion,"
                                 + "dtAsignacion,deAsignacion,iIdEstatus,dtRegistro,cIdusuario) "
                                + "VALUES (@proveedor, @vehiculo, @area, @depto, @tipomovto, @responsable,"
                                + "@telefono, @motivo, @areasolicita, @placa,@motivoSol,@concepto,"
                                + "@observa,@entrada,@kmentrada,@salida, @kmsalida, @conformidad,"
                                + "@presupuesto,@fechapto,@dePresupuesto,@factura,@fechafactura,@defactura,@asignacion,"
                                + "@fechaasignacion,@deasignacion,@estatus,@dtregistro,@usuario)"
                                /* "insert into mttovehiculo (iIdProveedor,iIdVehiculo,IdArea,iIdDepartamento,iTipoMovto,cResponsable,"
                                       + "cTelefono,cMotivo,iIdAeraSolicita,cFolioPlaca,cMotivoSolicitud,cConceptoFactura,"
                                       + "cObservaciones,dtEntrada,iKilometrajeEntrada,dtSalida,iKilometrajeSalida,dtConformidad,"
                                       + "iPresupuesto,dtPresupuesto,dePresupuesto,iFactura,dtFactura,deFactura,iAsignacion,"
                                       + "dtAsignacion,deAsignacion,iIdEstatus,dtRegistro,cIdusuario) "
                                       + " VALUES (@proveedor, @vehiculo, @area, @depto, @tipomovto, @responsable,"
                                       + "@telefono, @motivo, @areasolicita, @placa,@motivoSol,@concepto, @observa,"
                                       + "@entrada,@kmentrada,@salida, @kmsalida, @conformidad, @presupuesto,@fechapto,@dePresupuesto,"
                                       + "@factura,@fechafactura,@defactura,@asignacion,@fechaasignacion,@deasignacion,@estatus,@dtregistro,@usuario)"*/
                                ;
                    //+ ")";
                    break;
                case "E":
                    sqlEjecutar = "UPDATE mttovehiculo SET iIdProveedor=@proveedor,iIdVehiculo=@vehiculo,iIdArea=@area,iIdDepartamento=@depto,"
                                + "iTipoMovto=@tipomovto,cResponsable=@responsable,cTelefono=@telefono,cMotivo=@motivo,iIdAeraSolicita=@areasolicita,"
                                + "cFolioPlaca=@placa,cMotivoSolicitud=@motivoSol,cConceptoFactura=@concepto,cObservaciones=@observa,"
                                + " dtEntrada=@entrada, iKilometrajeEntrada=@kmentrada, dtSalida=@salida,iKilometrajeSalida=@kmsalida,"
                                + "dtConformidad=@conformidad,iPresupuesto=@presupuesto,dtPresupuesto=@fechapto,dePresupuesto=@dePresupuesto,"
                                + "iFactura=@factura,dtFactura=@fechafactura,deFactura=@defactura,iAsignacion=@asignacion,"
                                + "dtAsignacion=fechaasignacion,deAsignacion=@deasignacion,iIdEstatus=@estatus WHERE iIdMtto=@mtto";
                    break;
            }

            //Para SQL Server cambiar SELECT LAST_INSERT_ID() por SCOPE_IDENTITY()
            try
            {
                MySqlCommand comandoSQL = new MySqlCommand();

                string     vdtEntrada = $"{pdtEntrada:yyyy-MM-dd HH:hh:dd}";
                string      vdtSalida = $"{pdtSalida:yyyy-MM-dd HH:mm:dd}";
                string vdtConformidad = $"{pdtConformidad:yyyy-MM-dd HH:hh:dd}";
                string vdtPresupuesto = $"{pdtPresupuesto:yyyy-MM-dd HH:mm:dd}";
                string     vdtFactura = $"{pdtFactura:yyyy-MM-dd HH:hh:dd}";
                string  vdtAsignacion = $"{pdtAsignacion:yyyy-MM-dd HH:mm:dd}";

                comandoSQL.Connection = mConexion.getConexion();
                comandoSQL.CommandText = sqlEjecutar;

                switch (vcAccion)
                {
                    case "N":
                        //comandoSQL.Parameters.Add("@Vehiculo", MySqlDbType.Int32).Value = 0;
                        comandoSQL.Parameters.Add("@proveedor", MySqlDbType.Int32).Value = piTaller;
                        comandoSQL.Parameters.Add("@vehiculo", MySqlDbType.Int32).Value = piVehiculo;
                        comandoSQL.Parameters.Add("@area", MySqlDbType.Int32).Value = piArea;
                        comandoSQL.Parameters.Add("@depto", MySqlDbType.Int32).Value = piDepto;
                        comandoSQL.Parameters.Add("@tipomovto", MySqlDbType.Int32).Value = piTipoMtto;
                        comandoSQL.Parameters.Add("@responsable", MySqlDbType.String).Value = pcResponsable;
                        comandoSQL.Parameters.Add("@telefono", MySqlDbType.String).Value = pcTelefono;
                        comandoSQL.Parameters.Add("@motivo", MySqlDbType.String).Value = pcMotivo;
                        comandoSQL.Parameters.Add("@areasolicita", MySqlDbType.Int32).Value = piArea;
                        comandoSQL.Parameters.Add("@placa", MySqlDbType.String).Value = pcPlaca;
                        comandoSQL.Parameters.Add("@motivoSol", MySqlDbType.String).Value = pcMotivo;
                          comandoSQL.Parameters.Add("@concepto", MySqlDbType.String).Value = pcConcepto; //Convert.ToInt32(piMarca);
                          comandoSQL.Parameters.Add("@observa", MySqlDbType.String).Value = pcObservaciones;
                          comandoSQL.Parameters.Add("@entrada", MySqlDbType.DateTime).Value = vdtEntrada; //Convert.ToInt32(pitipoArrend);
                          comandoSQL.Parameters.Add("@kmentrada", MySqlDbType.Int32).Value = piKmEntrada; //Convert.ToInt32(piChofer);
                          comandoSQL.Parameters.Add("@salida", MySqlDbType.DateTime).Value = vdtSalida; //Convert.ToDateTime(vdtAfina);
                          comandoSQL.Parameters.Add("@kmsalida", MySqlDbType.Int32).Value = piKmSalida; //Convert.ToDateTime(vdtArrend);
                          comandoSQL.Parameters.Add("@conformidad", MySqlDbType.DateTime).Value = vdtConformidad; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@presupuesto", MySqlDbType.Int32).Value = piPresupuesto;
                           comandoSQL.Parameters.Add("@fechapto", MySqlDbType.DateTime).Value = vdtPresupuesto; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@depresupuesto", MySqlDbType.Decimal).Value = pdePresupuesto; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@factura", MySqlDbType.Int32).Value = piFactura; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@fechafactura", MySqlDbType.DateTime).Value = vdtFactura; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@defactura", MySqlDbType.Decimal).Value = pdeFactura; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@asignacion", MySqlDbType.Int32).Value = piAsignacion; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@fechaasignacion", MySqlDbType.DateTime).Value = vdtAsignacion; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@deasignacion", MySqlDbType.Decimal).Value = pdeAsignacion; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@estatus", MySqlDbType.Int32).Value = piEstatus; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@dtregistro", MySqlDbType.DateTime).Value = DateTime.Now; //Convert.ToInt32(piResguardo);
                          comandoSQL.Parameters.Add("@usuario", MySqlDbType.String).Value = vcUsuario; //Convert.ToInt32(piResguardo);   

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                        comandoSQL.CommandText = " SELECT LAST_INSERT_ID()";
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());

                        return codigoRegistroInsertado;
                    case "E":
                        comandoSQL.Parameters.Add("@proveedor", MySqlDbType.Int32).Value = piTaller;
                        comandoSQL.Parameters.Add("@vehiculo", MySqlDbType.Int32).Value = piVehiculo;
                        comandoSQL.Parameters.Add("@area", MySqlDbType.Int32).Value = piArea;
                        comandoSQL.Parameters.Add("@depto", MySqlDbType.Int32).Value = piDepto;
                        comandoSQL.Parameters.Add("@tipomovto", MySqlDbType.Int32).Value = piTipoMtto;
                        comandoSQL.Parameters.Add("@responsable", MySqlDbType.String).Value = pcResponsable;
                        comandoSQL.Parameters.Add("@telefono", MySqlDbType.String).Value = pcTelefono;
                        comandoSQL.Parameters.Add("@motivo", MySqlDbType.String).Value = pcMotivo;
                        comandoSQL.Parameters.Add("@areasolicita", MySqlDbType.Int32).Value = piArea;
                        comandoSQL.Parameters.Add("@placa", MySqlDbType.String).Value = pcPlaca;
                        comandoSQL.Parameters.Add("@motivo", MySqlDbType.String).Value = pcMotivo;
                        comandoSQL.Parameters.Add("@concepto", MySqlDbType.String).Value = pcConcepto; //Convert.ToInt32(piMarca);
                        comandoSQL.Parameters.Add("@observa", MySqlDbType.String).Value = pcObservaciones;
                        comandoSQL.Parameters.Add("@entrada", MySqlDbType.DateTime).Value = vdtEntrada; //Convert.ToInt32(pitipoArrend);
                        comandoSQL.Parameters.Add("@kmentrada", MySqlDbType.Int32).Value = piKmEntrada; //Convert.ToInt32(piChofer);
                        comandoSQL.Parameters.Add("@salida", MySqlDbType.Int32).Value = vdtSalida; //Convert.ToDateTime(vdtAfina);
                        comandoSQL.Parameters.Add("@kmsalida", MySqlDbType.Int32).Value = piKmSalida; //Convert.ToDateTime(vdtArrend);
                        comandoSQL.Parameters.Add("@conformidad", MySqlDbType.DateTime).Value = vdtConformidad; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@presupuesto", MySqlDbType.Int32).Value = piPresupuesto;
                        comandoSQL.Parameters.Add("@fechapto", MySqlDbType.DateTime).Value = vdtPresupuesto; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@depresupuesto", MySqlDbType.Decimal).Value = pdePresupuesto; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@factura", MySqlDbType.Int32).Value = piFactura; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@fechafactura", MySqlDbType.DateTime).Value = vdtFactura; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@defactura", MySqlDbType.Decimal).Value = pdeFactura; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@asignacion", MySqlDbType.Int32).Value = piAsignacion; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@fechaasignacion", MySqlDbType.DateTime).Value = vdtAsignacion; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@deasignacion", MySqlDbType.Decimal).Value = pdeAsignacion; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@estatus", MySqlDbType.Int32).Value = piEstatus; //Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@mtto", MySqlDbType.Int32).Value = piTipoMtto;

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteNonQuery());
                        break;
                }

                return codigoRegistroInsertado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Añadir/Modificar registro [" + piVehiculo.ToString() + "]: " + ex.Message);
                //new EscribirLog("Error al añadir dispositivo [" + tipo + "]: " + ex.Message, true);
                return codigoRegistroInsertado; //0 si ha habido algún error
            }
            finally
            {
                //conexionBD.Close();
            }
        } //guardarObjeto

        private void txtKmEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKmSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dameVehiculo (string pcPlaca)
        {
            
                string sql = "";
            // -------------  busca su id del resguardo

            MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

            con.Open();
            sql = "SELECT iIdVehiculo,iModelo,iIdTipoAdquisicion,iIdTipoVehiculo,iIdMarca,iKilometraje FROM vehiculo v where v.cFolioPlaca='" + pcPlaca + "';";                  
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtiVehiculo.Text = reader.GetString(0);
                txtModelo.Text = reader.GetString(1);
                cmbTipoArrendamiento.SelectedValue = reader.GetString(2);
                cmbTipoVehiculo.SelectedValue = reader.GetString(3);
                cmbMarca.SelectedValue = reader.GetString(4);
                txtKm.Text = reader.GetString(5);

            } // (reader.Read())
            con.Close();
        }

        private void cmbTaller_SelectedValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dameResponsableProveedor(string piproveedor)
        {
                         string sql = "";
               txtcResponsable.Text = "";
            txtcTelefonoTaller.Text = "";
            // -------------  busca el responsable de la empresa

            MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

            con.Open();
            sql = "SELECT cResponsable,cTelefono FROM proveedor p where p.italler=1 AND p.iIdProveedor=" + piproveedor.ToString() + ";";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtcResponsable.Text = reader.GetString(0);
                txtcTelefonoTaller.Text = reader.GetString(1);
                

            } // (reader.Read())
            con.Close();
        }

        private void cmbTaller_KeyDown(object sender, KeyEventArgs e)
        {
             
        }

        private void cmbTaller_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbTaller.SelectedItem.ToString()))
            {
                dameResponsableProveedor(cmbTaller.SelectedItem.ToString());
            }
        }
    }
}
