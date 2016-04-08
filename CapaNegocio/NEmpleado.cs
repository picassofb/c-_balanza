using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NEmpleado
    {
        public static DataTable ListarEmpleados()
        {
            return new DEmpleado().ListarEmpleados();
        }

        public static DataTable BuscarPorId(string idBuscado)
        {
            DEmpleado empleado = new DEmpleado();
            empleado.idbuscado = idBuscado;
            return empleado.Buscar(empleado);
        }

        public static   String Insertar(String parNombres, String parApellidos,
                        String parSexo, String parFechaNac, String parCiRuc, String parDireccion,
                        String parTelefono, String parEmail)
        {
            DEmpleado empleado = new DEmpleado();
            empleado.nombres = parNombres;
            empleado.apellidos = parApellidos;
            empleado.sexo = parSexo;
            empleado.fecha_nac = parFechaNac;
            empleado.ci_ruc = parCiRuc;
            empleado.direccion = parDireccion;
            empleado.telefono = parTelefono;
            empleado.email = parEmail;

            return empleado.Insertar(empleado);
        }
    }
}