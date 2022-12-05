using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Habitacion
    {
        //atributos simples
        public int IDHabitacion { get; set; }
        public bool Jacuzzi { get; set; }
        public float Precio { get; set; }
        public bool Cama_Matrimonial { get; set; }
        public int Cantidad_Cama { get; set; } // atributo representa la cantidad de camas de la habitacion
        public bool Aire_Acondicionado { get; set; }

        //atributos compuestos
        //heredados de otras clases
        public Estado MiEstado { get; set; }

        //constructor se incluyen los BOOLEANS 
        //porque no agregarles valor podria afectar
        //el funcionamiento del sistema
        public Habitacion()
        {
            MiEstado = new Estado();
            Jacuzzi = true;
            Cama_Matrimonial = true;
            Aire_Acondicionado = true;
        }


        //Ahora se escribe las funciones y metodos(operaciones)
        public bool Agregar()
        {
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos simples para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@Jacuzzi", this.Jacuzzi));
            MiCnn.ListaParametros.Add(new SqlParameter("@Precio", this.Precio));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cama_Matrimonial", this.Cama_Matrimonial));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cantidad_Cama", this.Cantidad_Cama));
            MiCnn.ListaParametros.Add(new SqlParameter("@Aire_Acondicionado", this.Aire_Acondicionado));

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEstado", this.MiEstado.IDEstado));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPHabitacionAgregar");

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
            MiCnn.ListaParametros.Add(new SqlParameter("@Jacuzzi", this.Jacuzzi));
            MiCnn.ListaParametros.Add(new SqlParameter("@Precio", this.Precio));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cama_Matrimonial", this.Cama_Matrimonial));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cantidad_Cama", this.Cantidad_Cama));
            MiCnn.ListaParametros.Add(new SqlParameter("@Aire_Acondicionado", this.Aire_Acondicionado));

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEstado", this.MiEstado.IDEstado));
            
            
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDHabitacion));


            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPHabitacionModificar");

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

            //ID HABITACION
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDHabitacion));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPHabitacionEliminar");

            if (Resultado > 0)
            {
                R = true;
            }
            return R;
        }

        //ESTE METODO de consultor RETORNA UN OBJETO de tipo HABITACION
        public Habitacion ConsultarPorID()
        {
            Habitacion R = new Habitacion();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDHabitacion));

            DataTable DataHabitacion = new DataTable();

            DataHabitacion = MiCnn.EjecutarSelect("SPHabitacionConsultarPorID");

            if (DataHabitacion != null && DataHabitacion.Rows.Count > 0)
            {
                DataRow Fila = DataHabitacion.Rows[0];

                R.IDHabitacion = Convert.ToInt32(Fila["IDHabitacion"]);
                R.Jacuzzi = Convert.ToBoolean(Fila["Jacuzzi"]);
                R.Precio = (float)Convert.ToDouble(Fila["Precio"]);
                R.Cama_Matrimonial = Convert.ToBoolean(Fila["Cama_Matrimonial"]);
                R.Cantidad_Cama = Convert.ToInt32(Fila["Cantidad_cama"]);
                R.Aire_Acondicionado = Convert.ToBoolean(Fila["Aire_Acondicionado"]);
                R.MiEstado.IDEstado = Convert.ToInt32(Fila["IDEstado"]);
            }

            return R;

        }

       
        public DataTable Listar(string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSelect("SPHabitacionListar");

            return R;
        }
        
        /*
        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            //MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSelect("VHabitacionesDisponibles");

            return R;
        }*/

        public DataTable ListarHabitaciones() //retorna la lista de TODOS las habitaciones segun el filtro
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            //MiCnn.ListaParametros.Add(new SqlParameter("@ID", idHabitacion));


            R = MiCnn.EjecutarSelect("SPHabitacionListarHabitaciones");

            return R;
        }

        public Habitacion PrecioHabitacion()
        {
            Habitacion R = new Habitacion();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDHabitacion));

            DataTable DataHabitacion = new DataTable();

            DataHabitacion = MiCnn.EjecutarSelect("SPHabitacionObtenerPrecio");

            if (DataHabitacion != null && DataHabitacion.Rows.Count > 0)
            {
                DataRow Fila = DataHabitacion.Rows[0];

                R.Precio = (float)Convert.ToDouble(Fila["Precio"]);
            }

            return R;

        }

    }
}
