using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;


#region Variables Globales
public enum BaseDatos { SQLServer, Progress, MySQL }
public enum Modos { Agregar = 1, Modificar, Eliminar, ActivarCamara, TomarFoto, SubirFoto, SubirDocumento, ConsultaMaterias };
#endregion
namespace Datos
{
    public class clsConexion : IDisposable
    {
        #region [Variables]
        SqlCommand _comando;
        SqlConnection _conexion;
        SqlDataAdapter _adaptador;
        SqlDataReader _reader;
        // DataTable _tabla;
        SqlTransaction _transaccion;
        Int32 _rowsAfectados = 0;
        OdbcCommand _odbcCommand;
        OdbcConnection _odbcConexion;
        OdbcDataReader _odbcReader;
        OdbcDataAdapter _odbcAdataptador;
        OdbcTransaction _odbcTransaccion;
        MySqlCommand _mysqlComando;
        MySqlConnection _mysqlConexion;
        MySqlDataAdapter _mysqlAdaptador;
        MySqlTransaction _mysqlTransaccion;
        MySqlDataReader _mysqlReader;

        private bool _bool = false;
        public BaseDatos BasedeDatos;
        // private DataTable DTConexion;
        private string _error;
        public string ERRORDB
        {
            get { return _error; }
            set { _error = value; }
        }
        #endregion
        #region [Constructor]
        public clsConexion() { }
        public clsConexion(string CadenaConexion, BaseDatos _BaseDatos)
        {
            switch (_BaseDatos)
            {
                case BaseDatos.SQLServer:
                    _conexion = new SqlConnection(CadenaConexion);
                    break;

                case BaseDatos.MySQL:
                    _mysqlConexion = new MySqlConnection(CadenaConexion);
                    break;

                case BaseDatos.Progress:
                    _odbcConexion = new OdbcConnection(CadenaConexion);
                    break;
            }
            BasedeDatos = _BaseDatos;
        }
        #endregion
        #region [Métodos]
        private void CapturarError(BaseDatos _BaseDatos, bool IsError, bool IsTransaccion)
        {
            //Guardamos el Error con la Fecha actual.
            if (IsError)
            {
                //Aquí todavia me falta configurar la parte para capturar los errores y guardarlos en un TXT. 
                //lo haré durante el transcurso del proyecto. 
                ////System.IO.StreamWriter sw = new System.IO.StreamWriter("prueba"/*System.IO.Path.GetDirectoryName(System.Configuratio.Process.GetCurrentProcess().MainModule.FileName) + "\\ErrorLog.txt", true*/);
                ////sw.WriteLine(((char)13).ToString());
                ////sw.WriteLine( DateTime.Now.ToLongDateString()+ " " + ERRORDB);
                ////sw.Close();
            }
            //Analizamos que tipo de base de datos es.
            switch (_BaseDatos)
            {
                case BaseDatos.SQLServer:
                    if (IsTransaccion)
                    {
                        if (IsError)
                        {
                            this._transaccion.Rollback();
                        }
                        if (_comando != null)
                        {
                            this._comando.Dispose();
                        }
                        if (this._adaptador != null)
                        {
                            this._adaptador.Dispose();
                        }
                    }
                    else
                    {
                        if (_conexion.State == ConnectionState.Open)
                        {

                            //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
                            _conexion.Close();
                        }
                        if (_comando != null)
                        {
                            _comando.Dispose();
                        }
                    }
                    break;
                case BaseDatos.MySQL:
                    if (IsTransaccion)
                    {
                        if (IsError && _mysqlConexion != null)
                        {
                            this._mysqlTransaccion.Rollback();
                        }
                        /*
                        if (_mysqlComando != null)
                        {
                            this._mysqlComando.Dispose();
                        }
                        if (this._mysqlAdaptador != null)
                        {
                            this._mysqlAdaptador.Dispose();
                        }*/
                    }
                    else
                    {
                        if (_mysqlConexion.State == ConnectionState.Open)
                        {
                            _mysqlConexion.Close();
                        }
                        if (_mysqlComando != null)
                        {
                            _mysqlComando.Dispose();
                        }
                    }
                    break;
                case BaseDatos.Progress:
                    if (IsTransaccion)
                    {
                        if (IsError)
                        {
                            this._odbcTransaccion.Rollback();
                        }
                        if (_odbcCommand != null)
                        {
                            this._odbcCommand.Dispose();
                        }
                        if (_odbcAdataptador != null)
                        {
                            _odbcAdataptador.Dispose();
                        }
                    }
                    else
                    {
                        if (_odbcConexion.State == ConnectionState.Open)
                        {
                            _odbcConexion.Close();
                        }
                        if (_odbcCommand != null)
                        {
                            _odbcCommand.Dispose();
                        }
                    }
                    break;
            }
        }

