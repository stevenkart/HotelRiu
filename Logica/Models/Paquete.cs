using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Paquete
    {

        public int IDPaquete { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Gastronomia { get; set; }
        public bool ServicioSpa { get; set; }
        public bool Tour4x4 { get; set; }
        public float Precio { get; set; }


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
