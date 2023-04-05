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
        private string vcUsuario;

        public frmBitacora( string pcUsuario)
        {
            InitializeComponent();

            vcUsuario = pcUsuario;

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            //var row = (sender as DataGridView).CurrentRow;
            int viFolio = 0;
            frmMttoBitacora frm = new frmMttoBitacora("N", viFolio, vcUsuario);
            frm.ShowDialog();

            poblarBrowse(dgvBitacora);

            
        } // btnNuevo

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            //var row = (sender as DataGridView).CurrentRow;
            int viFolio = 0;

            if (!string.IsNullOrEmpty(dgvBitacora.CurrentRow.Cells[0].Value.ToString()))
            {
                viFolio = Convert.ToInt32(dgvBitacora.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                viFolio = 0;
            }


            frmMttoBitacora frm = new frmMttoBitacora("E", viFolio, vcUsuario);
            frm.ShowDialog();

            poblarBrowse(dgvBitacora);

            
        } // btnEditar

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            //var row = (sender as DataGridView).CurrentRow;
            int viFolio = 0;

            if (!string.IsNullOrEmpty(dgvBitacora.CurrentRow.Cells[0].Value.ToString()))
            {
                viFolio = Convert.ToInt32(dgvBitacora.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                viFolio = 0;
            }

            frmMttoVehicular frm = new frmMttoVehicular("B", viFolio, vcUsuario);
            frm.ShowDialog();

        } // btnBorrar
    }
}