        public Boolean TestConexion(BaseDatos _BaseDatos)
        {
            _bool = false;
            bool Respuesta = false;
            try
            {
                ERRORDB = string.Empty;
                switch (_BaseDatos)
                {
                    case BaseDatos.SQLServer:
                        _conexion.Open();
                        //   _conexion.Close();
                        break;

                    case BaseDatos.MySQL:
                        _mysqlConexion.Open();
                        //     _mysqlConexion.Close();
                        break;

                    case BaseDatos.Progress:
                        _odbcConexion.Open();
                        //   _odbcConexion.Close();
                        break;
                }
                Respuesta = true;
            }
            catch (Exception ex)
            {
                _bool = true;
                Respuesta = false;
                ERRORDB = ex.Message;
                CapturarError(_BaseDatos, true, false);
            }
            finally
            {
                if (!_bool)
                {
                    CapturarError(_BaseDatos, false, false);
                }
            }
            return Respuesta;
        }
        public Boolean getSchemaBD(ref DataTable DTConexion)
        {
            _bool = false;
            try
            {
                switch (BasedeDatos)
                {
                    case BaseDatos.SQLServer:
                        _conexion.Open();

                        break;
                    case BaseDatos.MySQL:

                        break;
                    case BaseDatos.Progress:

                        break;
                }
                _bool = true;
            }
            catch (Exception ex)
            {
                _bool = false;
                ERRORDB = ex.Message;
                CapturarError(BasedeDatos, true, false);
            }
            finally
            {
                if (_bool)
                {
                    CapturarError(BasedeDatos, false, false);
                }
            }
            return _bool;
        }
        /// <summary>
        /// LlenarDataTable regresa True si el  DataTable ha sido correctamente Llenado con los datos solicitados en el "SQL_SELECT". Si existe algún error retorna False y el error se mantendrá en la propiedad ERRORDB
        /// </summary>
        /// <param name="SQL_SELECT"></param>
        /// <returns></returns>
        public Boolean LlenarDataTable(string SQL_SELECT, ref DataTable DTable)
        {
            _bool = false;
            Boolean Respuesta = false;
            try
            {
                switch (BasedeDatos)
                {
                    case BaseDatos.SQLServer:
                        if (_conexion.State == ConnectionState.Open)
                        {
                            _conexion.Close();
                        }
                        _conexion.Open();
                        DTable = new DataTable();
                        _adaptador = new SqlDataAdapter(SQL_SELECT, _conexion);
                        _adaptador.Fill(DTable);
                        break;
                    case BaseDatos.MySQL:
                        if (_mysqlConexion.State == ConnectionState.Open)
                        {
                            _mysqlConexion.Close();
                        }
                        _mysqlConexion.Open();
                        DTable = new DataTable();
                        _mysqlAdaptador = new MySqlDataAdapter(SQL_SELECT, _mysqlConexion);
                        _mysqlAdaptador.Fill(DTable);
                        break;
                    case BaseDatos.Progress:
                        if (_odbcConexion.State == ConnectionState.Open)
                        {
                            _odbcConexion.Close();
                        }
                        _odbcConexion.Open();
                        DTable = new DataTable();
                        _odbcAdataptador = new OdbcDataAdapter(SQL_SELECT, _odbcConexion);
                        _odbcAdataptador.Fill(DTable);
                        break;
                }
                Respuesta = true;
            }
            catch (Exception ex)
            {
                _bool = true;
                Respuesta = false;
                ERRORDB = ex.Message;
                CapturarError(BasedeDatos, true, false);
            }
            finally
            {
                if (!_bool)
                {
                    CapturarError(BasedeDatos, false, false);
                }
            }
            return Respuesta;
        }

