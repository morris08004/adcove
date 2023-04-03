using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace wCWdrmApp
{

    public partial class frmVehiculo : Form
    {
        //MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");
        private Conexion mConexion;
        private string pcAccion = "";

        public frmVehiculo()
        {
            InitializeComponent();
            mConexion = new Conexion();

            poblaCombos();
            poblarBrowse(dgvVehiculo);
            estadoObjeto(false);
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void poblarBrowse(DataGridView grid)
        {
            // MySqlCommand cm = new MySqlCommand("SELECT * FROM vehiculo;", con);
            string cm = "SELECT * FROM vehiculo";

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
            //MySqlDataAdapter da = new MySqlDataAdapter(cm);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //grid.DataSource = dt;

        } // poblarBrowse

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Obtienes la fila actual
            var row = (sender as DataGridView).CurrentRow;
            int viChofer = 0;

              txtIdVehiculo.Text = row.Cells[0].Value.ToString();
              txtInventario.Text = row.Cells[4].Value.ToString();
                   txtPlaca.Text = row.Cells[11].Value.ToString();
                txtNumMotor.Text = row.Cells[5].Value.ToString();
                txtNumSerie.Text = row.Cells[6].Value.ToString();
             txtNumCilindro.Text = row.Cells[7].Value.ToString();
                      txtKm.Text = row.Cells[10].Value.ToString();
                  txtModelo.Text = row.Cells[21].Value.ToString();
            txtRendPorLitro.Text = row.Cells[8].Value.ToString();
                   txtColor.Text = row.Cells[3].Value.ToString();
                  txtLtKmHr.Text = row.Cells[23].Value.ToString();
              txtiResguardo.Text = row.Cells[13].Value.ToString();
            txtcResponsable.Text = row.Cells[24].Value.ToString();

            if (EsFecha(row.Cells[9].Value.ToString()) == true)
            {
                dtpAfinacion.Value = Convert.ToDateTime(row.Cells[9].Value);
            }

            if (EsFecha(row.Cells[17].Value.ToString()) == true)
            {
                dtpArrendamiento.Value = Convert.ToDateTime(row.Cells[17].Value);
            }
            // ---------  Marca
            if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() != "")
            {
                cmbMarca.SelectedValue = Convert.ToInt32(row.Cells[1].Value.ToString());
            }
            // ---------  Tipo de Vehiculo
            if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() != "")
            {
                cmbTipoVehiculo.SelectedValue = Convert.ToInt32(row.Cells[2].Value.ToString());
            }
            // ---------  Tipo de Arrendamiento
            if (row.Cells[22].Value != null && row.Cells[22].Value.ToString() != "")
            {
                cmbTipoArrendamiento.SelectedValue = Convert.ToInt32(row.Cells[22].Value.ToString());
            }
            // ---------  Chofer
            if (row.Cells[14].Value != null && row.Cells[14].Value.ToString() != "")
            {
                /* cmbChofer.SelectedValue = Convert.ToInt32(row.Cells[14].Value.ToString());*/
                                  viChofer = Convert.ToInt32(row.Cells[14].Value.ToString());
                txtiChofer.Text = row.Cells[14].Value.ToString();
            }

            // --------- poliza de seguro 
            int m;
            if (row.Cells[12].Value.ToString() != null && row.Cells[12].Value.ToString() != "")
            {
                m = Int32.Parse(row.Cells[12].Value.ToString());
            }
            else
            {
                m = 0;
            }

            poblaPolizaSeguro(m);

            // --------- Resguardo 
            int miResguardo;
            if (row.Cells[13].Value.ToString() != null && row.Cells[13].Value.ToString() != "")
            {
                txtiResguardo.Text = row.Cells[13].Value.ToString();
                miResguardo = Int32.Parse(row.Cells[13].Value.ToString());
            }
            else
            {
                miResguardo = 0;
            }

            poblaResguardo(miResguardo);

            if (viChofer != 0)
            {
                poblaConductor(viChofer);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void poblaPolizaSeguro(int piPoliza)
        {
             TxtcPoliza.Text = "";
             txtiInciso.Text = "";
             txtdaVence.Text = "";
              txtdaPago.Text = "";
            txtIdPoliza.Text = piPoliza.ToString();

            if (piPoliza != 0)
            {
                MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");
                try
                {
                    con.Open();
                    string sql = "SELECT * FROM polizaseguro where iidpoliza=" + piPoliza.ToString() + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //cmd.Parameters.AddWithValue("@producto", piPoliza);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TxtcPoliza.Text = reader.GetString(1);
                        txtiInciso.Text = reader.GetString(2);
                        txtdaVence.Text = reader.GetString(3).ToString();
                        txtdaPago.Text = reader.GetString(4).ToString();
                        //txtIdPoliza.Text = reader.GetString(0).ToString();
                    }
                } catch (Exception e)
                {
                    MessageBox.Show("No fue posible obtener la poliza de seguro");
                }
                finally
                {
                   con.Close();
                }
                
            }
        } // poblaPolizaSeguro


        private void poblaCombos()
        {
                        cmbMarca.Items.Clear();
                 cmbTipoVehiculo.Items.Clear();
            cmbTipoArrendamiento.Items.Clear();
                       
                   cmbTipoChofer.Items.Clear();                    

            string sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'M' ";
            DataTable dt = new DataTable();

            if (mConexion.getConexion() != null)
            {
                try
                {
                    MySqlCommand commandM = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter daM = new MySqlDataAdapter(commandM);
                    DataTable dtM = new DataTable();
                    daM.Fill(dtM);
                    cmbMarca.DisplayMember = "cDescripcion";
                    cmbMarca.ValueMember = "iIdTipo";
                    cmbMarca.DataSource = dtM;

                    // -----------------------------
                    sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'V' ;";
                    MySqlCommand commandV = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter daV = new MySqlDataAdapter(commandV);
                    DataTable dtV = new DataTable();
                    daV.Fill(dtV);
                    cmbTipoVehiculo.DisplayMember = "cDescripcion";
                    cmbTipoVehiculo.ValueMember = "iIdTipo";
                    cmbTipoVehiculo.DataSource = dtV;

                    // -----------------------------
                    sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'A' ;";
                    MySqlCommand commandA = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter daA = new MySqlDataAdapter(commandA);
                    DataTable dtA = new DataTable();
                    daA.Fill(dtA);
                    cmbTipoArrendamiento.DisplayMember = "cDescripcion";
                    cmbTipoArrendamiento.ValueMember = "iIdTipo";
                    cmbTipoArrendamiento.DataSource = dtA;

                    // -----------------------------
                    sql = "SELECT * FROM TipoGenerico WHERE cTipo = 'C' ;";
                    MySqlCommand commandTC = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dTC = new MySqlDataAdapter(commandTC);
                    DataTable dtTC = new DataTable();
                    dTC.Fill(dtTC);
                    cmbTipoChofer.DisplayMember = "cDescripcion";
                    cmbTipoChofer.ValueMember = "iIdTipo";
                    cmbTipoChofer.DataSource = dtTC;

                    // -----------------------------
                    /*sql = "SELECT * FROM Conductor";
                    MySqlCommand commandCon = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dCon = new MySqlDataAdapter(commandCon);
                    DataTable dtCon = new DataTable();
                    dCon.Fill(dtCon);
                    cmbChofer.DisplayMember = "cNombre";
                    cmbChofer.ValueMember = "iIdConductor";
                    cmbChofer.DataSource = dtCon;*/
                    // -----------------------------
                    /*sql = "SELECT * FROM AreaServicio";
                    MySqlCommand commandSV = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dSV = new MySqlDataAdapter(commandSV);
                    DataTable dtSV = new DataTable();
                    dSV.Fill(dtSV);
                    cmbArea.DisplayMember = "cNombre";
                    cmbArea.ValueMember = "iIdAreaServicio";
                    cmbArea.DataSource = dtSV;*/
                    // -----------------------------
                    /*sql = "SELECT * FROM niveleducativo WHERE iPadre=1";
                    MySqlCommand commandPadre = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dPadre = new MySqlDataAdapter(commandPadre);
                    DataTable dtPadre = new DataTable();
                    dPadre.Fill(dtPadre);
                    cmbDireccion.DisplayMember = "cNombre";
                    cmbDireccion.ValueMember = "iNodo";
                    cmbDireccion.DataSource = dtPadre;*/
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }



            }  // getConexion != null

        }  // poblaCombos

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void poblaResguardo(int piFolio)
        {
//txtcResponsable.Text = "";
               txtcDireccion.Text = "";
            txtcDepartamento.Text = "";
                    txtcArea.Text = "";
                       int viNodo = 0;
                      int viPadre = 0;
                       int viArea = 0;
               txtiDireccion.Text = "0";
            txtiDepartamento.Text = "0";
                    txtiArea.Text = "0";
            
            if (piFolio != 0)
            {
                MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

                con.Open();
                string sql = "SELECT * FROM Resguardo where iIdResguardo=" + piFolio.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@producto", piPoliza);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtiDepartamento.Text = reader.GetString(1); // iNodo
                    txtiArea.Text = reader.GetString(2); // iAreaServicio
                    if (txtcResponsable.Text == "")
                    {
                        txtcResponsable.Text = reader.GetString(3);
                    }
                    viNodo = reader.GetInt32(1);
                    viArea = reader.GetInt32(2); // iAreaServicio

                } // (reader.Read())

                con.Close();
            }
                
                if (viNodo != 0)
                {
                  MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");
                  con.Open();
                  string sqlNodo = "SELECT * FROM niveleducativo where inodo=" + viNodo.ToString() + ";";
                    MySqlCommand cmdNodo = new MySqlCommand(sqlNodo, con);
                    MySqlDataReader readerNodo = cmdNodo.ExecuteReader();
                    if (readerNodo.Read())
                    {
                        txtcDepartamento.Text = readerNodo.GetString(2);
                                      viPadre = readerNodo.GetInt32(1);
                    }
                  con.Close();
            }  // (viNodo !=0)
                
                
                // ---------  Departamento
                if (viPadre != 0)
                {
                  MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");
                  con.Open();
                    string sqlNodo = "SELECT * FROM niveleducativo where inodo=" + viPadre.ToString() + ";";
                    MySqlCommand cmdNodo = new MySqlCommand(sqlNodo, con);
                    MySqlDataReader readerNodo = cmdNodo.ExecuteReader();
                    if (readerNodo.Read())
                    {
                        txtiDireccion.Text = readerNodo.GetString(1);
                        txtcDireccion.Text = readerNodo.GetString(2);                        
                    }
                    con.Close();

                } // (viPadre != 0)

                
                // ---------  Departamento
                if (viArea != 0)
                {
                  MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");
                  con.Open();
                    string sqlArea = "SELECT * FROM areaservicio where iidareaservicio=" + viArea.ToString() + ";";
                    MySqlCommand cmdArea = new MySqlCommand(sqlArea, con);
                    MySqlDataReader readerArea = cmdArea.ExecuteReader();
                    if (readerArea.Read())
                    {
                        txtiArea.Text = readerArea.GetString(0);
                        txtcArea.Text = readerArea.GetString(1);
                    }
                    con.Close();

                } // (viArea != 0)
                
            
        } // poblaResguardo

        private void poblaConductor(int piConductor)
        {
                  txtLicencia.Text = "";
                    txtInicia.Text = "";
                   txtTermina.Text = "";
             txtHorarioInicia.Text = "";
            txtHorarioTermina.Text = "";
                      txtNota.Text = "";

            MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");
            try
            {
                con.Open();
                string sql = "SELECT * FROM conductor where iidconductor=" + piConductor.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                       long viInicia = reader.GetInt32(10);
                     string vcInicia = convertirSegundosHorasMinutos(reader.GetInt32(10));
                    string vcTermina = convertirSegundosHorasMinutos(reader.GetInt32(11));
                    
                                txtiChofer.Text = reader.GetString(0);
                                txtcChofer.Text = reader.GetString(1);
                    cmbTipoChofer.SelectedValue = reader.GetString(2);
                               txtLicencia.Text = reader.GetString(3);
                                 txtInicia.Text = reader.GetString(4);
                                txtTermina.Text = reader.GetString(5);
                          txtHorarioInicia.Text = vcInicia;
                         txtHorarioTermina.Text = vcTermina;
                                   txtNota.Text = reader.GetString(6);
                } // (reader.Read())
            } catch (Exception e)
            {
                MessageBox.Show("No fue posible obtener a los choferes");
            }
            finally
            {
                con.Dispose();
            }
            

        }  // poblaConductor

        public string convertirSegundosHorasMinutos(int segundos)
        {
            int hor, min, seg;
            hor = (segundos / 3600);
            min = ((segundos - hor * 3600) / 60);
            seg = segundos - (hor * 3600 + min * 60);
            return hor.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2");
        } // convertirSegundosHorasMinutos

        private void estadoObjeto(bool plEstado)
        {
            if (plEstado == true)
            {
                          txtPlaca.Enabled = true;
                         txtModelo.Enabled = true;
                          txtColor.Enabled = true;
                     txtInventario.Enabled = true;
                       txtNumMotor.Enabled = true;
                       txtNumSerie.Enabled = true;
                    txtNumCilindro.Enabled = true;
                             txtKm.Enabled = true;
                   txtRendPorLitro.Enabled = true;
                         txtLtKmHr.Enabled = true;
                      dtpAfinacion.Enabled = true;
                  dtpArrendamiento.Enabled = true;
                        TxtcPoliza.Enabled = true;

                            btnNuevo.Enabled = false;
                           btnEditar.Enabled = false;
                           btnBorrar.Enabled = false;
                          btnGuardar.Enabled = true;
                         btnCancelar.Enabled = true;
                           btnBuscar.Enabled = false;
                         btnImprimir.Enabled = false;
                           btnPoliza.Enabled = true;
                        btnResguardo.Enabled = true;
                         dgvVehiculo.Enabled = false;
                            cmbMarca.Enabled = true;
                     cmbTipoVehiculo.Enabled = true;
                cmbTipoArrendamiento.Enabled = true;
                             txtiArea.Enabled = true;
                           txtiChofer.Enabled = true;
                        txtiDireccion.Enabled = true;
                    txtiDepartamento.Enabled = true;
                     txtcResponsable.Enabled = true;
            }
            else
            {
                          txtPlaca.Enabled = false;
                         txtModelo.Enabled = false;
                          txtColor.Enabled = false;
                     txtInventario.Enabled = false;
                       txtNumMotor.Enabled = false;
                       txtNumSerie.Enabled = false;
                    txtNumCilindro.Enabled = false;
                             txtKm.Enabled = false;
                   txtRendPorLitro.Enabled = false;
                         txtLtKmHr.Enabled = false;
                      dtpAfinacion.Enabled = false;
                  dtpArrendamiento.Enabled = false;
                        TxtcPoliza.Enabled = false;

                            btnNuevo.Enabled = true;
                           btnEditar.Enabled = true;
                           btnBorrar.Enabled = true;
                          btnGuardar.Enabled = false;
                         btnCancelar.Enabled = false;
                           btnBuscar.Enabled = true;
                         btnImprimir.Enabled = true;
                           btnPoliza.Enabled = false;
                        btnResguardo.Enabled = false;
                         dgvVehiculo.Enabled = true;
                            cmbMarca.Enabled = false;
                     cmbTipoVehiculo.Enabled = false;
                cmbTipoArrendamiento.Enabled = false;   
                            txtiArea.Enabled = false;
                          txtiChofer.Enabled = false;
                       txtiDireccion.Enabled = false;
                    txtiDepartamento.Enabled = false;
                     txtcResponsable.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoObjeto(true);
            limpiaCampos();
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
              int viValida = 0;

            viValida = validaObjeto(txtPlaca.Text, txtModelo.Text, txtColor.Text, txtInventario.Text, txtNumMotor.Text,
                                    txtNumSerie.Text, txtNumCilindro.Text, txtKm.Text, txtRendPorLitro.Text,
                                    txtLtKmHr.Text, dtpAfinacion.Value, dtpArrendamiento.Value, txtIdPoliza.Text,
                                    txtIdVehiculo.Text, cmbMarca.SelectedValue.ToString(), cmbTipoVehiculo.SelectedValue.ToString(),
                                    cmbTipoArrendamiento.SelectedValue.ToString(), txtiChofer.Text, txtiResguardo.Text, txtcResponsable.Text);
            if (viValida == 1) // 1 = Error   0 = ok
            {
                MessageBox.Show("ERROR: uno ó mas campos no tienen valor capturado");
                return;
            }
            estadoObjeto(false);
            viDevuelve = guardarObjeto(txtPlaca.Text, txtModelo.Text, txtColor.Text, txtInventario.Text, txtNumMotor.Text,
                          txtNumSerie.Text, txtNumCilindro.Text, txtKm.Text, txtRendPorLitro.Text,
                          txtLtKmHr.Text, dtpAfinacion.Value, dtpArrendamiento.Value, txtIdPoliza.Text,
                          txtIdVehiculo.Text, cmbMarca.SelectedValue.ToString(), cmbTipoVehiculo.SelectedValue.ToString(),
                          cmbTipoArrendamiento.SelectedValue.ToString(),txtiChofer.Text, txtiResguardo.Text, txtcResponsable.Text);
                        
            if (viDevuelve!=0)
            {
                switch (pcAccion)
                {
                    case "N":
                        txtIdPoliza.Text = viDevuelve.ToString();
                        MessageBox.Show("Vehiculo registrado exitosamente");

                        break;
                    case "E":
                        MessageBox.Show("Cambios registrados exitosamente");
                        break;
                }
                pcAccion = "";
                poblarBrowse(dgvVehiculo);
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

        private void limpiaCampos()
        {
                      txtPlaca.Text = "";
                     txtModelo.Text = "";
                      txtColor.Text = "";
                 txtInventario.Text = "";
                   txtNumMotor.Text = "";
                   txtNumSerie.Text = "";
                txtNumCilindro.Text = "";
                         txtKm.Text = "";
               txtRendPorLitro.Text = "";
                     txtLtKmHr.Text = "";
                 dtpAfinacion.Value = DateTime.Now;
             dtpArrendamiento.Value = DateTime.Now;
                   txtIdPoliza.Text = "0";
                 txtIdVehiculo.Text = "0";

            TxtcPoliza.Text = "";
            txtiInciso.Text = "";
            txtdaVence.Text = "";
             txtdaPago.Text = "";
            

        }

        private int guardarObjeto(string pcPlaca, string piModelo, string pcColor, string pcInventario, string pcMotor,
                                   string pcSerie, string piCilindro, string pikm, string piRendXlitro, string piLtKmHr,
                                   DateTime pdaAfinacion, DateTime pdaArrendamiento, string piPoliza, string piVehiculo,
                                   string piMarca, string pitipoVehiculo, string pitipoArrend, string piChofer, string piResguardo,
                                   string pcResponsable)
        {
            int codigoRegistroInsertado = 0;
                     string sqlEjecutar = "";

            switch (pcAccion)
            {
                case "N":

                    sqlEjecutar = "insert into vehiculo (cFolioPlaca, iModelo, cColor, cNumInventario, cSerieMotor, cSerie, " +
                                  "iNumeroCilindro, iKilometraje, iRendimientoLitro, iLitroKmHr, iIdPoliza,iIdMarca, iIdTipoVehiculo, iIdTipoAdquisicion, iIdConductor,daProximaAfinacion,daArrendamiento, iIdResguardo, cResponsable)"
                                //+ ")" 
                                + " VALUES (@placa, @modelo, @color, @NumInv, @Motor, @Serie, @Cilindro, @Km, @RendXlitro, @LtKm,@Poliza,@marca, @tipoVe, @tipoArre,@chofer,@Afina, @Arren, @Resguardo, @Responsable )";
                                //+ ")";
                    break;
                    case "E":
                    
                    sqlEjecutar = "UPDATE vehiculo SET cFolioPlaca=@placa,iModelo=@Modelo,cColor=@Color,cNumInventario=@NumInv,"
                                + "cSerieMotor=@Motor,cSerie=@Serie,iNumeroCilindro=@Cilindro,iKilometraje=@km,iRendimientoLitro=@RendXlitro,"
                                + "iLitroKmHr=@LtKm,iIdPoliza=@Poliza,daProximaAfinacion=@Afina,daArrendamiento=@Arren,"
                                + " iIdMarca=@marca, iIdTipoVehiculo=@tipove, iIdTipoAdquisicion=@tipoArre, iIdConductor=@chofer, iIdResguardo=@Resguardo, cResponsable=@Responsable WHERE iIdVehiculo=@Vehiculo"; 
                    break;
            }
            
            //Para SQL Server cambiar SELECT LAST_INSERT_ID() por SCOPE_IDENTITY()
            try
            {
                MySqlCommand comandoSQL = new MySqlCommand();
                
                string  vdtAfina =  $"{pdaAfinacion:yyyy-MM-dd HH:hh:dd}";
                string vdtArrend = $"{pdaArrendamiento:yyyy-MM-dd HH:mm:dd}";

                 comandoSQL.Connection = mConexion.getConexion();
                comandoSQL.CommandText = sqlEjecutar;
                                    
                switch (pcAccion)
                {
                    case "N":
                          //comandoSQL.Parameters.Add("@Vehiculo", MySqlDbType.Int32).Value = 0;
                            comandoSQL.Parameters.Add("@placa", MySqlDbType.String).Value = pcPlaca;
                            comandoSQL.Parameters.Add("@modelo", MySqlDbType.Int32).Value = piModelo;
                            comandoSQL.Parameters.Add("@color", MySqlDbType.String).Value = pcColor;
                           comandoSQL.Parameters.Add("@NumInv", MySqlDbType.String).Value = pcInventario;
                            comandoSQL.Parameters.Add("@Motor", MySqlDbType.String).Value = pcMotor;
                            comandoSQL.Parameters.Add("@Serie", MySqlDbType.String).Value = pcSerie;
                          comandoSQL.Parameters.Add("@Cilindro", MySqlDbType.Int32).Value = piCilindro;
                                comandoSQL.Parameters.Add("@Km", MySqlDbType.Int32).Value = pikm;
                        comandoSQL.Parameters.Add("@RendXlitro", MySqlDbType.Int32).Value = piRendXlitro;
                              comandoSQL.Parameters.Add("@LtKm", MySqlDbType.Int32).Value = piLtKmHr;
                            comandoSQL.Parameters.Add("@Poliza", MySqlDbType.Int32).Value = piPoliza;
                             comandoSQL.Parameters.Add("@marca", MySqlDbType.Int32).Value = Convert.ToInt32( piMarca);
                            comandoSQL.Parameters.Add("@tipove", MySqlDbType.Int32).Value = Convert.ToInt32( pitipoVehiculo);
                          comandoSQL.Parameters.Add("@tipoArre", MySqlDbType.Int32).Value = Convert.ToInt32( pitipoArrend);
                            comandoSQL.Parameters.Add("@chofer", MySqlDbType.Int32).Value = Convert.ToInt32( piChofer);
                          comandoSQL.Parameters.Add("@Afina", MySqlDbType.DateTime).Value = Convert.ToDateTime(vdtAfina);
                          comandoSQL.Parameters.Add("@Arren", MySqlDbType.DateTime).Value = Convert.ToDateTime(vdtArrend);
                         comandoSQL.Parameters.Add("@Resguardo", MySqlDbType.Int32).Value = Convert.ToInt32(piResguardo);
                      comandoSQL.Parameters.Add("@Responsable", MySqlDbType.String).Value = pcResponsable;

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                        comandoSQL.CommandText = " SELECT LAST_INSERT_ID()";
                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());

                        return codigoRegistroInsertado;
                        break;
                    case "E":
                            comandoSQL.Parameters.Add("@placa", MySqlDbType.String).Value = pcPlaca;
                            comandoSQL.Parameters.Add("@modelo", MySqlDbType.Int32).Value = piModelo;
                            comandoSQL.Parameters.Add("@color", MySqlDbType.String).Value = pcColor;
                           comandoSQL.Parameters.Add("@NumInv", MySqlDbType.String).Value = pcInventario;
                            comandoSQL.Parameters.Add("@Motor", MySqlDbType.String).Value = pcMotor;
                            comandoSQL.Parameters.Add("@Serie", MySqlDbType.String).Value = pcSerie;
                          comandoSQL.Parameters.Add("@Cilindro", MySqlDbType.Int32).Value = piCilindro;
                                comandoSQL.Parameters.Add("@Km", MySqlDbType.Int32).Value = pikm;
                        comandoSQL.Parameters.Add("@RendXlitro", MySqlDbType.Int32).Value = piRendXlitro;
                              comandoSQL.Parameters.Add("@LtKm", MySqlDbType.Int32).Value = piLtKmHr;
                            comandoSQL.Parameters.Add("@Poliza", MySqlDbType.Int32).Value = piPoliza;
                          comandoSQL.Parameters.Add("@Afina", MySqlDbType.DateTime).Value = Convert.ToDateTime(vdtAfina);
                          comandoSQL.Parameters.Add("@Arren", MySqlDbType.DateTime).Value = Convert.ToDateTime(vdtArrend);
                          comandoSQL.Parameters.Add("@Vehiculo", MySqlDbType.Int32).Value = piVehiculo;

                               comandoSQL.Parameters.Add("@marca", MySqlDbType.Int32).Value = Convert.ToInt32( piMarca);
                              comandoSQL.Parameters.Add("@tipove", MySqlDbType.Int32).Value = Convert.ToInt32( pitipoVehiculo);
                            comandoSQL.Parameters.Add("@tipoArre", MySqlDbType.Int32).Value = Convert.ToInt32( pitipoArrend);
                              comandoSQL.Parameters.Add("@chofer", MySqlDbType.Int32).Value = Convert.ToInt32( piChofer);
                           comandoSQL.Parameters.Add("@Resguardo", MySqlDbType.Int32).Value = Convert.ToInt32(piResguardo);
                        comandoSQL.Parameters.Add("@Responsable", MySqlDbType.String).Value = pcResponsable;

                        codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteNonQuery());
                        break;
                }
                
                return codigoRegistroInsertado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Añadir/Modificar registro [" + piVehiculo.ToString() + "]: " + ex.Message);
                //new EscribirLog("Error al añadir dispositivo [" + tipo + "]: " + ex.Message, true);
                return codigoRegistroInsertado; //0 si ha habido algún error
            }
            finally
            {
                //conexionBD.Close();
            }
        } //guardarObjeto
        private void BuscaPolizaSeguro(string pcPoliza)
        {
            TxtcPoliza.Text = "";
            txtiInciso.Text = "";
            txtdaVence.Text = "";
             txtdaPago.Text = "";

            if (pcPoliza != "")
            {
                MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

                con.Open();
                string sql = "SELECT * FROM polizaseguro where cFolio='" + pcPoliza.ToString() + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@producto", pcPoliza);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                     TxtcPoliza.Text = reader.GetString(1);
                     txtiInciso.Text = reader.GetString(2);
                     txtdaVence.Text = reader.GetString(3).ToString();
                      txtdaPago.Text = reader.GetString(4).ToString();
                    txtIdPoliza.Text = reader.GetString(0).ToString();
                }
                else
                {
                    MessageBox.Show("Folio de poliza:" + pcPoliza + "No existe");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("debes teclear folio de poliza válido");
            }
        } // poblaPolizaSeguro

        private void txtcPoliza_Enter(object sender, EventArgs e)
        {
            //BuscaPolizaSeguro(TxtcPoliza.Text);
        }

        private void cmbArea_SelectedValueChanged(object sender, EventArgs e)
        {                        
           /* if (cmbArea.SelectedValue != null)
            {
               // BuscarResguardo(cmbArea.SelectedValue.ToString());
               // int viArea = Convert.ToInt32(cmbArea.SelectedValue.ToString());
               
            }*/
            
        }

        private void BuscarResguardo(string pcArea)
        {
            int viArea = Convert.ToInt32(pcArea);
            string sql = "";
            txtcResponsable.Text = "";
              txtiResguardo.Text = "0";
                      int viNodo = 0;
                     int viPadre = 0;

            if (viArea != 0)
            {
                MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");
                
                    con.Open();
                    sql = "SELECT * FROM Resguardo where iAreaServicio=" + viArea.ToString() + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //cmd.Parameters.AddWithValue("@producto", piPoliza);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtiResguardo.Text = reader.GetString(0);
                        txtcResponsable.Text = reader.GetString(3);
                        viNodo = reader.GetInt32(1);
                    } // (reader.Read())
                con.Close();
                

                    //con.Open();
                    if (viNodo != 0)
                    {
                    viPadre = damePadre(viNodo); 
                    }  // (viNodo !=0)
                

                // ---------  Direccion
                if (viPadre != 0)
                {
                    /*cmbDireccion.SelectedValue = viPadre;
                    // -----------------------------
                    sql = "SELECT * FROM niveleducativo WHERE iPadre=" + viPadre.ToString();
                    MySqlCommand commandPadre = new MySqlCommand(sql, mConexion.getConexion());
                    MySqlDataAdapter dPadre = new MySqlDataAdapter(commandPadre);
                    DataTable dtPadre = new DataTable();
                    dPadre.Fill(dtPadre);
                    cmbDepto.DisplayMember = "cNombre";
                      cmbDepto.ValueMember = "iNodo";
                       cmbDepto.DataSource = dtPadre;
                    cmbDepto.SelectedValue = viNodo;*/
                }
            }

        }

        private void cmbChofer_SelectedValueChanged(object sender, EventArgs e)
        {
            /*if (cmbChofer.SelectedValue != null)
            {
                int viChofer = Convert.ToInt32(cmbChofer.SelectedValue.ToString());
                //BuscarChofer(viChofer);
                poblaConductor(viChofer);
            }*/
        }

        private void BuscarChofer(int piChofer)
        {
            
        }  // BuscarChofer

        private void lblAfinacion_Click(object sender, EventArgs e)
        {

        }

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

        private void btnPoliza_Click(object sender, EventArgs e)
        {
            //this.Hide();

            frmPoliza frm = new frmPoliza();

            frm.Show();
        }

        private void btnResguardo_Click(object sender, EventArgs e)
        {            
            frmResguardo frm = new frmResguardo();

            frm.Show();
        }

        private void TxtcPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            BuscaPolizaSeguro(TxtcPoliza.Text);
        }

        private void cmbDepto_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbDireccion_SelectedValueChanged(object sender, EventArgs e)
        {
            // ---------  Departamento
            /*string sql = "";            
                 int viPadre = Convert.ToInt32( cmbDireccion.SelectedValue);
                // -----------------------------
                sql = "SELECT * FROM niveleducativo WHERE iPadre=" + viPadre.ToString();
                MySqlCommand commandPadre = new MySqlCommand(sql, mConexion.getConexion());
                MySqlDataAdapter dPadre = new MySqlDataAdapter(commandPadre);
                DataTable dtPadre = new DataTable();
                dPadre.Fill(dtPadre);
                cmbDepto.DisplayMember = "cNombre";
                cmbDepto.ValueMember = "iNodo";
                cmbDepto.DataSource = dtPadre; */
                //cmbDepto.SelectedValue = viNodo;
            
        }
        private int damePadre(int piNodo)
        {
            int viPadre = 0;
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

                con.Open();
                
                string sqlNodo = "SELECT * FROM niveleducativo where inodo=" + piNodo.ToString() + ";";
                MySqlCommand cmdNodo = new MySqlCommand(sqlNodo, con);
                MySqlDataReader readerNodo = cmdNodo.ExecuteReader();
                if (readerNodo.Read())
                {
                    viPadre = readerNodo.GetInt32(1);
                }
                con.Close();
                return viPadre;
            } catch (Exception e)
            {
                MessageBox.Show("no fue posible obtener el padre");
            }
            return viPadre;
            
        }

        private void cmbArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
             /*BuscarResguardo(cmbArea.SelectedValue.ToString());
            int viArea = Convert.ToInt32(cmbArea.SelectedValue.ToString());*/
        }

        private void cmbDepto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // mConexion.getConexion().Close();

            //if (mConexion.getConexion() != null)
            //{

           /* MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");
            int viDepto = Convert.ToInt32(cmbDepto.SelectedValue);
            con.Open();
            string sql = "SELECT * FROM Resguardo where iNodo=" + viDepto.ToString() + ";";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@producto", piPoliza);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // poblar el resguardo nada mas
                //cmbArea.SelectedValue = reader.GetString(2);
                //txtcResponsable.Text = reader.GetString(3);
               
                cmbArea.DisplayMember = "cNombre";
                cmbArea.ValueMember = "iNodo";
                cmbArea.DataSource = reader;
            } // (reader.Read())

            con.Close();*/
            //}
        }

        private void txtiDireccion_KeyDown(object sender, KeyEventArgs e)
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
                    txtiDireccion.Text = vcIdLocal;
                    txtcDireccion.Text = vcNombre;
                }
            }
        }

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
                    string sql = "";
                    // -------------  busca su id del resguardo

                    MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

                    con.Open();
                    sql = "SELECT * FROM Resguardo where iAreaServicio=" + vcIdLocal.ToString() + 
                          " AND iNodo = " + txtiDepartamento.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //cmd.Parameters.AddWithValue("@producto", piPoliza);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtiResguardo.Text = reader.GetString(0);
                        txtcResponsable.Text = reader.GetString(3);
                        
                    } // (reader.Read())
                    con.Close();
                } // (vcIdLocal != "")
            }
        }

        private void txtiChofer_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine whethedr the keystroke is a number from the top of the keyboard.
            if (e.KeyCode == Keys.F3)  // || e.KeyCode > Keys.D9
            {
                e.Handled = true;
                frmConsulta frm = new frmConsulta(2, 0);
                frm.ShowDialog();

                //variable publicas
                string vcIdLocal = frm.vcId;
                string vcNombre = frm.vcValor;

                if (vcIdLocal != "")
                {
                    txtiChofer.Text = vcIdLocal;
                    txtcChofer.Text = vcNombre;
                    string sql = "";
                    // -------------  busca su id del resguardo

                    MySqlConnection con = new MySqlConnection("server=localhost; Uid=root; Password=Leygris1$; Database=controlvehicular; Port=3306");

                    con.Open();
                    sql = "SELECT * FROM Resguardo where iAreaServicio=" + vcIdLocal.ToString() +
                          " AND iNodo = " + txtiDepartamento.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    //cmd.Parameters.AddWithValue("@producto", piPoliza);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtiResguardo.Text = reader.GetString(0);
                        txtcResponsable.Text = reader.GetString(3);

                    } // (reader.Read())
                    con.Close();
                } // (vcIdLocal != "")
            }
        } // txtiChofer_keyDown

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine whethedr the keystroke is a number from the top of the keyboard.
            if (e.KeyCode == Keys.F3)  // || e.KeyCode > Keys.D9
            {
                e.Handled = true;
                frmConsulta frm = new frmConsulta(3, 0);
                frm.ShowDialog();

                //variable publicas
                string vcIdLocal = frm.vcId;
                string vcNombre = frm.vcValor;

                if (vcIdLocal != "")
                {
                      txtPlaca.Text = vcIdLocal;
                    //txtcChofer.Text = vcNombre;
                                        
                    
                } // (vcIdLocal != "")
            }
        }  // txtPlaca_KeyDown

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private int validaObjeto(string pcPlaca, string piModelo, string pcColor, string pcInventario, string pcMotor,
                                 string pcSerie, string piCilindro, string pikm, string piRendXlitro, string piLtKmHr,
                                 DateTime pdaAfinacion, DateTime pdaArrendamiento, string piPoliza, string piVehiculo,
                                 string piMarca, string pitipoVehiculo, string pitipoArrend, string piChofer, string piResguardo,
                                 string pcResponsable)
        {
            int viDevolver = 0;
            if (pcPlaca == "") { viDevolver = 1; }
            if (piModelo == "0") { viDevolver = 1; }
            if (pcColor == "") { viDevolver = 1; }
            if (pcInventario == "") { viDevolver = 1; }
            if (pcMotor == "") { viDevolver = 1; }
            if (pcSerie == "") { viDevolver = 1; }
            if (piCilindro == "0") { viDevolver = 1; }
            if (pikm == "0") { viDevolver = 1; }
            if (piRendXlitro == "0") { viDevolver = 1; }
            if (piLtKmHr == "0") { viDevolver = 1; }
            if (EsFecha(pdaAfinacion.ToString()) == false) { viDevolver = 1; }
            if (EsFecha(pdaArrendamiento.ToString()) == false) { viDevolver = 1; }
            if (piPoliza == "0") { viDevolver = 1; }
            if (piVehiculo == "0") { viDevolver = 1; }
            if (piMarca == "0") { viDevolver = 1; }
            if (pitipoVehiculo == "0") { viDevolver = 1; }
            if (pitipoArrend == "0") { viDevolver = 1; }
            if (piChofer == "0") { viDevolver = 1; }
            if (piResguardo == "0") { viDevolver = 1; }
            if (pcResponsable == "") { viDevolver = 1; }

            return viDevolver;
        } // validaObjeto

        private void txtIdVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumCilindro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRendPorLitro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLtKmHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtiChofer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
