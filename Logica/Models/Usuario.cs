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

            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos simples para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasenia", this.Contrasenia));

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDUsuario));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioModificar");

            if (resultado > 0)
            {
                R = true;
            }

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


        public Usuario ConsultarPorID()
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDUsuario));

            DataTable DataOcupacion = new DataTable();

            DataOcupacion = MiCnn.EjecutarSelect("SPUsuarioConsultarPorID");

            if (DataOcupacion != null && DataOcupacion.Rows.Count > 0)
            {
                DataRow Fila = DataOcupacion.Rows[0];

                R.IDUsuario = Convert.ToInt32(Fila["IDUsuario"]);
                R.NombreUsuario = Convert.ToString(Fila["NombreUsuario"]);
                R.Contrasenia = Convert.ToString(Fila["Contrasenia"]);

                R.MiEmpleado.IDEmpleado = Convert.ToInt32(Fila["IDEmpleado"]);
            }

            return R;
        }



        public DataTable Listar(string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSelect("SPUsuarioListar");

            return R;
        }

        //listar con el bool sin parametros
        public DataTable ListarInactivos()
        {
            //TODO usar SP con parametros para ver proveedores eliminados o activos
            DataTable R = new DataTable();

            return R;
        }

        public int ValidarLogin(string pNombreUsuario, string pContrasennia)
        {
            int R = 0;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", pNombreUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasenia", pContrasennia));

            DataTable respuesta = MiCnn.EjecutarSelect("SPValidarLogin");

            if (respuesta != null && respuesta.Rows.Count > 0)
            {
                DataRow mifila = respuesta.Rows[0];



                R = Convert.ToInt32(mifila["IDUsuario"]);
            }

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
