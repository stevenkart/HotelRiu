using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Cliente
    {
        //atributos simples
        public int IDCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        //Constructor
        public Cliente()
        {
            
        }

        //Ahora se escribe las funciones y metodos(operaciones)
        public bool Agregar()
        {
            
            bool R = false;

            // conexion con el servidor de base datos
            Conexion MiCnn = new Conexion();

            // lista de atributos simples para el INSERT en la basedatos
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Apellidos", this.Apellidos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Correo", this.Correo));
            MiCnn.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaParametros.Add(new SqlParameter("@Direccion", this.Direccion));

            // si el procedimiento retorna y numero mayor a 0 el query u procedimiento se ejecuto perfectamente
            int resultado = MiCnn.EjecutarUpdateDeleteInsert("SPClienteAgregar");

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

            Conexion MiCnn = new Conexion();
            //debemos pasar la lista parametros para el insert

            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Apellidos", this.Apellidos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Correo", this.Correo));
            MiCnn.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaParametros.Add(new SqlParameter("@Direccion", this.Direccion));
           
                      
            //ID CLIENTE
            MiCnn.ListaParametros.Add(new SqlParameter("@IDCliente", this.IDCliente));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPClienteModificar");

            if (Resultado > 0)
            {
                R = true;


            }
            return R;

        }
        public bool Eliminar()
        {

            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar la lista parametros para el DELETE

            //ID CLIENTE
            MiCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDCliente));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPClienteEliminar");

            if (Resultado == 0)
            {
                R = true;


            }
            return R;
        }
        public Cliente ConsultarPorID()
        {

            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar del mismo tipo de la clase
            // TODO sale bien entregue un select
            Cliente R = new Cliente();


            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDCliente));
            DataTable dataCliente = new DataTable();
            dataCliente = MyCnn.EjecutarSelect("SPClienteConsultarPorID");

            //Una vez tewnemos un datatable con la data procedemos a llenar las propiedades del 
            //objeto retorno

            if (dataCliente != null && dataCliente.Rows.Count > 0)
            {

                DataRow Fila = dataCliente.Rows[0];

                R.IDCliente = Convert.ToInt32(Fila["IDCliente"]);   
                R.Cedula = Convert.ToString(Fila["Cedula"]);
                R.Nombre = Convert.ToString(Fila["Nombre"]);
                R.Apellidos = Convert.ToString(Fila["Apellidos"]);
                R.Correo = Convert.ToString(Fila["Correo"]);
                R.Telefono = Convert.ToString(Fila["Telefono"]);
                R.Direccion = Convert.ToString(Fila["direccion"]);
      


            }

            return R;

        }






     
        public bool ConsultarPorID(int pIDCliente)
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar del mismo tipo de la clase
            // TODO sale bien entregue un select
            bool R = false;


            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", pIDCliente));
            DataTable dataCliente = new DataTable();
            dataCliente = MyCnn.EjecutarSelect("SPClienteConsultarPorID");


            if (dataCliente != null && dataCliente.Rows.Count > 0)
            {
                R = true;

            }

            return R;

        }

        public bool ConsultarPorCedula()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            //todo listo****


            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar 1 parametro al SP DE CONSULTA
            //en el sql parametro se adjunta el parametro de SP
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            //ahora se llama el SP 

            DataTable Consulta = MiCnn.EjecutarSelect("SPClienteConsultarPorCedula");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;

            }

            return R;

        }
       
        public DataTable Listar(string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSelect("SPClienteListar");


            return R;


        }



    }
}
