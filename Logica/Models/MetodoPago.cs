using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class MetodoPago
    {

        public int IDMetodoPago { get; set; }
        public string DescripcionMetodo { get; set; }



        //Ahora se escribe las funciones y metodos(operaciones)
        public bool Agregar()
        {
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos simples para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@DescripcionMetodo", this.DescripcionMetodo));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPMetodoPagoAgregar");

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

            // lista de atributos para el Procedimiento
            MiCnn.ListaParametros.Add(new SqlParameter("@DescripcionMetodo", this.DescripcionMetodo));
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDMetodoPago));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPMetodoPagoModificar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;

        }
        public bool Eliminar()
        {
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos para el Procedimiento
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDMetodoPago));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPMetodoPagoEliminar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;

        }

        public MetodoPago ConsultarPorID()
        {
            MetodoPago R = new MetodoPago();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDMetodoPago));

            DataTable DataMetodoPago = new DataTable();

            DataMetodoPago = MiCnn.EjecutarSelect("SPMetodoPagoConsultarPorID");

            if (DataMetodoPago != null && DataMetodoPago.Rows.Count > 0)
            {
                DataRow Fila = DataMetodoPago.Rows[0];

                R.IDMetodoPago = Convert.ToInt32(Fila["IDMetodoPago"]);
                R.DescripcionMetodo = Convert.ToString(Fila["DescripcionMetodo"]);
            }

            return R;
        }

        public int ConsultarPorMetodoPago(string pDescripcionMetodo)
        {
            int R = 0;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@DescripcionMetodo", pDescripcionMetodo));

            DataTable respuesta = MiCnn.EjecutarSelect("SPMetodoPagoConsultarPorMetodoPago");

            if (respuesta.Rows.Count > 0)
            {
                R = respuesta.Rows.Count;
            }

            return R;
        }


        public DataTable Listar()
        {
            //TODO usar SP con parametros para ver METODOS PAGO 
            DataTable R = new DataTable();

            return R;
        }

        public DataTable Lista()
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();



            R = MiCnn.EjecutarSelect("SPMetodoPagoLista");

            return R;
        }

    }
}
