using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace wCWdrmApp
{
    public partial class frmLogin : Form
    {
        //variable publicas
        public string vcUsuario { get; set; }
        public string vcFechaTrabajo { get; set; }
        public string vcAreaTrabajo { get; set; }

        private Conexion mConexion;

        public frmLogin()
        {
            InitializeComponent();
            mConexion = new Conexion();
            poblaArea();
            this.TopLevel = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string connstring = "Database=controlvehicular;Data Source=localhost;User=root;Password=Leygris1$";

            MySqlConnection myConexion = new MySqlConnection(connstring);
            {
                String cUsuario = txtUsuario.Text;
                String cPassword = txtPassword.Text;

                myConexion.Open();

                string query = "SELECT COUNT(*) As Cant FROM usuario where cidusuario= ?usuario AND cpassword = ?pass";
                MySqlCommand myComando = new MySqlCommand(query, myConexion);
                myComando.Parameters.AddWithValue("?usuario", cUsuario);
                myComando.Parameters.AddWithValue("?pass", cPassword);

                int cant = System.Convert.ToInt32(myComando.ExecuteScalar());

                vcUsuario = "";
                vcFechaTrabajo = "";
                vcAreaTrabajo = "";

                if (cant > 0)
                {
                    vcUsuario = cUsuario;
                    vcFechaTrabajo = dateTimePicker1.Text;
                    vcAreaTrabajo = cmbArea.Text;

                    lblMensaje.Text = "Saludos Terricola =>" + vcUsuario;

                    //Form2 a = new Form2();
                    //a.ShowDialog();
                    this.Close();
                }


                else
                {
                    // Form10 a = new Form10();
                    lblMensaje.Text = "USUARIO Y CONTRASENA INCORRECTOS";

                    //a.ShowDialog();
                    //this.Close();
                }


            }
        }  // btnIniciar_Click

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            vcUsuario = "";
            vcFechaTrabajo = "";
            vcAreaTrabajo = "";

            this.Close();
        } // btnCerrar_Click

        private void poblaArea()
        {
            string sql = "SELECT * FROM AreaServicio ";
            DataTable dt = new DataTable();

            if (mConexion.getConexion() != null)
            {
                try
                {
                    MySqlCommand commandM = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter daM = new MySqlDataAdapter(commandM);
                    DataTable dtM = new DataTable();
                    daM.Fill(dtM);
                    cmbArea.DisplayMember = "cNombre";
                    cmbArea.ValueMember = "iIdAreaServicio";
                    cmbArea.DataSource = dtM;

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e.ToString());
                }
            }  // mConexion.getConexion
        } // poblaArea
    }
}

