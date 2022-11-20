using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Ocupacion
    {

        //Primero Escribimos las Propiedades Simples
        public int IDOcupacion { get; set; }
        public string DescripcionRol { get; set; }

        //Ahora se escribe las funciones y metodos(operaciones)
        public bool Agregar()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //INSERT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;


            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos para el Procedimiento
            MiCnn.ListaParametros.Add(new SqlParameter("@DescripcionRol", this.DescripcionRol));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPOcupacionAgregar");

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

            // lista de atributos para el Procedimiento
            MiCnn.ListaParametros.Add(new SqlParameter("@DescripcionRol", this.DescripcionRol));
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDOcupacion));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPOcupacionModificar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }
        public bool Eliminar()
        {
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos para el Procedimiento
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDOcupacion));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPOcupacionEliminar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }


        public DataTable Listar(string FiltroBusqueda = "")
        {
            //TODO usar SP con parametros para ver Ocupaciones 
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSelect("SPOcupacionListar");

            return R;
        }

        public Ocupacion ConsultarPorID()
        {
            Ocupacion R = new Ocupacion();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDOcupacion));

            DataTable DataOcupacion = new DataTable();

            DataOcupacion = MiCnn.EjecutarSelect("SPOcupacionConsultarPorID");

            if (DataOcupacion != null && DataOcupacion.Rows.Count > 0)
            {
                DataRow Fila = DataOcupacion.Rows[0];

                R.IDOcupacion = Convert.ToInt32(Fila["IDOcupacion"]);
                R.DescripcionRol = Convert.ToString(Fila["DescripcionRol"]);
            }

            return R;
        }


        public DataTable Listar()
        {
            
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

        

            R = MiCnn.EjecutarSelect("SPOcupacionLista");

            return R;
        }



        public int ConsultarPorOcupacion(string pDescripcionRol)
        {
            int R = 0;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@DescripcionRol", pDescripcionRol));

            DataTable respuesta = MiCnn.EjecutarSelect("SPOcupacionConsultarPorOcupacion");

            if (respuesta.Rows.Count > 0)
            {
                R = 1;
            }

            return R;
        }
    }
}
