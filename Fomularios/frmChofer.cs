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
    public partial class frmChofer : Form
    {
        private Conexion mConexion;
        private string pcAccion = "";

        public frmChofer()
        {
            InitializeComponent();
            estadoObjeto(false);
            mConexion = new Conexion();
            poblarBrowse(dgvChofer);
            cargaCombo();

        }  // frmChofer

        private void estadoObjeto(bool plEstado)
        {
            if (plEstado == true)
            {
                       txtiChofer.Enabled = false;
                    cmbTipoChofer.Enabled = true;
                       txtcNombre.Enabled = true;
                      txtLicencia.Enabled = true;
                        dtpInicia.Enabled = true;
                       dtpTermina.Enabled = true;
                 txtHorarioInicia.Enabled = true;
                txtHorarioTermina.Enabled = true;
                          txtNota.Enabled = true;

                   btnNuevo.Enabled = false;
                  btnEditar.Enabled = false;
                  btnBorrar.Enabled = false;
                 btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                  btnBuscar.Enabled = false;
                btnImprimir.Enabled = false;
                  dgvChofer.Enabled = false;
            }
            else
            {
                       txtiChofer.Enabled = false;
                    cmbTipoChofer.Enabled = false;
                       txtcNombre.Enabled = false;
                      txtLicencia.Enabled = false;
                        dtpInicia.Enabled = false;
                       dtpTermina.Enabled = false;
                 txtHorarioInicia.Enabled = false;
                txtHorarioTermina.Enabled = false;
                          txtNota.Enabled = false;

                   btnNuevo.Enabled = true;
                  btnEditar.Enabled = true;
                  btnBorrar.Enabled = true;
                 btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                  btnBuscar.Enabled = true;
                btnImprimir.Enabled = true;
                  dgvChofer.Enabled = true;
            }
        } // EstadoObjeto

        private void limpiaCampo()
        {
                   txtiChofer.Text = "0";
                cmbTipoChofer.Text = "0";
                   txtcNombre.Text = "";
                  txtLicencia.Text = "";
                    dtpInicia.Value = DateTime.Now;
                   dtpTermina.Value = DateTime.Now;
             txtHorarioInicia.Text = "  :  :  ";
            txtHorarioTermina.Text = "  :  :  ";
                      txtNota.Text = "";
        }

        private void poblarBrowse(DataGridView grid)
        {
            // MySqlCommand cm = new MySqlCommand("SELECT * FROM vehiculo;", con);
            string cm = "SELECT * FROM Conductor";

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
            viDevuelve = guardarObjeto(txtiChofer.Text, cmbTipoChofer.SelectedValue.ToString(), txtcNombre.Text, txtLicencia.Text, dtpInicia.Value,
                                       dtpTermina.Value,txtHorarioInicia.Text,txtHorarioTermina.Text,txtNota.Text);

            MessageBox.Show("Folio:->" + viDevuelve.ToString());

            if (viDevuelve != 0)
            {
                switch (pcAccion)
                {
                    case "N":
                        txtiChofer.Text = viDevuelve.ToString();
                        MessageBox.Show("Conductor registrado exitosamente");

                        break;
                    case "E":
                        MessageBox.Show("Cambios al Conductor registrados exitosamente");
                        break;
                }
                pcAccion = "";
                poblarBrowse(dgvChofer);
            }  // viDevuelve!=0
            else
            {
                MessageBox.Show("Adicion/cambio del registro no efectuado");
            }
        } // btnGuardar_Click

        private int guardarObjeto(string piChofer, string piTipo, string pcNombre, string pcLicencia, DateTime pdtInicia, DateTime pdtTermina,
                                  string pcHoraInicia, string pcHoraTermina, string pcNota)
        {
            int codigoRegistroInsertado = 0;
            string sqlEjecutar = "";

            switch (pcAccion)
            {
                case "N":

                    sqlEjecutar = "insert into conductor (cNombre, iidtipo, clicenciafolio,dainicia,datermina,cobservaciones,ihorainicia,ihoratermina)"
                                + " VALUES (@Nombre, @tipo, @licencia,@inicia,@termina,@nota,@horainicia,@horatermina )";

                    break;
                case "E":

                    sqlEjecutar = "UPDATE conductor SET cnombre=@Nombre,iidtipo=@tipo,clicenciafolio=@licencia,dainicia=@inicia,datermina=@termina,cobservaciones=@nota,ihorainicia=@horainicia,ihoratermina=@horatermina WHERE iidconductor=@chofer";
                    break;
            }

            //Para SQL Server cambiar SELECT LAST_INSERT_ID() por SCOPE_IDENTITY()
            try
            {
                MySqlCommand comandoSQL = new MySqlCommand();

                 string vdtInicia = $"{pdtInicia:yyyy-MM-dd HH:hh:dd}";
                string vdtTermina = $"{pdtTermina:yyyy-MM-dd HH:mm:dd}";
                 int viHoraInicia = convierteHora(pcHoraInicia);
                int viHoraTermina = convierteHora(pcHoraTermina);

                comandoSQL.Connection = mConexion.getConexion();
                comandoSQL.CommandText = sqlEjecutar;

                switch (pcAccion)
                {
                    case "N":
                        //comandoSQL.Parameters.Add("@Vehiculo", MySqlDbType.Int32).Value = 0;
                           comandoSQL.Parameters.Add("@Nombre", MySqlDbType.String).Value = pcNombre;
                              comandoSQL.Parameters.Add("@tipo", MySqlDbType.Int32).Value = Convert.ToInt32(piTipo);
                         comandoSQL.Parameters.Add("@licencia", MySqlDbType.String).Value = pcLicencia;
                         comandoSQL.Parameters.Add("@inicia", MySqlDbType.DateTime).Value = vdtInicia;
                        comandoSQL.Parameters.Add("@termina", MySqlDbType.DateTime).Value = vdtTermina;
                        comandoSQL.Parameters.Add("@nota", MySqlDbType.String).Value = pcNota;
                        comandoSQL.Parameters.Add("@horainicia", MySqlDbType.Int32).Value = viHoraInicia;
                        comandoSQL.Parameters.Add("@horatermina", MySqlDbType.Int32).Value = viHoraTermina;

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                        comandoSQL.CommandText = " SELECT LAST_INSERT_ID()";
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());

                        return codigoRegistroInsertado;
                        break;
                    case "E":
                        comandoSQL.Parameters.Add("@Nombre", MySqlDbType.String).Value = pcNombre;
                        comandoSQL.Parameters.Add("@tipo", MySqlDbType.Int32).Value = Convert.ToInt32(piTipo);
                        comandoSQL.Parameters.Add("@licencia", MySqlDbType.String).Value = pcLicencia;
                        comandoSQL.Parameters.Add("@inicia", MySqlDbType.DateTime).Value = vdtInicia;
                        comandoSQL.Parameters.Add("@termina", MySqlDbType.DateTime).Value = vdtTermina;
                        comandoSQL.Parameters.Add("@nota", MySqlDbType.String).Value = pcNota;
                        comandoSQL.Parameters.Add("@horainicia", MySqlDbType.Int32).Value = viHoraInicia;
                        comandoSQL.Parameters.Add("@horatermina", MySqlDbType.Int32).Value = viHoraTermina;
                        comandoSQL.Parameters.Add("@chofer", MySqlDbType.Int32).Value = Convert.ToInt32(piChofer);

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteNonQuery());
                        break;
                }

                return codigoRegistroInsertado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Añadir/Modificar registro [" + piChofer.ToString() + "]: " + ex.Message);
                return codigoRegistroInsertado; //0 si ha habido algún error
            }
            finally
            {
                //conexionBD.Close();
            }
        } //guardarObjeto

        private void dtpTermina_ValueChanged(object sender, EventArgs e)
        {

        }

        public string convertirSegundosHorasMinutos(int segundos)
        {
            int hor, min, seg;
            hor = (segundos / 3600);
            min = ((segundos - hor * 3600) / 60);
            seg = segundos - (hor * 3600 + min * 60);
            return hor.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2");
        } // convertirSegundosHorasMinutos
        public int convierteHora (string pcHora)
        {
               int viHora = 0;
            string vcHora = "";
              int viHoras = 0;
             int viMinuto = 0;
            int viSegundo = 0;

               viHora = Convert.ToInt32(pcHora.Substring(0, 2));
             viMinuto = Convert.ToInt32(pcHora.Substring(3, 2));
            viSegundo = Convert.ToInt32(pcHora.Substring(6, 2));
              viHoras = (viHora * 60 * 60)
                      + (viMinuto * 60)
                      + viSegundo;

            return viHoras;
        } // covierteHora

        private void cargaCombo()
        {
            string sql = "";
            // -----------------------------
            sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'C' ;";
            MySqlCommand commandTC = new MySqlCommand(sql, mConexion.getConexion());
            MySqlDataAdapter dTC = new MySqlDataAdapter(commandTC);
            DataTable dtTC = new DataTable();
            dTC.Fill(dtTC);
            cmbTipoChofer.DisplayMember = "cDescripcion";
            cmbTipoChofer.ValueMember = "iIdTipo";
            cmbTipoChofer.DataSource = dtTC;
        }

        private void dgvChofer_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;

            int viInicia = Convert.ToInt32( row.Cells[10].Value.ToString());
            int viTermina = Convert.ToInt32(row.Cells[11].Value.ToString());

            string vcInicia = convertirSegundosHorasMinutos(viInicia);
            string vcTermina = convertirSegundosHorasMinutos(viTermina);

                        txtiChofer.Text = row.Cells[0].Value.ToString();
                        txtcNombre.Text = row.Cells[1].Value.ToString();
            cmbTipoChofer.SelectedValue = row.Cells[2].Value.ToString();
                       txtLicencia.Text = row.Cells[3].Value.ToString();
                        dtpInicia.Value = Convert.ToDateTime( row.Cells[4].Value.ToString());
                       dtpTermina.Value = Convert.ToDateTime( row.Cells[5].Value.ToString());
                  txtHorarioInicia.Text = vcInicia;
                 txtHorarioTermina.Text = vcTermina;
                           txtNota.Text = row.Cells[6].Value.ToString();

        } // dgvChofer_SelectionChanged

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoObjeto(false);
            pcAccion = "";
        }
    }
}
