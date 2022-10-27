using System;
using System.Collections.Generic;
using System.Data;
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
            //TODO: ejecutar SP que contenga la instruccion
            //INSERT correspondiente a retornar un int

            int R = 0;

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


    }
}
