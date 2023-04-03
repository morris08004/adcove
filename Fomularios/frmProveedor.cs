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
    public partial class frmProveedor : Form
    {
        private Conexion mConexion;
        private string pcAccion = "";

        public frmProveedor()
        {
            InitializeComponent();
            estadoObjeto(false);
            mConexion = new Conexion();
            poblarBrowse(dgvProveedor);
            //cargaCombo();
        }

        private void estadoObjeto(bool plEstado)
        {
            if (plEstado == true)
            {
                txtiProveedor.Enabled = false;
                chkTaller.Enabled = true;
                chkArrendador.Enabled = true;
                txtiSIDAF.Enabled = true;
                txtcNombre.Enabled = true;
                txtcUbicacion.Enabled = true;
                txtcTelefono.Enabled = true;
                txtcResponsable.Enabled = true;

                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
                btnBorrar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;
                dgvProveedor.Enabled = false;
            }
            else
            {
                txtiProveedor.Enabled = false;
                chkTaller.Enabled = false;
                chkArrendador.Enabled = false;
                txtiSIDAF.Enabled = false;
                txtcNombre.Enabled = false;
                txtcUbicacion.Enabled = false;
                txtcTelefono.Enabled = false;
                txtcResponsable.Enabled = false;

                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                dgvProveedor.Enabled = true;
            }
        } // EstadoObjeto

        private void limpiaCampo()
        {
            txtiProveedor.Text = "0";
            chkTaller.Checked = false;
            chkArrendador.Checked = false;
            txtiSIDAF.Text = "0";
            txtcNombre.Text = "";
            txtcUbicacion.Text = "";
            txtcTelefono.Text = "";
            txtcResponsable.Text = "";
            
        }

        private void poblarBrowse(DataGridView grid)
        {
            // MySqlCommand cm = new MySqlCommand("SELECT * FROM vehiculo;", con);
            string cm = "SELECT * FROM proveedor";

            //MySqlDataAdapter da = null;

            if (mConexion.getConexion() != null)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(cm, mConexion.getConexion());
                    //command.Connection = mConexion.getConexion();
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
        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiaCampo();
            estadoObjeto(true);
            pcAccion = "N";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estadoObjeto(true);
            pcAccion = "E";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            estadoObjeto(true);
            pcAccion = "B";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int viDevuelve = 0;

            estadoObjeto(false);
            viDevuelve = guardarObjeto(txtiProveedor.Text, chkTaller.Checked, chkArrendador.Checked, txtiSIDAF.Text, txtcNombre.Text,
                                       txtcUbicacion.Text, txtcTelefono.Text, txtcResponsable.Text);

            //MessageBox.Show("Folio:->" + viDevuelve.ToString());

            if (viDevuelve != 0)
            {
                switch (pcAccion)
                {
                    case "N":
                        txtiProveedor.Text = viDevuelve.ToString();
                        MessageBox.Show("Proveedor registrado exitosamente");

                        break;
                    case "E":
                        MessageBox.Show("Cambios al proveedor registrados exitosamente");
                        break;
                }
                pcAccion = "";
                poblarBrowse(dgvProveedor);
            }  // viDevuelve!=0
            else
            {
                MessageBox.Show("Adicion/cambio del registro no efectuado");
            }
        } // btnGuardar_Click

        private int guardarObjeto(string piProveedor, Boolean plTaller, Boolean plArrenda, string piSIDAF, string pcNombre, string pcUbicacion,string pcTelefono, string pcResponsable)
        {
            int codigoRegistroInsertado = 0;
                     string sqlEjecutar = "";

            switch (pcAccion)
            {
                case "N":

                    sqlEjecutar = "insert into proveedor (cNombre, iidsidaf, cubicacion,ctelefono,italler,iarrendador,cResponsable)"
                                + " VALUES (@Nombre, @sidaf, @ubica,@telefono,@taller,@arrenda,@responsable)";

                    break;
                case "E":

                    sqlEjecutar = "UPDATE proveedor SET cnombre=@Nombre,iidsidaf=@sidaf,cubicacion=@ubica,ctelefono=@telefono,italler=@taller,iarrendador=@arrenda,cResponsable=@responsable WHERE iidproveedor=@proveedor";
                    break;
            }

            //Para SQL Server cambiar SELECT LAST_INSERT_ID() por SCOPE_IDENTITY()
            try
            {
                MySqlCommand comandoSQL = new MySqlCommand();

                //string vdtInicia = $"{pdtInicia:yyyy-MM-dd HH:hh:dd}";
                //int viHoraInicia = convierteHora(pcHoraInicia);
                int vitaller = 0, viarrenda = 0;

                if (plTaller == true) { vitaller = 1; } else { vitaller = 0; }
                if (plArrenda == true) { viarrenda = 1; } else { viarrenda = 0; }

                comandoSQL.Connection = mConexion.getConexion();
                comandoSQL.CommandText = sqlEjecutar;

                switch (pcAccion)
                {   
                    case "N":
                        //comandoSQL.Parameters.Add("@Vehiculo", MySqlDbType.Int32).Value = 0;
                        comandoSQL.Parameters.Add("@Nombre", MySqlDbType.String).Value = pcNombre;
                        comandoSQL.Parameters.Add("@sidaf", MySqlDbType.Int32).Value = piSIDAF;
                        comandoSQL.Parameters.Add("@ubica", MySqlDbType.String).Value = pcUbicacion;
                        comandoSQL.Parameters.Add("@telefono", MySqlDbType.String).Value = pcTelefono;
                        comandoSQL.Parameters.Add("@taller", MySqlDbType.Int32).Value = vitaller;
                        comandoSQL.Parameters.Add("@arrenda", MySqlDbType.Int32).Value = viarrenda;
                        comandoSQL.Parameters.Add("@responsable", MySqlDbType.String).Value = pcResponsable;

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                        comandoSQL.CommandText = " SELECT LAST_INSERT_ID()";
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());

                        return codigoRegistroInsertado;
                        
                    case "E":
                        comandoSQL.Parameters.Add("@Nombre", MySqlDbType.String).Value = pcNombre;
                        comandoSQL.Parameters.Add("@sidaf", MySqlDbType.Int32).Value = piSIDAF;
                        comandoSQL.Parameters.Add("@ubica", MySqlDbType.String).Value = pcUbicacion;
                        comandoSQL.Parameters.Add("@telefono", MySqlDbType.String).Value = pcTelefono;
                        comandoSQL.Parameters.Add("@taller", MySqlDbType.Int32).Value = vitaller;
                        comandoSQL.Parameters.Add("@arrenda", MySqlDbType.Int32).Value = viarrenda;
                        comandoSQL.Parameters.Add("@responsable", MySqlDbType.String).Value = pcResponsable;
                        comandoSQL.Parameters.Add("@proveedor", MySqlDbType.Int32).Value = piProveedor;

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteNonQuery());
                        break;
                }

                return codigoRegistroInsertado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Añadir/Modificar registro [" + piProveedor.ToString() + "]: " + ex.Message);
                return codigoRegistroInsertado; //0 si ha habido algún error
            }
            finally
            {
                //conexionBD.Close();
            }
        } //guardarObjeto

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoObjeto(false);
            pcAccion = "";
        }

        private void dgvProveedor_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            //int viInicia = Convert.ToInt32(row.Cells[10].Value.ToString());
            //string vcInicia = convertirSegundosHorasMinutos(viInicia);

            int viTaller = Convert.ToInt32(row.Cells[5].Value.ToString());
            int viArrenda = Convert.ToInt32(row.Cells[6].Value.ToString());

            if (viTaller == 1) { chkTaller.Checked = true; } else { chkTaller.Checked = false; }
            if (viArrenda == 1) { chkArrendador.Checked = true; } else { chkArrendador.Checked = false; }
            txtiProveedor.Text = row.Cells[0].Value.ToString();
            txtcNombre.Text = row.Cells[1].Value.ToString();
            txtiSIDAF.Text = row.Cells[2].Value.ToString();
            txtcUbicacion.Text = row.Cells[3].Value.ToString();
            txtcTelefono.Text = row.Cells[4].Value.ToString();
            txtcResponsable.Text = row.Cells[10].Value.ToString();

        }
    }
}
