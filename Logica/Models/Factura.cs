using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {


        public int IDFactura { get; set; }
        public float SubTotal { get; set; }
        public float Iva { get; set; }
        public float Total { get; set; }



        public Usuario MiUsuario { get; set; }
        public MetodoPago MiMetodoPago { get; set; }
        public Hospedaje MiHospedaje { get; set; }


        public Factura()
        {
            MiUsuario = new Usuario();
            MiMetodoPago = new MetodoPago();
            MiHospedaje = new Hospedaje();


        }


        //fn & metodos
        //Funciones y metodos
        //Ahora se escribe las funciones y metodos(operaciones)
        public int Agregar()
        {
            int R = 0;
            Conexion MiCnn = new Conexion();

            //parámetros para el encabezado 
            MiCnn.ListaParametros.Add(new SqlParameter("@Subtotal", this.SubTotal));
            MiCnn.ListaParametros.Add(new SqlParameter("@IVA", this.Iva));
            MiCnn.ListaParametros.Add(new SqlParameter("@Total", this.Total));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuario", this.MiUsuario.IDUsuario));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDHospedaje", this.MiHospedaje.IDHospedaje));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDMetodoPago", this.MiMetodoPago.IDMetodoPago));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto
            // perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPFacturaAgregar");

            if (resultado > 0)
            {
                R = 1;
            }

            return R;

        }

        public bool Imprimir()
        {
            //TODO: ejecutar SP que contenga la instruccion
            // correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }

        public DataTable ListarPorFechas(DateTime FechaInicial, DateTime FechaFinal)
        {
            //TODO usar SP con parametros para ver las fechas de inicio y final
            DataTable R = new DataTable();

            return R;
        }

        public DataTable CargarEsquemaListaDetalle()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPFacturaDetalleEsquema", true); //SOLO CARGA EL ESQUEMA, NO CARGA NINGUN DATO

            R.PrimaryKey = null;

            return R;
        }


    }
}
