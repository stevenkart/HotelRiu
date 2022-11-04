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

        public DataTable Listar() //retorna la lista de estados
        {
            DataTable R = new DataTable();

           
            Conexion MiCnn = new Conexion();

   

            R = MiCnn.EjecutarSelect("SPUsuarioRolListar");





            return R;
        }


    }
}