        public int EjecutarComando(string SQL_INSERT_UPDATE_DELETE)
        {
            _bool = false; //asigno false para empezar.
            _rowsAfectados = 0; // esta es la variable que retorno.. la inicializo en 0 .. 
            try
            {
                switch (BasedeDatos) //Aquí depende de mi Base de datos..
                {
                    case BaseDatos.SQLServer:
                        if (_conexion.State == ConnectionState.Open)
                        {
                            _conexion.Close();
                        }
                        _conexion.Open();
                        _comando = new SqlCommand(SQL_INSERT_UPDATE_DELETE, _conexion);
                        _rowsAfectados = _comando.ExecuteNonQuery();
                        break;

                    case BaseDatos.MySQL:
                        if (_mysqlConexion.State == ConnectionState.Open)
                        {
                            _mysqlConexion.Close();
                        }
                        _mysqlConexion.Open(); //Abro mi conexión 
                        _mysqlComando = new MySqlCommand(SQL_INSERT_UPDATE_DELETE, _mysqlConexion); //aquí Instancio mi objeto de comando de Mysql.. y le digo que comando ejecutará.. y en que conexión lo hará.
                        _rowsAfectados = _mysqlComando.ExecuteNonQuery(); //Aquí se ejecuta el SQL que yo le mande.. y usa mi conexión.
                        break;

                    case BaseDatos.Progress:
                        if (_odbcConexion.State == ConnectionState.Open)
                        {
                            _odbcConexion.Close();
                        }
                        _odbcConexion.Open();
                        _odbcCommand = new OdbcCommand(SQL_INSERT_UPDATE_DELETE, _odbcConexion);
                        _rowsAfectados = _odbcCommand.ExecuteNonQuery();
                        break;
                }
            }
            catch (Exception ex)
            {
                _bool = true; //si ocurre algún error.. entra a está parte.. y guardo el error en la Variable.. "ERRORDB"
                ERRORDB = ex.Message;
                CapturarError(BasedeDatos, true, false);//me estás siguiendo?SI, ve a la definición de este método
                                                        // MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (!_bool)
                {
                    CapturarError(BasedeDatos, false, false);
                }
            }
            return _rowsAfectados;
        }
        public bool EjecutarComando(string SQL_INSERT_UPDATE_DELETE, object[] ListaParametros)
        {
            _bool = false;
            int contador = 1;
            try
            {
                switch (BasedeDatos) //Aquí depende de mi Base de datos..
                {
                    case BaseDatos.SQLServer:
                        if (_conexion.State == ConnectionState.Open)
                        {
                            _conexion.Close();
                        }
                        _conexion.Open();
                        _comando = new SqlCommand(SQL_INSERT_UPDATE_DELETE, _conexion);
                        foreach (object parm in ListaParametros)
                        {
                            _comando.Parameters.Add("?" + contador.ToString(), parm);
                            contador++;
                        }
                        _comando.ExecuteNonQuery();
                        break;

                    case BaseDatos.MySQL:
                        if (_mysqlConexion.State == ConnectionState.Open)
                        {
                            _mysqlConexion.Close();
                        }
                        _mysqlConexion.Open(); //Abro mi conexión 
                        _mysqlComando = new MySqlCommand(SQL_INSERT_UPDATE_DELETE, _mysqlConexion); //aquí Instancio mi objeto de comando de Mysql.. y le digo que comando ejecutará.. y en que conexión lo hará.
                        foreach (object parm in ListaParametros)
                        {
                            //_mysqlComando.Parameters.Add("?" + contador.ToString(), parm);
                            contador++;
                        }
                        _mysqlComando.ExecuteNonQuery(); //Aquí se ejecuta el SQL que yo le mande.. y usa mi conexión.
                        break;

                    case BaseDatos.Progress:
                        if (_odbcConexion.State == ConnectionState.Open)
                        {
                            _odbcConexion.Close();
                        }
                        _odbcConexion.Open();
                        _odbcCommand = new OdbcCommand(SQL_INSERT_UPDATE_DELETE, _odbcConexion);
                        foreach (object parm in ListaParametros)
                        {
                            _odbcCommand.Parameters.Add("?" + contador.ToString(), parm);
                            contador++;
                        }
                        _odbcCommand.ExecuteNonQuery();
                        break;
                }
                _bool = true;
            }
            catch (Exception ex)
            {
                _bool = false; //si ocurre algún error.. entra a está parte.. y guardo el error en la Variable.. "ERRORDB"
                ERRORDB = ex.Message;
                CapturarError(BasedeDatos, true, false);//me estás siguiendo?SI, ve a la definición de este método
                                                        // MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (_bool)
                {
                    CapturarError(BasedeDatos, false, false);
                }
            }
            return _bool;
        }
        public bool TranEjecutarComando(string SQL_INSERT_UPDATE_DELETE, object[] ListaParametros)
        {
            _bool = false;
            int contador = 1;
            try
            {
                switch (BasedeDatos) //Aquí depende de mi Base de datos..
                {
                    case BaseDatos.SQLServer:

                        _comando.CommandText = SQL_INSERT_UPDATE_DELETE;
                        foreach (object parm in ListaParametros)
                        {
                            _comando.Parameters.Add("?" + contador.ToString(), parm);
                            contador++;
                        }
                        if (_comando.ExecuteNonQuery() > 0)
                        {
                            _bool = true;
                        }
                        break;

                    case BaseDatos.MySQL:

                        _mysqlComando.CommandText = SQL_INSERT_UPDATE_DELETE; //aquí Instancio mi objeto de comando de Mysql.. y le digo que comando ejecutará.. y en que conexión lo hará.
                        foreach (object parm in ListaParametros)
                        {
                            if (contador == 1 && _mysqlComando.Parameters.Count == 1)
                            {
                                _mysqlComando.Parameters.Clear();
                            }
                            //_mysqlComando.Parameters.Add("?" + contador.ToString(), parm);
                            contador++;
                        }
                        if (_mysqlComando.ExecuteNonQuery() > 0)
                        {
                            _bool = true;
                        }//Aquí se ejecuta el SQL que yo le mande.. y usa mi conexión.
                        break;

                    case BaseDatos.Progress:

                        _odbcCommand.CommandText = SQL_INSERT_UPDATE_DELETE;
                        foreach (object parm in ListaParametros)
                        {
                            _odbcCommand.Parameters.Add("?" + contador.ToString(), parm);
                            contador++;
                        }
                        if (_odbcCommand.ExecuteNonQuery() > 0)
                        {
                            _bool = true;
                        }
                        break;
                }
                _bool = true;
            }
            catch (Exception ex)
            {
                _bool = false; //si ocurre algún error.. entra a está parte.. y guardo el error en la Variable.. "ERRORDB"
                ERRORDB = ex.Message;
                CapturarError(BasedeDatos, true, true);//me estás siguiendo?SI, ve a la definición de este método
                                                       // MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (_bool)
                {
                    CapturarError(BasedeDatos, false, true);
                }
                else
                {
                    CapturarError(BasedeDatos, true, true);
                }
            }
            return _bool;
        }
        /// <summary>
        /// Se debe enviar la sentencia SELECT con los nombres de los campos que se desea obtener, recuerda limitar tu sentencia con UN SOLO REGISTRO, para que no tarde en recuperar la tabla, recuerda que por el momento solo nos interesa el Esquema de la tabla. 0 = SQL , 1 = ODBC , 2 = MYSQL
        /// </summary>
        /// <param name="SQL_SELECT"></param>
        /// <returns></returns>
        public Boolean GetSchemaTable(string SQL_SELECT, ref DataTable DTConexion)
        {
            //DTConexion = null;
            _bool = false;
            try
            {
                switch (BasedeDatos)
                {
                    case BaseDatos.SQLServer:
                        if (_conexion.State == ConnectionState.Open)
                        {
                            _conexion.Close();
                        }
                        _conexion.Open();
                        _comando = new SqlCommand(SQL_SELECT, _conexion);
                        _reader = _comando.ExecuteReader();
                        DTConexion = _reader.GetSchemaTable();
                        break;

                    case BaseDatos.Progress:
                        if (_odbcConexion.State == ConnectionState.Open)
                        {
                            _odbcConexion.Close();
                        }
                        _odbcConexion.Open();
                        _odbcCommand = new OdbcCommand(SQL_SELECT, _odbcConexion);
                        _odbcReader = _odbcCommand.ExecuteReader();
                        DTConexion = _odbcReader.GetSchemaTable();
                        break;

                    case BaseDatos.MySQL:
                        if (_mysqlConexion.State == ConnectionState.Open)
                        {
                            _mysqlConexion.Close();
                        }
                        _mysqlConexion.Open();
                        _mysqlComando = new MySqlCommand(SQL_SELECT, _mysqlConexion);
                        _mysqlReader = _mysqlComando.ExecuteReader();
                        DTConexion = _mysqlReader.GetSchemaTable();
                        break;
                }
                _bool = true;
            }
            catch (Exception ex)
            {
                _bool = false;
                ERRORDB = ex.Message;
                CapturarError(BasedeDatos, true, false);
            }
            finally
            {
                if (_bool)
                {
                    CapturarError(BasedeDatos, false, false);
                }
            }
            return _bool;
        }
        /// <summary>
        /// Retorna un Objecto (object) con el dato solicitado, en caso de error retorna un Object = null y guarda el error en la propiedad ERRORDB
        /// </summary>
        /// <returns></returns>
        public Object EjecutarScalar(string SENTENCIA_SQL)
        {
            _bool = false;
            Object Resultado = null;
            try
            {
                switch (BasedeDatos)
                {
                    case BaseDatos.SQLServer:
                        if (_conexion.State == ConnectionState.Open)
                        {
                            _conexion.Close();
                        }
                        _conexion.Open();
                        _comando = new SqlCommand(SENTENCIA_SQL, _conexion);
                        Resultado = _comando.ExecuteScalar();
                        break;

                    case BaseDatos.Progress:
                        if (_odbcConexion.State == ConnectionState.Open)
                        {
                            _odbcConexion.Close();
                        }
                        _odbcConexion.Open();
                        _odbcCommand = new OdbcCommand(SENTENCIA_SQL, _odbcConexion);
                        Resultado = _odbcCommand.ExecuteScalar();
                        break;

                    case BaseDatos.MySQL:
                        if (_mysqlConexion.State == ConnectionState.Open)
                        {
                            _mysqlConexion.Close();
                        }
                        _mysqlConexion.Open();
                        _mysqlComando = new MySqlCommand(SENTENCIA_SQL, _mysqlConexion);
                        Resultado = _mysqlComando.ExecuteScalar();
                        break;
                }
            }
            catch (Exception ex)
            {
                _bool = true;
                ERRORDB = ex.Message;
                CapturarError(BasedeDatos, true, false);
            }
            finally
            {
                if (!_bool)
                {
                    CapturarError(BasedeDatos, false, false);
                }
            }

            return Resultado;
        }
        /// <summary>
        /// Retorna true, si la transacción empieza de forma adecuada, false en caso contrario y en la propiedad ERRORDB se guarda el error obtenido.
        /// </summary>
        /// <returns></returns>
        public Boolean TransaccionEmpezar()
        {
            bool Resp = false;
            _bool = false;
            try
            {
                switch (BasedeDatos)
                {
                    case BaseDatos.SQLServer:
                        if (_conexion.State == ConnectionState.Open)
                        {
                            _conexion.Close();
                        }
                        this._conexion.Open();
                        this._transaccion = this._conexion.BeginTransaction();
                        this._comando = new SqlCommand();
                        this._comando.Connection = this._conexion;
                        this._comando.Transaction = this._transaccion;
                        Resp = true;
                        break;

                    case BaseDatos.MySQL:
                        if (_mysqlConexion.State == ConnectionState.Open)
                        {
                            _mysqlConexion.Close();
                        }
                        this._mysqlConexion.Open();
                        this._mysqlTransaccion = this._mysqlConexion.BeginTransaction();
                        this._mysqlComando = new MySqlCommand();
                        this._mysqlComando.Connection = this._mysqlConexion;
                        this._mysqlComando.Transaction = this._mysqlTransaccion;
                        Resp = true;
                        break;

                    case BaseDatos.Progress:
                        if (_odbcConexion.State == ConnectionState.Open)
                        {
                            _odbcConexion.Close();
                        }
                        this._odbcConexion.Open();
                        this._odbcTransaccion = this._odbcConexion.BeginTransaction();
                        this._odbcCommand = new OdbcCommand();
                        this._odbcCommand.Connection = this._odbcConexion;
                        this._odbcCommand.Transaction = this._odbcTransaccion;
                        Resp = true;
                        break;

                }
            }
            catch (Exception ex)
            {
                Resp = false;
                ERRORDB = ex.Message.ToString();
                CapturarError(BasedeDatos, true, true);
            }
            return Resp;
        }
        /// <summary>
        /// Retorna un DataTable con los datos solicitados, en caso de error retorna un DataTable = null y guarda el error en la propiedad ERRORDB
        /// </summary>
        /// <param name="SQL_SELECT_TRAMSACCIONES"></param>
        /// <returns></returns>
        public Boolean TranLlenarDataTable(string SQL_SELECT_TRANSACCIONES, ref DataTable DTConexion)
        {
            DTConexion = new DataTable();
            _bool = false;
            try
            {
                switch (BasedeDatos)
                {
                    case BaseDatos.SQLServer:
                        _comando.CommandText = SQL_SELECT_TRANSACCIONES;
                        _adaptador = new SqlDataAdapter(_comando);
                        _adaptador.Fill(DTConexion);
                        break;

                    case BaseDatos.MySQL:
                        _mysqlComando.CommandText = SQL_SELECT_TRANSACCIONES;
                        _mysqlAdaptador = new MySqlDataAdapter(_mysqlComando);
                        _mysqlAdaptador.Fill(DTConexion);
                        break;

                    case BaseDatos.Progress:
                        _odbcCommand.CommandText = SQL_SELECT_TRANSACCIONES;
                        _odbcAdataptador = new OdbcDataAdapter(_odbcCommand);
                        _odbcAdataptador.Fill(DTConexion);
                        break;
                }
                _bool = true;
            }
            catch (Exception ex)
            {
                _bool = false;
                ERRORDB = ex.Message.ToString();
                CapturarError(BasedeDatos, true, true);
            }

            return _bool;
        }

