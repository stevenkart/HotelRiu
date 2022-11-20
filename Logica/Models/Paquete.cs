using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Paquete
    {
        //atributos simples
        public int IDPaquete { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Gastronomia { get; set; }
        public bool ServicioSpa { get; set; }
        public bool Tour4x4 { get; set; }
        public float Precio { get; set; }

        //constructor para darle un valor  a los boolean
        //de lo contrario puede dar problemas
        public Paquete()
        {
            Gastronomia = true;
            ServicioSpa = true;
            Tour4x4 = true;
        }

        //Ahora se escribe las funciones y metodos(operaciones)
        public bool Agregar()
        {
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos simples para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCnn.ListaParametros.Add(new SqlParameter("@Gastronomia", this.Gastronomia));
            MiCnn.ListaParametros.Add(new SqlParameter("@ServicioSpa", this.ServicioSpa));
            MiCnn.ListaParametros.Add(new SqlParameter("@Tour4x4", this.Tour4x4));
            MiCnn.ListaParametros.Add(new SqlParameter("@Precio", this.Precio));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPPaqueteAgregar");

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
            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCnn.ListaParametros.Add(new SqlParameter("@Gastronomia", this.Gastronomia));
            MiCnn.ListaParametros.Add(new SqlParameter("@ServicioSpa", this.ServicioSpa));
            MiCnn.ListaParametros.Add(new SqlParameter("@Tour4x4", this.Tour4x4));
            MiCnn.ListaParametros.Add(new SqlParameter("@Precio", this.Precio));

            
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDPaquete));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPPaqueteModificar");

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

            //ID PAQUETE
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDPaquete));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPPaqueteEliminar");

            if (Resultado > 0)
            {
                R = true;
            }
            return R;
        }

        //ESTE METODO de consultor RETORNA UN OBJETO de tipo HABITACION
        public Paquete ConsultarPorID()
        {
            Paquete R = new Paquete();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDPaquete));

            DataTable DataPaquete = new DataTable();

            DataPaquete = MiCnn.EjecutarSelect("SPPaqueteConsultarPorID");

            if (DataPaquete != null && DataPaquete.Rows.Count > 0)
            {
                DataRow Fila = DataPaquete.Rows[0];

                R.IDPaquete = Convert.ToInt32(Fila["IDPaquete"]);
                R.Nombre = Convert.ToString(Fila["Nombre"]);
                R.Descripcion = Convert.ToString(Fila["Descripcion"]);
                R.Gastronomia = Convert.ToBoolean(Fila["Gastronomia"]);
                R.ServicioSpa = Convert.ToBoolean(Fila["ServicioSpa"]);
                R.Tour4x4 = Convert.ToBoolean(Fila["Tour4x4"]);
                R.Precio = (float)Convert.ToDouble(Fila["Precio"]);
            }

            return R;

        }



        public DataTable Listar(string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();
        
            Conexion MiCnn = new Conexion();
       
            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSelect("SPPaqueteListar");

            return R;
        }
    }
}
