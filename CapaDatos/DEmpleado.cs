using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEmpleado
    {
        //Getters & Setters
        public string idempleado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public string fecha_nac { get; set; }
        public string ci_ruc { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string acceso { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        public string idbuscado { get; set; }


        // Constructores
        public DEmpleado()
        {
        }

        public DEmpleado(string par_idempleado,string par_nombres, string par_apellidos, string par_sexo, string par_estado_civil, 
                         string par_fecha_nac, string par_ci_ruc, string par_direccion, string par_telefono, string par_email, 
                         string par_acceso, string par_usuario,string par_password,string par_idbuscado)
        {
            this.idempleado = par_idempleado;
            this.nombres = par_nombres;
            this.apellidos = par_apellidos;
            this.sexo = par_sexo;
            this.estado_civil = par_estado_civil;
            this.fecha_nac = par_fecha_nac;
            this.ci_ruc = par_ci_ruc;
            this.direccion = par_direccion;
            this.telefono = par_telefono;
            this.email = par_email;
            this.acceso = par_acceso;
            this.usuario = par_usuario;
            this.password = par_password;
            this.idbuscado = par_idbuscado;
        }


        //Metodos

        public DataTable ListarEmpleados()
        {
            DataTable TablaDatos = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();
            
            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT * FROM empleado"; // Cambiar por procedimientos o Entity Framework...
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptador = new SqlDataAdapter(SqlCmd);
                SqlAdaptador.Fill(TablaDatos);

             } 
            catch(Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al ejecutar consulta \"Listar Empleados\" " + ex.Message, ex);
            }   
            finally
            {
                SqlCon.Close();
            }

            return TablaDatos;
        }

        public DataTable Buscar(DEmpleado parEmpleado)
        {
            DataTable TablaDatos = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT * FROM empleado WHERE idempleado = " + idbuscado.ToString(); // Cambiar por procedimientos o Entity Framework...
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptador = new SqlDataAdapter(SqlCmd);
                SqlAdaptador.Fill(TablaDatos);

            }
            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al ejecutar consulta \"Listar Empleados\" " + ex.Message, ex);
            }
            finally
            {
                SqlCon.Close();
            }

            return TablaDatos;
        }

        public string Insertar(DEmpleado parametroEmpleado)
        {
            string respuesta = string.Empty;
            SqlConnection sqlConexion = new SqlConnection();

            try
            {
                sqlConexion.ConnectionString = DConexion.Cn;
                sqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = sqlConexion;
                SqlComando.CommandText = "  insert into empleado(nombres,apellidos,sexo,fecha_nac," +
                                            "ci_ruc,direccion,telefono,email)" +
                                            "values(@nombres, @apellidos, @sexo, @fecha_nac," +
                                            "@ci_ruc, @direccion, @telefono, @email)";

                SqlComando.Parameters.AddWithValue("@nombres", parametroEmpleado.nombres);
                SqlComando.Parameters.AddWithValue("@apellidos", parametroEmpleado.apellidos);
                SqlComando.Parameters.AddWithValue("@sexo", parametroEmpleado.sexo);
                SqlComando.Parameters.AddWithValue("@fecha_nac", parametroEmpleado.fecha_nac);
                SqlComando.Parameters.AddWithValue("@ci_ruc", parametroEmpleado.ci_ruc);
                SqlComando.Parameters.AddWithValue("@direccion", parametroEmpleado.direccion);
                SqlComando.Parameters.AddWithValue("@telefono", parametroEmpleado.telefono);
                SqlComando.Parameters.AddWithValue("@email", parametroEmpleado.email);

                SqlComando.ExecuteNonQuery();
                respuesta = "Y";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 2627)
                {
                    respuesta = "Ya existe un cliente con ese Nombre";
                }
                else if (ex.Number == 515)
                {
                    respuesta = "Sólo puedes dejar vacíos los campos Nombre de Contacto, Región, País, Teléfono, Fax y Email";
                }
                else
                {
                    respuesta = "Error al intentar ejecutar la insercion del empleado. " + ex.Message;
                }
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open) {
                    sqlConexion.Close();
                }
            }

            return respuesta;
        }
    }
}