        /// <summary>
        /// (Transacción)Retorna un Objecto (object) con el dato solicitado, en caso de error retorna un Object = null y guarda el error en la propiedad ERRORDB
        /// </summary>
        /// <param name="SQL_SELECT"></param>
        /// <returns></returns>
        public Boolean TranEjecutarScalar(string SQL_SELECT, ref Object Resultado)
        {
            _bool = false;
            try
            {
                switch (BasedeDatos)
                {
                    case BaseDatos.SQLServer:
                        _comando.CommandText = SQL_SELECT;
                        Resultado = _comando.ExecuteScalar();
                        break;
                    case BaseDatos.MySQL:
                        _mysqlComando.CommandText = SQL_SELECT;
                        Resultado = _mysqlComando.ExecuteScalar();
                        break;
                    case BaseDatos.Progress:
                        _odbcCommand.CommandText = SQL_SELECT;
                        Resultado = _odbcCommand.ExecuteScalar();
                        break;
                }
                if (Resultado == null)
                {
                    // throw new Exception("Error al ejecutar TranEjecutarScalar()");
                    _bool = true;
                }
                else
                {
                    _bool = true;
                }
            }
            catch (Exception ex)
            {
                _bool = false;
                ERRORDB = ex.Message.ToString();
                CapturarError(BasedeDatos, true, true);
            }
            return _bool;
        }
        /// <summary>
        /// Ejecuta un comando dentro de una transacción, si retorna false entonces ocurrio algún error en la transacción.
        /// </summary>
        /// <param name="SENTENCIA_INSERT_UPDATE_DETELE"></param>
        /// <returns></returns>
        public Boolean TranEjecutarComando(string SENTENCIA_INSERT_UPDATE_DETELE)
        {
            bool Resp = false;
            try
            {
                switch (BasedeDatos)
                {
                    case BaseDatos.SQLServer:
                        this._comando.CommandText = SENTENCIA_INSERT_UPDATE_DETELE;
                        if (this._comando.ExecuteNonQuery() >= 0)
                        {
                            Resp = true;
                        }
                        break;
                    case BaseDatos.MySQL:
                        this._mysqlComando.CommandText = SENTENCIA_INSERT_UPDATE_DETELE;
                        if (this._mysqlComando.ExecuteNonQuery() >= 0)
                        {
                            Resp = true;
                        }
                        break;
                    case BaseDatos.Progress:
                        this._odbcCommand.CommandText = SENTENCIA_INSERT_UPDATE_DETELE;
                        if (this._odbcCommand.ExecuteNonQuery() >= 0)
                        {
                            Resp = true;
                        }
                        break;
                }
                //if (!Resp)
                //{
                //    //ERRORDB = "Error al guardar los contactos.";
                //}
            }
            catch (Exception ex)
            {
                Resp = false;
                ERRORDB = ex.Message.ToString();
                CapturarError(BasedeDatos, true, true);
            }
            return Resp;
        }
        /// <summary>
        /// Finaliza la transacción, si no ocurrió ningún  error retorna True, en caso contrario envia False
        /// </summary>
        /// <returns></returns>
        public Boolean TransaccionFinalizar()
        {
            bool Resp = false;
            try
            {
                switch (BasedeDatos)
                {
                    case BaseDatos.SQLServer:
                        this._transaccion.Commit();
                        break;

                    case BaseDatos.MySQL:
                        if (_mysqlConexion != null)
                        {
                            this._mysqlTransaccion.Commit();
                        }
                        break;

                    case BaseDatos.Progress:
                        this._odbcTransaccion.Commit();
                        break;
                }
                Resp = true;
            }
            catch (Exception ex)
            {
                Resp = true;
                ERRORDB = ex.Message.ToString();
                CapturarError(BasedeDatos, true, true);
            }
            return Resp;
        }
        public bool TransaccionRollBack()
        {
            if (_mysqlTransaccion != null)
            {
                this._mysqlTransaccion.Rollback();
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            System.Diagnostics.Debug.Print("Destruyendo objeto");
            if (_mysqlConexion.State == ConnectionState.Open)
            {
                _mysqlConexion.Close();
            }
            _mysqlConexion = null;
            _mysqlAdaptador = null;
            _mysqlComando = null;
            _mysqlTransaccion = null;
        }
        #endregion
    }
}
