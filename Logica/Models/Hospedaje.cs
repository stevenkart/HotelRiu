using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos simples para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@Cant_Ninos", this.Cant_Ninos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cant_Adultos", this.Cant_Adultos));
            MiCnn.ListaParametros.Add(new SqlParameter("@DiasHospedaje", this.DiasHospedaje));
            MiCnn.ListaParametros.Add(new SqlParameter("@FechaEntrada", this.FechaEntrada));
            MiCnn.ListaParametros.Add(new SqlParameter("@FechaSalida", this.FechaSalida));
            MiCnn.ListaParametros.Add(new SqlParameter("@Total", this.Total));

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEstado", this.MiEstado.IDEstado));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDHabitacion", this.MiHabitacion.IDHabitacion));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDPaquete", this.MiPaquete.IDPaquete));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDCliente", this.MiCliente.IDCliente));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPHospedajeAgregar");

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


        public DataTable ListarPorFechas(DateTime FechaInicial, DateTime FechaFinal)
        {
            //TODO usar SP con parametros para ver las fechas de inicio y final
            DataTable R = new DataTable();

            return R;
        }



    }
}
