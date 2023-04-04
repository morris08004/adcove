using System;
using System.Windows.Forms;

namespace wCWdrmApp
{
    public partial class frmPrincipal : Form
    {
        private Conexion mConexion;

        public frmPrincipal()
        {
            InitializeComponent();
            mConexion = new Conexion();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblFecha.Text = DateTime.Now.ToShortDateString();
            panelMttoVhicular.Hide();
            panelMttoVales.Visible = false;
            panelMttoTraslado.Visible = false;

            this.UseWaitCursor = false;
            //this.Hide();
                 frmLogin frm = new frmLogin();
            frm.UseWaitCursor = false;
            frm.ShowDialog();

            //variable publicas
            string vcUsuario = frm.vcUsuario;
            string veFechaTrabajo = frm.vcFechaTrabajo;
            string vcAreaTrabajo = frm.vcAreaTrabajo;
            if (vcUsuario != "")
            {
                        lblFecha.Text = veFechaTrabajo;
                lblNombreUsuario.Text = vcUsuario;
                         lblArea.Text = vcAreaTrabajo;
            }
            else
            {
                this.Close();
            }



        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void lblNombreEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void panelMttoVhicular_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMttoVehicular_Click(object sender, EventArgs e)
        {
            panelMttoVhicular.Visible = true;
            panelMttoVales.Visible = false;
            panelMttoTraslado.Visible = false;
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            frmVehiculo frmVehiculo = new frmVehiculo();
            frmVehiculo.ShowDialog();
        }

        private void btnPoliza_Click(object sender, EventArgs e)
        {
            //this.Hide();

            frmPoliza frm = new frmPoliza();

            frm.Show();
        }

        private void btnResguardo_Click(object sender, EventArgs e)
        {
            //this.Hide();

            frmResguardo frm = new frmResguardo();

            frm.Show();
        }

        private void btnPlaca_Click(object sender, EventArgs e)
        {
            //this.Hide();

            frmPlaca frm = new frmPlaca();

            frm.Show();
        }

        private void btnChofer_Click(object sender, EventArgs e)
        {
            //this.Hide();

            frmChofer frm = new frmChofer();

            frm.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            //this.Hide();

            frmProveedor frm = new frmProveedor();

            frm.Show();
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            frmNivelEducativo frm = new frmNivelEducativo();

            frm.Show();
        }

        private void btnMttoVehiculo_Click(object sender, EventArgs e)
        {
            frmBrwMttoVehiculo frm = new frmBrwMttoVehiculo(lblNombreUsuario.Text);

            frm.Show();
        }

        private void btnValeViatico_Click(object sender, EventArgs e)
        {
            panelMttoVhicular.Visible = false;
            panelMttoVales.Visible = true;
            panelMttoTraslado.Visible = false;

        }

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            panelMttoVhicular.Visible = false;
            panelMttoVales.Visible = false;
            panelMttoTraslado.Visible = true;
        }

        private void btnTraslados_Click(object sender, EventArgs e)
        {
            frmBitacora frm = new frmBitacora(lblNombreUsuario.Text);

            frm.Show();
        }
    }


}
