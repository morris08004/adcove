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
    public partial class frmPlaca : Form
    {
        private Conexion mConexion;
        private string pcAccion = "";

        public frmPlaca()
        {
            InitializeComponent();
            estadoObjeto(false);
            mConexion = new Conexion();
            poblarBrowse(dgvPlaca);
        }

        private void dgvResguardo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPlaca_Load(object sender, EventArgs e)
        {

        }

        private void estadoObjeto(bool plEstado)
        {
            if (plEstado == true)
            {
                 txtcPlaca.Enabled = true;
                 dtpInicia.Enabled = true;
                dtpTermina.Enabled = true;
                 chkActual.Enabled = true;
                
                    btnNuevo.Enabled = false;
                   btnEditar.Enabled = false;
                   btnBorrar.Enabled = false;
                  btnGuardar.Enabled = true;
                 btnCancelar.Enabled = true;
                   btnBuscar.Enabled = false;
                 btnImprimir.Enabled = false;
                dgvPlaca.Enabled = false;
            }
            else
            {
                 txtcPlaca.Enabled = false;
                 dtpInicia.Enabled = false;
                dtpTermina.Enabled = false;
                 chkActual.Enabled = false;
                
                    btnNuevo.Enabled = true;
                   btnEditar.Enabled = true;
                   btnBorrar.Enabled = true;
                  btnGuardar.Enabled = false;
                 btnCancelar.Enabled = false;
                   btnBuscar.Enabled = true;
                 btnImprimir.Enabled = true;
                dgvPlaca.Enabled = true;
            }
        } // EstadoObjeto

        private void limpiaCampo()
        {
               txtcPlaca.Text = "";
              dtpInicia.Value = DateTime.Now;
             dtpTermina.Value = DateTime.Now;
            chkActual.Checked = false;            
        }

        private void poblarBrowse(DataGridView grid)
        {
            // MySqlCommand cm = new MySqlCommand("SELECT * FROM vehiculo;", con);
            string cm = "SELECT * FROM Placa";

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
            viDevuelve = guardarObjeto(txtcPlaca.Text, dtpInicia.Value, dtpTermina.Value, chkActual.Checked);

            //MessageBox.Show("Folio:->" + viDevuelve.ToString());

            if (viDevuelve != 0)
            {
                switch (pcAccion)
                {
                    case "N":
                        //txtiResguardo.Text = viDevuelve.ToString();
                        MessageBox.Show("Poliza de seguro registrado exitosamente");

                        break;
                    case "E":
                        MessageBox.Show("Cambios a la Poliza registrados exitosamente");
                        break;
                }
                pcAccion = "";
                poblarBrowse(dgvPlaca);
            }  // viDevuelve!=0
            else
            {
                MessageBox.Show("Adicion/cambio del registro no efectuado");
            }
        }

        private int guardarObjeto(string pcPlaca, DateTime pdtInicia, DateTime pdtTermina, Boolean plActual)
        {
            int codigoRegistroInsertado = 0;
                     string sqlEjecutar = "";
                           int viActual = 0;

            if (plActual == true) { viActual = 1; }

            switch (pcAccion)
            {
                case "N":
                    sqlEjecutar = "insert into placa (cFolioPlaca, dtInicia, dtTermina, lActual)"
                                + " VALUES (@Placa, @Inicia, @Termina, @Actual )";
                    break;
                case "E":
                    sqlEjecutar = "UPDATE placa SET dtInicia=@Inicia,dtTermina=@Termina,lActual=@Actual WHERE cFolioPlaca=@Placa";
                    break;
            }
            //Para SQL Server cambiar SELECT LAST_INSERT_ID() por SCOPE_IDENTITY()
            try
            {
                MySqlCommand comandoSQL = new MySqlCommand();

                 string vdtInicia = $"{pdtInicia:yyyy-MM-dd HH:hh:dd}";
                string vdtTermina = $"{pdtTermina:yyyy-MM-dd HH:mm:dd}";

                 comandoSQL.Connection = mConexion.getConexion();
                comandoSQL.CommandText = sqlEjecutar;

                switch (pcAccion)
                {
                    case "N":
                        //comandoSQL.Parameters.Add("@Vehiculo", MySqlDbType.Int32).Value = 0;
                        comandoSQL.Parameters.Add("@Placa", MySqlDbType.String).Value = pcPlaca;
                        comandoSQL.Parameters.Add("@Inicia", MySqlDbType.DateTime).Value = Convert.ToDateTime(vdtInicia);
                        comandoSQL.Parameters.Add("@Termina", MySqlDbType.DateTime).Value = Convert.ToDateTime(vdtTermina);
                        comandoSQL.Parameters.Add("@Actual", MySqlDbType.Int32).Value = plActual;

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                        //comandoSQL.CommandText = " SELECT LAST_INSERT_ID()";
                        //codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                        codigoRegistroInsertado = 1;
                        return codigoRegistroInsertado;
                        
                    case "E":
                        comandoSQL.Parameters.Add("@Inicia", MySqlDbType.DateTime).Value = Convert.ToDateTime(vdtInicia);
                        comandoSQL.Parameters.Add("@Termina", MySqlDbType.DateTime).Value = Convert.ToDecimal(vdtTermina);
                        comandoSQL.Parameters.Add("@Actual", MySqlDbType.Int32).Value = plActual;
                        comandoSQL.Parameters.Add("@Placa", MySqlDbType.String).Value = pcPlaca;

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteNonQuery());
                        break;
                }
                codigoRegistroInsertado = 1;
                return codigoRegistroInsertado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Añadir/Modificar registro [" + pcPlaca.ToString() + "]: " + ex.Message);
                return codigoRegistroInsertado; //0 si ha habido algún error
            }
            finally
            {
                //conexionBD.Close();
            }
        } //guardarObjeto

        private void dgvPlaca_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            txtcPlaca.Text = row.Cells[0].Value.ToString();
            dtpInicia.Text = row.Cells[1].Value.ToString();
            dtpTermina.Text = row.Cells[2].Value.ToString();
            
            if (row.Cells[3].Value.ToString() != "")
            {
                if (row.Cells[3].Value.ToString() == "0") { chkActual.Checked = false; } else { chkActual.Checked = true; }
            }            
        }
    }
}
