using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Estado
    {

        //Primero Escribimos las Propiedades Simples
        public int IDEstado { get; set; }
        public string NombreEstado { get; set; }



        //Ahora se escribe las funciones y metodos(operaciones)

        public DataTable Listar() //retorna la lista de TODOS estados
        {
            DataTable R = new DataTable();

           
            Conexion MiCnn = new Conexion();

   

            R = MiCnn.EjecutarSelect("SPUsuarioRolListar");





            return R;
        }

        public DataTable ListarEstadosUsuarios() //retorna la lista de TODOS estados USUARIOS
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPEstadosUsuarios");

            return R;
        }

        public DataTable ListarEstadosHabitaciones() //retorna la lista de TODOS estados Habitaciones
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPEstadosHabitaciones");

            return R;
        }



    }
}
