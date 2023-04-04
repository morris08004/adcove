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
    public partial class frmBitacora : Form
    {
        private Conexion mConexion;
        private string pcAccion = "";

        public frmBitacora( string pcUsuario)
        {
            InitializeComponent();
            estadoObjeto(false);
            mConexion = new Conexion();
            poblarBrowse(dgvBitacora);

        }  // public frmBitacora()

        private void estadoObjeto(bool plEstado)
        {
            if (plEstado == true)
            {
                //txtiResguardo.Enabled = false;
                
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
                btnBorrar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;
                dgvBitacora.Enabled = false;
                dgvBitacoraDetalle.Enabled = false;

            }
            else
            {
                //txtiResguardo.Enabled = false;
                
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                dgvBitacora.Enabled = true;
                dgvBitacora.Enabled = true;

            }
        } // EstadoObjeto

        private void poblarBrowse(DataGridView grid)
        {            
            string cm = "SELECT * FROM bitacora";

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

    }
}
