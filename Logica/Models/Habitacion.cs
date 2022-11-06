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
