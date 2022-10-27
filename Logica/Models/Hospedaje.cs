using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Hospedaje
    {

        public int IDHospedaje { get; set; }
        public int Cant_Ninos { get; set; }
        public int Cant_Adultos { get; set; }
        public int DiasHospedaje { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public float Total { get; set; }


        public Estado MiEstado { get; set; }
        public Habitacion MiHabitacion { get; set; }
        public Paquete MiPaquete { get; set; }
        public Cliente MiCliente { get; set; }



        public Hospedaje()
        {
            MiEstado = new Estado();
            MiHabitacion = new Habitacion();
            MiPaquete = new Paquete();
            MiCliente = new Cliente();


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


        public DataTable ListarPorFechas(DateTime FechaInicial, DateTime FechaFinal)
        {
            //TODO usar SP con parametros para ver las fechas de inicio y final
            DataTable R = new DataTable();

            return R;
        }



    }
}
