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
    public partial class frmNivelEducativo : Form
    {
        private Conexion mConexion;
        private string pcAccion = "";

        public frmNivelEducativo()
        {
            InitializeComponent();
            estadoObjeto(false);
            mConexion = new Conexion();
            poblarBrowse(dgvNivel);
            cargaCombo();
        }

        private void estadoObjeto(bool plEstado)
        {
            if (plEstado == true)
            {
                  txtiNodo.Enabled = false;
                  txtiPadre.Enabled = true;
                txtcNombre.Enabled = true;
                txtcPadre.Enabled = false;
                
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
                btnBorrar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;
                dgvNivel.Enabled = false;
            }
            else
            {
                  txtiNodo.Enabled = false;
                  txtiPadre.Enabled = false;
                txtcNombre.Enabled = false;
                txtcPadre.Enabled = false;

                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                dgvNivel.Enabled = true;
            }
        } // EstadoObjeto

        private void limpiaCampo()
        {
            txtiNodo.Text = "0";
            txtiPadre.Text = "0";
            txtcNombre.Text = "";
            txtcPadre.Text = "";
        }

        private void poblarBrowse(DataGridView grid)
        {
            // MySqlCommand cm = new MySqlCommand("SELECT * FROM vehiculo;", con);
            string cm = "SELECT * FROM niveleducativo";

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

        private void cargaCombo()
        {
            string sql = "";
            /* -----------------------------
            sql = "SELECT * FROM NivelEducativo WHERE iPadre = 0 ;";
            MySqlCommand commandTC = new MySqlCommand(sql, mConexion.getConexion());
            MySqlDataAdapter dTC = new MySqlDataAdapter(commandTC);
            DataTable dtTC = new DataTable();
            dTC.Fill(dtTC);
            cmbPadre.DisplayMember = "cNombre";
              cmbPadre.ValueMember = "iNodo";
               cmbPadre.DataSource = dtTC;*/
        }

        private void frmNivelEducativo_Load(object sender, EventArgs e)
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
            viDevuelve = guardarObjeto(txtiNodo.Text, txtiPadre.Text, txtcNombre.Text);

            MessageBox.Show("Folio:->" + viDevuelve.ToString());

            if (viDevuelve != 0)
            {
                switch (pcAccion)
                {
                    case "N":
                        txtiNodo.Text = viDevuelve.ToString();
                        MessageBox.Show("Conductor registrado exitosamente");

                        break;
                    case "E":
                        MessageBox.Show("Cambios al Conductor registrados exitosamente");
                        break;
                }
                pcAccion = "";
                poblarBrowse(dgvNivel);
            }  // viDevuelve!=0
            else
            {
                MessageBox.Show("Adicion/cambio del registro no efectuado");
            }
        } //btnGuardar_click

        private int guardarObjeto(string pinodo, string pipadre, string pcNombre)
        {
            int codigoRegistroInsertado = 0;
            string sqlEjecutar = "";

            switch (pcAccion)
            {
                case "N":

                    sqlEjecutar = "insert into niveleducativo (cNombre, ipadre)"
                                + " VALUES (@Nombre, @padre )";

                    break;
                case "E":

                    sqlEjecutar = "UPDATE nivleducativo SET cnombre=@Nombre,ipadre=@padre WHERE inodo=@nodo";
                    break;
            }

            //Para SQL Server cambiar SELECT LAST_INSERT_ID() por SCOPE_IDENTITY()
            try
            {
                MySqlCommand comandoSQL = new MySqlCommand();

                //string vdtInicia = $"{pdtInicia:yyyy-MM-dd HH:hh:dd}";
                //int viHoraInicia = convierteHora(pcHoraInicia);
                
                comandoSQL.Connection = mConexion.getConexion();
                comandoSQL.CommandText = sqlEjecutar;

                switch (pcAccion)
                {
                    case "N":
                        //comandoSQL.Parameters.Add("@Vehiculo", MySqlDbType.Int32).Value = 0;
                        comandoSQL.Parameters.Add("@Nombre", MySqlDbType.String).Value = pcNombre;
                        comandoSQL.Parameters.Add("@padre", MySqlDbType.Int32).Value = Convert.ToInt32(pipadre);
                        
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                        comandoSQL.CommandText = " SELECT LAST_INSERT_ID()";
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());

                        return codigoRegistroInsertado;
                        break;
                    case "E":
                        comandoSQL.Parameters.Add("@Nombre", MySqlDbType.String).Value = pcNombre;
                        comandoSQL.Parameters.Add("@padre", MySqlDbType.Int32).Value = Convert.ToInt32(pipadre);
                        comandoSQL.Parameters.Add("@nodo", MySqlDbType.Int32).Value = Convert.ToInt32(pinodo);

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteNonQuery());
                        break;
                }

                return codigoRegistroInsertado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Añadir/Modificar registro [" + pinodo.ToString() + "]: " + ex.Message);
                return codigoRegistroInsertado; //0 si ha habido algún error
            }
            finally
            {
                //conexionBD.Close();
            }
        } //guardarObjeto

        private void dgvNivel_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            //int viInicia = Convert.ToInt32(row.Cells[10].Value.ToString());
            //int viTermina = Convert.ToInt32(row.Cells[11].Value.ToString());

            //string vcInicia = convertirSegundosHorasMinutos(viInicia);
            //string vcTermina = convertirSegundosHorasMinutos(viTermina);

              txtiNodo.Text = row.Cells[0].Value.ToString();
            txtcNombre.Text = row.Cells[2].Value.ToString();
             txtiPadre.Text = row.Cells[1].Value.ToString();
             txtcPadre.Text = damePadre(txtiPadre.Text);            
        }

        private string damePadre(string piPadre)
        {
            string vcPadre = "";
            MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

            con.Open();
            string sql = "SELECT * FROM NivelEducativo where iNodo=" + piPadre.ToString() + ";";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@producto", piPoliza);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //txtcPadre.Text = reader.GetString(2);
                vcPadre = reader.GetString(2);
                // viPadre = Convert.ToInt32(reader.GetString(1));

            }
            con.Close();
            return vcPadre;
        }

        private void txtiNodo_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine whethedr the keystroke is a number from the top of the keyboard.
            if (e.KeyCode == Keys.F3)  // || e.KeyCode > Keys.D9
            {
                e.Handled = true;
                frmConsulta frm = new frmConsulta(0, 0);
                frm.ShowDialog();

                //variable publicas
                string vcIdLocal = frm.vcId;
                string vcNombre = frm.vcValor;

                if (vcIdLocal != "")
                {
                    txtiPadre.Text = vcIdLocal;
                    txtcPadre.Text = vcNombre;
                }
            }
        }

        private void txtiPadre_KeyDown(object sender, KeyEventArgs e)
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
                    txtiPadre.Text = vcIdLocal;
                    txtcPadre.Text = vcNombre;
                }
            }
        }

        private void txtiPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
