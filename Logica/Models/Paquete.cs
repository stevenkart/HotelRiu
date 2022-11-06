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


        public DataTable Listar()
        {
            //TODO usar SP con parametros para ver Ocupaciones 
            DataTable R = new DataTable();

            return R;




        }
    }
}
