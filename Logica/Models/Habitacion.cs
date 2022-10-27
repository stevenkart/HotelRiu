using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Habitacion
    {
        public int IDHabitacion { get; set; }
        public bool Jacuzzi { get; set; }
        public float Precio { get; set; }
        public bool Cama_Matrimonial { get; set; }
        public int Cantidad_Cama { get; set; }
        public bool Aire_Acondicionado { get; set; }

        public Estado MiEstado { get; set; }


        public Habitacion()
        {
            MiEstado = new Estado();
  

        }


        //Ahora se escribe las funciones y metodos(operaciones)
        public bool Agregar()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //INSERT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

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
