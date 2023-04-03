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
    public partial class frmResguardo : Form
    {
        private Conexion mConexion;
        private string pcAccion = "";
                
        public frmResguardo()
        {
            InitializeComponent();
            estadoObjeto(false);
            mConexion = new Conexion();
            poblarBrowse(dgvResguardo);

        }

        private void estadoObjeto(bool plEstado)
        {
            if (plEstado == true)
            {
                   txtiResguardo.Enabled = false;
                   txtiDireccion.Enabled = true;
                txtiDepartamento.Enabled = true;
                        txtiArea.Enabled = true;
                 txtcResponsable.Enabled = true;

                   btnNuevo.Enabled = false;
                  btnEditar.Enabled = false;
                  btnBorrar.Enabled = false;
                 btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                  btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;
               dgvResguardo.Enabled = false;
            }
            else
            {
                   txtiResguardo.Enabled = false;
                   txtiDireccion.Enabled = false;
                txtiDepartamento.Enabled = false;
                        txtiArea.Enabled = false;
                 txtcResponsable.Enabled = false;

                    btnNuevo.Enabled = true;
                   btnEditar.Enabled = true;
                   btnBorrar.Enabled = true;
                  btnGuardar.Enabled = false;
                 btnCancelar.Enabled = false;
                   btnBuscar.Enabled = true;
                 btnImprimir.Enabled = true;
                dgvResguardo.Enabled = true;
            }
        } // EstadoObjeto

        private void limpiaCampo()
        {
              txtiResguardo.Text = "0";
            txtcResponsable.Text = "";
            txtiDireccion.Text = "0";
            txtcDireccion.Text = "";
            txtiDepartamento.Text = "0";
            txtcDepartamento.Text = "";
            txtiArea.Text = "0";
            txtcArea.Text = "";
        }

        private void poblarBrowse(DataGridView grid)
        {
            // MySqlCommand cm = new MySqlCommand("SELECT * FROM vehiculo;", con);
            string cm = "SELECT * FROM Resguardo";

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

        private void dgvResguardo_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

               txtiResguardo.Text = row.Cells[0].Value.ToString();
            txtiDepartamento.Text = row.Cells[1].Value.ToString();
                    txtiArea.Text = row.Cells[2].Value.ToString();
             txtcResponsable.Text = row.Cells[3].Value.ToString();

            if (row.Cells[1].Value.ToString() != "")
            {
                poblaCT(row.Cells[1].Value.ToString());
            }

            if (row.Cells[2].Value.ToString() != "")
            {
                poblaArea(row.Cells[2].Value.ToString());
            }

        }  // dgvResguardo

        private void poblaCT (string piNodo)
        {
               txtcDireccion.Text = "";
            txtcDepartamento.Text = "";
            int viPadre = 0;

            if (Convert.ToInt32(piNodo) != 0)
            {
                MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

                con.Open();
                string sql = "SELECT * FROM NivelEducativo where iNodo=" + piNodo.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@producto", piPoliza);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtcDepartamento.Text = reader.GetString(2);
                                  viPadre = Convert.ToInt32( reader.GetString(1)) ;                   
                   
                }
                con.Close();

                if (viPadre != 0)
                {
                    MySqlConnection conp = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

                    conp.Open();
                    string sqlp = "SELECT * FROM NivelEducativo where iNodo=" + viPadre.ToString() + ";";
                    MySqlCommand cmdp = new MySqlCommand(sqlp, conp);
                    MySqlDataReader readerp = cmdp.ExecuteReader();
                    if (readerp.Read())
                    {
                        txtcDireccion.Text = readerp.GetString(2);
                        txtiDireccion.Text = readerp.GetString(0).ToString();

                    }
                    con.Close();
                }
            }
        } //poblaCT

        private void poblaArea(string piArea)
        {
            txtcArea.Text = "";
            
            if (Convert.ToInt32(piArea) != 0)
            {
                MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

                con.Open();
                string sql = "SELECT * FROM AreaServicio where iIdAreaServicio=" + piArea.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@producto", piPoliza);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtcArea.Text = reader.GetString(1);
                }
                con.Close();                
            }
        } //poblaArea

        private void txtiDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {            
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.
            
            if (e.KeyChar == (char)Keys.F3)
            {                
                e.Handled = true;
                frmConsulta frm = new frmConsulta(0,1);
                frm.Show();

                //variable publicas
                string vcIdLocal = frm.vcId;
                string vcNombre = frm.vcValor;

                if (vcIdLocal != "")
                {
                    txtiDireccion.Text = vcIdLocal;
                    txtcDireccion.Text = vcNombre;
                }
            } // keychar == F2
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
            viDevuelve = guardarObjeto(txtiResguardo.Text, txtiDireccion.Text, txtiDepartamento.Text, txtiArea.Text, txtcResponsable.Text);

            MessageBox.Show("Folio:->" + viDevuelve.ToString());

            if (viDevuelve != 0)
            {
                switch (pcAccion)
                {
                    case "N":
                        txtiResguardo.Text = viDevuelve.ToString();
                        MessageBox.Show("Poliza de seguro registrado exitosamente");

                        break;
                    case "E":
                        MessageBox.Show("Cambios a la Poliza registrados exitosamente");
                        break;
                }
                pcAccion = "";
                poblarBrowse(dgvResguardo);
            }  // viDevuelve!=0
            else
            {
                MessageBox.Show("Adicion/cambio del registro no efectuado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoObjeto(false);
            pcAccion = "";
        }

        private int guardarObjeto(string piResguardo, string piDireccion, string piDepartamento, string piArea, string pcResponsable)
        {
            int codigoRegistroInsertado = 0;
            string sqlEjecutar = "";

            switch (pcAccion)
            {
                case "N":

                    sqlEjecutar = "insert into resguardo (iNodo, iAreaServicio, cResponsable)"
                                + " VALUES (@Nodo, @Area, @Responsable )";

                    break;
                case "E":

                    sqlEjecutar = "UPDATE resguardo SET iNodo=@Nodo,iAreaServicio=@Area,cResponsable=@Responsable WHERE iIdResguardo=@Resguardo";
                    break;
            }

            //Para SQL Server cambiar SELECT LAST_INSERT_ID() por SCOPE_IDENTITY()
            try
            {
                MySqlCommand comandoSQL = new MySqlCommand();

                //string vdtVence = $"{pdaVence:yyyy-MM-dd HH:hh:dd}";
                //string vdtPago = $"{pdaPago:yyyy-MM-dd HH:mm:dd}";

                comandoSQL.Connection = mConexion.getConexion();
                comandoSQL.CommandText = sqlEjecutar;

                switch (pcAccion)
                {
                    case "N":
                        //comandoSQL.Parameters.Add("@Vehiculo", MySqlDbType.Int32).Value = 0;
                        comandoSQL.Parameters.Add("@Nodo", MySqlDbType.Int32).Value = Convert.ToInt32(piDepartamento);
                        comandoSQL.Parameters.Add("@Area", MySqlDbType.Int32).Value = Convert.ToInt32(piArea);
                        comandoSQL.Parameters.Add("@Responsable", MySqlDbType.String).Value = pcResponsable;
                        
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                         comandoSQL.CommandText = " SELECT LAST_INSERT_ID()";
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());

                        return codigoRegistroInsertado;
                        break;
                    case "E":
                        comandoSQL.Parameters.Add("@Nodo", MySqlDbType.Int32).Value = Convert.ToInt32(piDepartamento);
                        comandoSQL.Parameters.Add("@Area", MySqlDbType.Int32).Value = Convert.ToInt32(piArea);
                        comandoSQL.Parameters.Add("@Responsable", MySqlDbType.String).Value = pcResponsable;
                        comandoSQL.Parameters.Add("@Resguardo", MySqlDbType.Int32).Value = Convert.ToInt32(piResguardo);

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteNonQuery());
                        break;
                }

                return codigoRegistroInsertado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Añadir/Modificar registro [" + piResguardo.ToString() + "]: " + ex.Message);
                return codigoRegistroInsertado; //0 si ha habido algún error
            }
            finally
            {
                //conexionBD.Close();
            }
        } //guardarObjeto

        private void txtiDireccion_KeyDown(object sender, KeyEventArgs e)
        {            
            // Determine whethedr the keystroke is a number from the top of the keyboard.
            if (e.KeyCode == Keys.F3)  // || e.KeyCode > Keys.D9
            {                
                e.Handled = true;
                frmConsulta frm = new frmConsulta(0,1);
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
            
        } // txtiDireccion_KeyDown

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

        private void txtcArea_TextChanged(object sender, EventArgs e)
        {

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

                if (vcIdLocal != "")
                {
                    txtiArea.Text = vcIdLocal;
                    txtcArea.Text = vcNombre;
                }
            }
        }
    }
}
