using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Empleado
    {
        public int IDEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

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
