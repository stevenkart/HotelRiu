using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Empleado
    {
        //atributos simples
        public int IDEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        //atributos compuestos
        //heredados de otras clases
        public Estado MiEstado { get; set; }
        public Ocupacion MiOcupacion { get; set; }  

        public Empleado()
        {
            MiEstado = new Estado();
            MiOcupacion = new Ocupacion();
        }


        //Ahora se escribe las funciones y metodos(operaciones)
        public bool Agregar()
        {
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos simples para el Proceso en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Apellidos", this.Apellidos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Correo", this.Correo));
            MiCnn.ListaParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos

            //MiCnn.ListaParametros.Add(new SqlParameter("@IDEstado", this.MiEstado.IDEstado));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDOcupacion", this.MiOcupacion.IDOcupacion));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPEmpleadoAgregar");

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

            // lista de atributos simples para el Proceso en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Apellidos", this.Apellidos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Correo", this.Correo));
            MiCnn.ListaParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos
            // MiCnn.ListaParametros.Add(new SqlParameter("@IDEstado", this.MiEstado.IDEstado));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDOcupacion", this.MiOcupacion.IDOcupacion));

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDEmpleado));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPEmpleadoModificar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }
        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar la lista parametros para el DELETE

            //ID CLIENTE
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDEmpleado));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPEmpleadoEliminar");

            if (Resultado > 0)
            {
                R = true;


            }
            return R;
        }

        public DataTable ListarPorCedula(string Cedula)
        {
            //TODO usar SP con parametros para ver Ocupaciones 
            DataTable R = new DataTable();

            return R;




        }


        //ESTE METODO de consultor RETORNA UN OBJETO de tipo Empleado
        public Empleado ConsultarPorID()
        {
            Empleado R = new Empleado();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDEmpleado));

            DataTable DataOcupacion = new DataTable();

            DataOcupacion = MiCnn.EjecutarSelect("SPEmpleadoConsultarPorID");

            if (DataOcupacion != null && DataOcupacion.Rows.Count > 0)
            {
                DataRow Fila = DataOcupacion.Rows[0];

                R.IDEmpleado = Convert.ToInt32(Fila["IDEmpleado"]);
                R.Cedula = Convert.ToString(Fila["Cedula"]);
                R.Nombre = Convert.ToString(Fila["Nombre"]);
                R.Apellidos = Convert.ToString(Fila["Apellidos"]);
                R.Correo = Convert.ToString(Fila["Correo"]);
                R.Direccion = Convert.ToString(Fila["Direccion"]);
                R.Telefono = Convert.ToString(Fila["Telefono"]);

                R.MiEstado.IDEstado = Convert.ToInt32(Fila["IDEstado"]);
                R.MiOcupacion.IDOcupacion = Convert.ToInt32(Fila["IDOcupacion"]);
            }

            return R;

        }



        public DataTable Listar(string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSelect("SPEmpleadoListar");

            return R;

        }


        public DataTable ListarEmpleadoSinUsuario()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPEmpleadoListarParaAsignarUsuario");

            return R;

        }

    }
}
