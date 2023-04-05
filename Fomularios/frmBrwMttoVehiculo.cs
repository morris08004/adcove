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
    public partial class frmBrwMttoVehiculo : Form
    {
        private Conexion mConexion;
        private string pcAccion = "";
        private string vcUsuario;

        public frmBrwMttoVehiculo(string pcUsuario)
        {
            InitializeComponent();
            mConexion = new Conexion();

            vcUsuario = pcUsuario;

            poblaCombos();
            poblarBrowse(dgvMtto);
            estadoObjeto(false);
        }

        private void poblarBrowse(DataGridView grid)
        {
            // MySqlCommand cm = new MySqlCommand("SELECT * FROM vehiculo;", con);
            string cm = "SELECT * FROM mttovehiculo";

            //MySqlDataAdapter da = null;

            if (mConexion.getConexion() != null)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(cm, mConexion.getConexion());
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    grid.DataSource = dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        } // poblarBrowse

        private void poblaCombos()
        {
            cmbTipoMtto.Items.Clear();
            cmbMarca.Items.Clear();
            cmbTipoVehiculo.Items.Clear();
            cmbTipoArrendamiento.Items.Clear();
            cmbTaller.Items.Clear();

            string sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'M' ";
            DataTable dt = new DataTable();

            if (mConexion.getConexion() != null)
            {
                try
                {
                    MySqlCommand commandM = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter daM = new MySqlDataAdapter(commandM);
                    DataTable dtM = new DataTable();
                    daM.Fill(dtM);
                    cmbMarca.DisplayMember = "cDescripcion";
                    cmbMarca.ValueMember = "iIdTipo";
                    cmbMarca.DataSource = dtM;

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
                    sql = "SELECT * FROM proveedor ;";
                    MySqlCommand commandTC = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dTC = new MySqlDataAdapter(commandTC);
                    DataTable dtTC = new DataTable();
                    dTC.Fill(dtTC);
                    cmbTaller.DisplayMember = "cNombre";
                    cmbTaller.ValueMember = "iIdProveedor";
                    cmbTaller.DataSource = dtTC;

                    // -----------------------------
                    sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'MT' ;";
                    MySqlCommand commandMT = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dMT = new MySqlDataAdapter(commandMT);
                    DataTable dtMT = new DataTable();
                    dMT.Fill(dtMT);
                    cmbTipoMtto.DisplayMember = "cDescripcion";
                    cmbTipoMtto.ValueMember = "iIdTipo";
                    cmbTipoMtto.DataSource = dtMT;

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
                txtiFolio.Enabled = true;
                txtiDireccion.Enabled = true;
                txtiDepartamento.Enabled = true;
                txtiArea.Enabled = true;
                txtcResponsableArea.Enabled = true;
                cmbTipoMtto.Enabled = true;
                txtcDireccion.Enabled = true;
                txtcDepartamento.Enabled = true;
                txtcArea.Enabled = true;
                txtPlaca.Enabled = true;
                txtModelo.Enabled = true;
                cmbTipoArrendamiento.Enabled = true;
                cmbTipoVehiculo.Enabled = true;
                cmbMarca.Enabled = true;
                txtKm.Enabled = true;
                txtcMotivo.Enabled = true;
                txtcConcepto.Enabled = true;
                txtcResponsable.Enabled = true;
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

                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
                btnBorrar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;
            }
            else
            {
                txtiFolio.Enabled = false;
                txtiDireccion.Enabled = false;
                txtiDepartamento.Enabled = false;
                txtiArea.Enabled = false;
                txtcResponsableArea.Enabled = false;
                cmbTipoMtto.Enabled = true;
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

                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
            }
        } // EstadoObjeto

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            //var row = (sender as DataGridView).CurrentRow;
            int viFolio = 0;
            frmMttoVehicular frm = new frmMttoVehicular("N", viFolio, vcUsuario);
            frm.ShowDialog();

            poblarBrowse(dgvMtto);

            //variable publicas
            /*string vcIdLocal = frm.vcId;
            string vcNombre = frm.vcValor;*/

            /*if (vcIdLocal != "")
            {
                txtiDireccion.Text = vcIdLocal;
                txtcDireccion.Text = vcNombre;
            }*/
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            //var row = (sender as DataGridView).CurrentRow;
            int viFolio = 0;

            if (!string.IsNullOrEmpty(dgvMtto.CurrentRow.Cells[0].Value.ToString()))
            {
                viFolio = Convert.ToInt32(dgvMtto.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                viFolio = 0;
            }


            frmMttoVehicular frm = new frmMttoVehicular("E", viFolio, vcUsuario);
            frm.ShowDialog();

            poblarBrowse(dgvMtto);

            //variable publicas
            /*string vcIdLocal = frm.vcId;
            string vcNombre = frm.vcValor;*/

            /*if (vcIdLocal != "")
            {
                txtiDireccion.Text = vcIdLocal;
                txtcDireccion.Text = vcNombre;
            }*/
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            //var row = (sender as DataGridView).CurrentRow;
            int viFolio = 0;

            if (!string.IsNullOrEmpty(dgvMtto.CurrentRow.Cells[0].Value.ToString()))
            {
                viFolio = Convert.ToInt32(dgvMtto.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                viFolio = 0;
            }

            frmMttoVehicular frm = new frmMttoVehicular("B", viFolio, vcUsuario);
            frm.ShowDialog();

        }

        private void dgvMtto_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            /*  int viInicia = Convert.ToInt32(row.Cells[10].Value.ToString());
              int viTermina = Convert.ToInt32(row.Cells[11].Value.ToString());

              string vcInicia = convertirSegundosHorasMinutos(viInicia);
              string vcTermina = convertirSegundosHorasMinutos(viTermina);  */

            txtiFolio.Text = row.Cells[0].Value.ToString();
            cmbTaller.SelectedValue = row.Cells[1].Value.ToString();
            dameProveedor(row.Cells[1].Value.ToString());

            
            txtiDepartamento.Text = row.Cells[4].Value.ToString();
            txtiArea.Text = row.Cells[3].Value.ToString();
            txtcResponsableArea.Text = row.Cells[6].Value.ToString();
                   //          depto                        area
            dameArea(row.Cells[4].Value.ToString(), row.Cells[3].Value.ToString());

            if (!string.IsNullOrEmpty(row.Cells[5].Value.ToString())) { cmbTipoMtto.SelectedValue = row.Cells[5].Value.ToString(); }

            txtPlaca.Text = row.Cells[10].Value.ToString();
            poblaVehiculo(txtPlaca.Text);


            txtcMotivo.Text = row.Cells[11].Value.ToString();
            txtcConcepto.Text = row.Cells[12].Value.ToString();
            
            if (!string.IsNullOrEmpty(row.Cells[14].Value.ToString())) { dtpEntrada.Value = Convert.ToDateTime(row.Cells[14].Value.ToString()); }
            if (!string.IsNullOrEmpty(row.Cells[16].Value.ToString())) { dtpSalida.Value = Convert.ToDateTime(row.Cells[16].Value.ToString()); }
            if (!string.IsNullOrEmpty(row.Cells[18].Value.ToString())) { dtpConformidad.Value = Convert.ToDateTime(row.Cells[18].Value.ToString()); }
            if (!string.IsNullOrEmpty(row.Cells[20].Value.ToString())) { dtpPresupuesto.Value = Convert.ToDateTime(row.Cells[20].Value.ToString()); }
            if (!string.IsNullOrEmpty(row.Cells[23].Value.ToString())) { dtpFatura.Value = Convert.ToDateTime(row.Cells[23].Value.ToString()); }
            if (!string.IsNullOrEmpty(row.Cells[26].Value.ToString())) { dtpAsignacion.Value = Convert.ToDateTime(row.Cells[26].Value.ToString()); }

            txtiPresupuesto.Text = row.Cells[19].Value.ToString();
            txtdePresupuesto.Text = row.Cells[21].Value.ToString();
            txtiFactura.Text = row.Cells[22].Value.ToString();
            txtdeFactura.Text = row.Cells[24].Value.ToString();
            txtiAsignacion.Text = row.Cells[25].Value.ToString();
            txtdeAsignacion.Text = row.Cells[27].Value.ToString();
            txtKmEntrada.Text = row.Cells[15].Value.ToString();
            txtKmSalida.Text = row.Cells[17].Value.ToString();
            txtcTelefono.Text = row.Cells[7].Value.ToString();

            // MessageBox.Show("importe:" + txtdeAsignacion.Text);


        } // dgvMtto_SelectionChanged

        private void poblaVehiculo (string pcPlaca)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

            txtModelo.Text = "";
            cmbTipoArrendamiento.SelectedValue = 0;
            cmbTipoVehiculo.SelectedValue = 0;
            cmbMarca.SelectedValue = 0;
            txtKm.Text = "";
            //cmbTaller.SelectedValue = 0;
            txtcResponsable.Text = "";

            try
            {
                con.Open();
                string sql = "SELECT iModelo,iIdTipoAdquisicion,iIdTipoVehiculo,iIdMarca,iKilometraje,"
                           + "iIdProveedor, cResponsable FROM vehiculo where cFolioPlaca='" + pcPlaca + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@producto", piPoliza);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                                        txtModelo.Text = reader.GetString(0);
                    cmbTipoArrendamiento.SelectedValue = reader.GetString(1); 
                         cmbTipoVehiculo.SelectedValue = reader.GetString(2); 
                                cmbMarca.SelectedValue = reader.GetString(3);
                                            txtKm.Text = reader.GetString(4);
                    //if (!string.IsNullOrEmpty(reader.GetString(5))) { cmbTaller.SelectedValue = reader.GetString(5); }
                                  txtcResponsable.Text = reader.GetString(6);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("No fue posible obtener la poliza de seguro");
            }
            finally
            {
                con.Close();
            }                       
        } // poblaVehiculo

        private void dameProveedor(string piProveedor)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

            txtcResponsableTaller.Text = "";
            txtcTelefonoTaller.Text = "";
            
            try
            {
                con.Open();
                string sql = "SELECT cResponsable,cTelefono FROM proveedor where iidproveedor=" + piProveedor.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtcResponsableTaller.Text = reader.GetString(0);
                    txtcTelefonoTaller.Text = reader.GetString(1);                    
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("No fue posible obtener la poliza de seguro");
            }
            finally
            {
                con.Close();
            }
        } // dameProveedor

        private void dameArea(string piDepto, string piArea)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

               txtiDireccion.Text = "";
               txtcDireccion.Text = "";
            txtcDepartamento.Text = "";
                    txtcArea.Text = "";
                  int viDireccion = 0;

            try
            {
                con.Open();
                string sql = "SELECT cNombre,ipadre FROM niveleducativo where inodo=" + piDepto.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtcDepartamento.Text = reader.GetString(0);
                    txtiDireccion.Text = reader.GetString(1);
                    viDireccion = reader.GetInt32(1);
                }
                con.Close();

                if (viDireccion != 0)
                {
                    con.Open();
                    string sqlDir = "SELECT cNombre,inodo FROM niveleducativo where inodo=" + viDireccion.ToString() + ";";
                    MySqlCommand cmdDir = new MySqlCommand(sqlDir, con);
                    MySqlDataReader readerDir = cmdDir.ExecuteReader();
                    if (readerDir.Read())
                    {
                        txtcDireccion.Text = readerDir.GetString(0);                        
                    }
                    con.Close();
                } // viDireccion != 0

                con.Open();
                string sqlArea = "SELECT cNombre,cInicial FROM areaservicio where iidareaservicio=" + piArea.ToString() + ";";
                MySqlCommand cmdArea = new MySqlCommand(sqlArea, con);
                MySqlDataReader readerArea = cmdArea.ExecuteReader();
                if (readerArea.Read())
                {
                    txtcArea.Text = readerArea.GetString(0);
                }
                con.Close();

            }
            catch (Exception e)
            {
                //MessageBox.Show("No fue posible obtener la poliza de seguro");
            }
            finally
            {
                con.Close();
            }
        } // dameArea
    }
}
