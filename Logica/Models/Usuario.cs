using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        //atributos simples
        public int IDUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public int PinRecuperacion { get; set; }

        //atributos compuestos
        //heredados de otras clases
        public Empleado MiEmpleado { get; set; }


        public Usuario()
        {
            MiEmpleado = new Empleado();
        }


        //Ahora se escribe las funciones y metodos(operaciones)
        public bool Agregar()
        {
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos simples para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasenia", this.Contrasenia));

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEmpleado", this.MiEmpleado.IDEmpleado));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado  = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioAgregar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;

        }
        public bool Modificar()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //UPDATE correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }
        public bool Eliminar()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //DELETE -> UPDATE correspondiente y retornar TRUE si 
            // TODO sale bien
            // SE HACEN ELIMINACIONES LOGICAS, LO QUE HAREMOS SERA CAMBIAR EL VALOR DE CAMPO 
            //ACTIVO A FALSE
            bool R = false;

            return R;

        }


        public bool ConsultarPorNombreUsuario()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO listo ****


            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar 1 parametro al SP DE CONSULTA
            //en el sql parametro se adjunta el parametro de SP
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));

            //ahora se llama el SP 

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarPorNombreUsuario");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;

            }

            return R;

        }


        //listar con el bool sin parametros
        public DataTable ListarActivos()
        {
            //TODO usar SP con parametros para ver proveedores eliminados o activos
            DataTable R = new DataTable();

            return R;
        }

        //listar con el bool sin parametros
        public DataTable ListarInactivos()
        {
            //TODO usar SP con parametros para ver proveedores eliminados o activos
            DataTable R = new DataTable();

            return R;
        }

        public bool ValidarLogin(string NombreUsuario, string Contrasennia)
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }

        public bool EnviarCodigoRecuperacion(string Email)
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }

        public bool ResetearContrasennia()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }








    }
}
