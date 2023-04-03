using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace wCWdrmApp
{
    public partial class frmPoliza : Form
    {
        private Conexion mConexion;
        private string pcAccion = "";

        public frmPoliza()
        {
            InitializeComponent();
            estadoObjeto(false);
            mConexion = new Conexion();
            poblarBrowse(dgvPoliza);
        }

        private void estadoObjeto(bool plEstado)
        {
            if (plEstado == true)
            {
                txtIdPoliza.Enabled = false;
                  txtcFolio.Enabled = true;
                 txtiInciso.Enabled = true;
                   dtpVence.Enabled = true;
                    dtpPago.Enabled = true;

                   btnNuevo.Enabled = false;   
                  btnEditar.Enabled = false;
                  btnBorrar.Enabled = false;
                 btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                  btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;
                  dgvPoliza.Enabled = false;
            }
            else
            {
                txtIdPoliza.Enabled = false;
                  txtcFolio.Enabled = false;
                 txtiInciso.Enabled = false;
                   dtpVence.Enabled = false;
                    dtpPago.Enabled = false;

                   btnNuevo.Enabled = true;
                  btnEditar.Enabled = true;
                  btnBorrar.Enabled = true;
                 btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                  btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                  dgvPoliza.Enabled = true;
            }
        } // EstadoObjeto
        private void limpiaCampo ()
        {
            txtIdPoliza.Text = "0";
              txtcFolio.Text = "";
             txtiInciso.Text = "0";
              dtpVence.Value = DateTime.Now;
               dtpPago.Value = DateTime.Now;
        }

        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
            limpiaCampo();
            estadoObjeto(true);
            pcAccion = "N";

        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            estadoObjeto(true);
            pcAccion = "E";
        }

        private void btnBorrar_Click(object sender, System.EventArgs e)
        {
            estadoObjeto(true);
            pcAccion = "B";
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            int viDevuelve = 0;

            estadoObjeto(false);
            viDevuelve = guardarObjeto(txtIdPoliza.Text, txtcFolio.Text, txtiInciso.Text, dtpVence.Value, dtpPago.Value);

            MessageBox.Show("Folio:->" + viDevuelve.ToString());

            if (viDevuelve != 0)
            {
                switch (pcAccion)
                {
                    case "N":
                        txtIdPoliza.Text = viDevuelve.ToString();
                        MessageBox.Show("Poliza de seguro registrado exitosamente");

                        break;
                    case "E":
                        MessageBox.Show("Cambios a la Poliza registrados exitosamente");
                        break;
                }
                pcAccion = "";
                poblarBrowse(dgvPoliza);
            }  // viDevuelve!=0
            else
            {
                MessageBox.Show("Adicion/cambio del registro no efectuado");
            }

        } // btnGuardar_click

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            estadoObjeto(false);
            pcAccion = "";
        }
        private void poblarBrowse(DataGridView grid)
        {
            // MySqlCommand cm = new MySqlCommand("SELECT * FROM vehiculo;", con);
            string cm = "SELECT * FROM polizaseguro";

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

        private void dgvPoliza_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;
           
            txtIdPoliza.Text = row.Cells[0].Value.ToString();
              txtcFolio.Text = row.Cells[1].Value.ToString();
             txtiInciso.Text = row.Cells[2].Value.ToString();
             
            if (EsFecha(row.Cells[3].Value.ToString()) == true)
            {
                dtpVence.Value = Convert.ToDateTime(row.Cells[3].Value);
            }
            if (EsFecha(row.Cells[4].Value.ToString()) == true)
            {
                dtpPago.Value = Convert.ToDateTime(row.Cells[4].Value);
            }

        }

        private int guardarObjeto(string piPoliza, string pcFolio, string piInciso, DateTime pdaVence, DateTime pdaPago)
        {
            int codigoRegistroInsertado = 0;
            string sqlEjecutar = "";

            switch (pcAccion)
            {
                case "N":
                    
                    sqlEjecutar = "insert into polizaseguro (cFolio, iInciso, davencimiento, daPago,daRegistro)"
                                + " VALUES (@Folio, @Inciso, @Vence, @Pago,@daRegistro )";
                    
                    break;
                case "E":

                    sqlEjecutar = "UPDATE polizaseguro SET cFolio=@Folio,iInciso=@Inciso,daVencimiento=@Vence,daPago=@Pago WHERE iIdPoliza=@Poliza";
                    break;
            }

            //Para SQL Server cambiar SELECT LAST_INSERT_ID() por SCOPE_IDENTITY()
            try
            {
                MySqlCommand comandoSQL = new MySqlCommand();

                string vdtVence = $"{pdaVence:yyyy-MM-dd HH:hh:dd}";
                string vdtPago = $"{pdaPago:yyyy-MM-dd HH:mm:dd}";

                comandoSQL.Connection = mConexion.getConexion();
                comandoSQL.CommandText = sqlEjecutar;

                switch (pcAccion)
                {
                    case "N":
                        //comandoSQL.Parameters.Add("@Vehiculo", MySqlDbType.Int32).Value = 0;
                        comandoSQL.Parameters.Add("@Folio", MySqlDbType.String).Value = pcFolio;
                        comandoSQL.Parameters.Add("@Inciso", MySqlDbType.Int32).Value = piInciso;
                        comandoSQL.Parameters.Add("@Vence", MySqlDbType.String).Value = vdtVence;
                        comandoSQL.Parameters.Add("@Pago", MySqlDbType.String).Value = vdtPago;
                        comandoSQL.Parameters.Add("@daRegistro", MySqlDbType.DateTime).Value = DateTime.Now;

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                        comandoSQL.CommandText = " SELECT LAST_INSERT_ID()";
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());

                        return codigoRegistroInsertado;
                        break;
                    case "E":
                        comandoSQL.Parameters.Add("@Folio", MySqlDbType.String).Value = pcFolio;
                        comandoSQL.Parameters.Add("@Inciso", MySqlDbType.Int32).Value = piInciso;
                        comandoSQL.Parameters.Add("@Vence", MySqlDbType.String).Value = vdtVence;
                        comandoSQL.Parameters.Add("@Pago", MySqlDbType.String).Value = vdtPago;
                        comandoSQL.Parameters.Add("@Poliza", MySqlDbType.Int32).Value = piPoliza;
                         
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteNonQuery());
                        break;
                }

                return codigoRegistroInsertado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Añadir/Modificar registro [" + piPoliza.ToString() + "]: " + ex.Message);
                //new EscribirLog("Error al añadir dispositivo [" + tipo + "]: " + ex.Message, true);
                return codigoRegistroInsertado; //0 si ha habido algún error
            }
            finally
            {
                //conexionBD.Close();
            }
        } //guardarObjeto

        public static Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void dgvPoliza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
