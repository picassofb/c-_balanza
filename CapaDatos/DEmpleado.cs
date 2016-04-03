using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    class DEmpleado
    {
        //Getters & Setters
        public int idempleado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public DateTime fecha_nac { get; set; }
        public string ci_ruc { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string acceso { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        
        // Constructores
        public DEmpleado()
        {
        }

        public DEmpleado(int par_idempleado,string par_nombres, string par_apellidos, string par_sexo, string par_estado_civil, 
                         DateTime par_fecha_nac, string par_ci_ruc, string par_direccion, string par_telefono, string par_email, 
                         string par_acceso, string par_usuario,string par_password)
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
        }

        //Metodos

        public DataTable ListarEmpleados()
        {
            
        }
    }
}
