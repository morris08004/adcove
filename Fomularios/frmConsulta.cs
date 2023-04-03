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
    
    public partial class frmConsulta : Form
    {
        private Conexion mConexion;
        
        string cm = "";

        //variable publicas
        public string vcId { get; set; }
        public string vcValor { get; set; }
        public frmConsulta(int piConsulta, int piValor)
        {
            int viConsulta = piConsulta;  // la tabla que va a cargar
               int viValor = piValor; // aplicar solo para el nivel educativo

            InitializeComponent();
            mConexion = new Conexion();
            poblarBrowse(viConsulta, viValor);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
               vcId = "";
            vcValor = "";
            this.Close();
        }

        private void dgvConsulta_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

                txtId.Text = row.Cells[0].Value.ToString();
            txtcValor.Text = row.Cells[1].Value.ToString();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
               vcId = txtId.Text;
            vcValor = txtcValor.Text;
            
            this.Close();
        }

        private void poblarBrowse(int piOpcion, int piValor)
        {
            switch (piOpcion)
            {
                case 0:  // Direccion ó Departamento
                    cm = "SELECT iNodo, cNombre FROM NivelEducativo WHERE iPadre = " + piValor.ToString();
                    break;
                case 1:  // Area de servicio
                    cm = "SELECT iIdAreaServicio, cNombre FROM AreaServicio ";
                    break;
                case 2:
                    cm = "SELECT iIdConductor, cNombre FROM Conductor ";
                    break;
                case 3:
                    cm = "SELECT cFolioPlaca, iModelo, cColor, iIdVehiculo, cResponsable FROM vehiculo WHERE iIdEstatus = 1 "; ;
                    break;
            }
            
            if (mConexion.getConexion() != null)
            {
                try
                {                    
                    MySqlCommand command = new MySqlCommand(cm, mConexion.getConexion());
                    //command.Connection = mConexion.getConexion();
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvConsulta.DataSource = dt;                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        } // poblarBrowse
    }
}
