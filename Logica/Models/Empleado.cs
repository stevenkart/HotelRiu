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

            // lista de atributos simples para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Apellidos", this.Apellidos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Correo", this.Correo));
            MiCnn.ListaParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEstado", this.MiEstado.IDEstado));
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

        public DataTable ListarPorCedula(string Cedula)
        {
            //TODO usar SP con parametros para ver Ocupaciones 
            DataTable R = new DataTable();

            return R;




        }

        public DataTable Listar()
        {
            //TODO usar SP con parametros para ver Ocupaciones 
            DataTable R = new DataTable();

            return R;




        }


    }
}
