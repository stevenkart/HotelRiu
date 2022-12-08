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
        public bool Agregar()//agregar el hospedaje en estado pendiente por facturar
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
            MiCnn.ListaParametros.Add(new SqlParameter("@IDPaquete", this.MiPaquete.IDPaquete));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDHabitacion", this.MiHabitacion.IDHabitacion));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDCliente", this.MiCliente.IDCliente));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEstado", 5));
           

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
            MiCnn.ListaParametros.Add(new SqlParameter("@IDPaquete", this.MiPaquete.IDPaquete));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDCliente", this.MiCliente.IDCliente));
            

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos

            MiCnn.ListaParametros.Add(new SqlParameter("@IDHabitacion", this.MiHabitacion.IDHabitacion));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEstado", 5));


            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDHospedaje));

            
            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPHospedajeModificar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;

        }
        public bool Eliminar()//CAMBIA EL ESTADO A CANCELADO SI EL HOSPEDAJE ESTABA **PENDIENTE**
        {
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos compuestos heredados de otra clase
            // para el INSERT en la basedatos

            MiCnn.ListaParametros.Add(new SqlParameter("@IDHabitacion", this.MiHabitacion.IDHabitacion));

            MiCnn.ListaParametros.Add(new SqlParameter("@IDEstado", 7));


            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDHospedaje));


            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPHospedajeEliminar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;

        }
        public Hospedaje ConsultarPorID()
        {
            Hospedaje R = new Hospedaje();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDHospedaje));

            DataTable DataHospedaje = new DataTable();

            DataHospedaje = MiCnn.EjecutarSelect("SPHospedajeConsultarPorID");

            if (DataHospedaje != null && DataHospedaje.Rows.Count > 0)
            {
                DataRow Fila = DataHospedaje.Rows[0];

                R.IDHospedaje = Convert.ToInt32(Fila["IDHospedaje"]);
                R.Cant_Ninos = Convert.ToInt32(Fila["Cant_ninos"]);
                R.Cant_Adultos = Convert.ToInt32(Fila["Cant_adultos"]);
                R.DiasHospedaje = Convert.ToInt32(Fila["DiasHospedaje"]);
                R.FechaEntrada = Convert.ToDateTime(Fila["FechaEntrada"]);
                R.FechaSalida = Convert.ToDateTime(Fila["FechaSalida"]);
                R.Total = (float) Convert.ToDouble(Fila["Total"]);
                R.MiPaquete.IDPaquete = Convert.ToInt32(Fila["IDPaquete"]);
                R.MiHabitacion.IDHabitacion = Convert.ToInt32(Fila["IDHabitacion"]);
                R.MiCliente.IDCliente = Convert.ToInt32(Fila["IDCliente"]);
                R.MiEstado.IDEstado = Convert.ToInt32(Fila["IDEstado"]);
            }

            return R;
        }

        public DataTable Listar(string FiltroBusqueda = "", bool Cancelados = true) // VA A MOSTRAR CANCELADOS O PENDIENTE
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();


            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cancelados", Cancelados));

            R = MiCnn.EjecutarSelect("SPHospedajeListar");

            return R;

        }

        public DataTable ListarPendientes(string FiltroBusqueda = "", bool Cancelados = true) // VA A MOSTRAR PENDIENTES 
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();


            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cancelados", Cancelados));

            R = MiCnn.EjecutarSelect("SPHospedajeListarPendientes");

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
