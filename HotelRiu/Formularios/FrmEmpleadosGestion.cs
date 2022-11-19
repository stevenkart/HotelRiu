using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRiu.Formularios
{
    public partial class FrmEmpleadosGestion : Form
    {
        public Logica.Models.Empleado MiEmpleadoLocal { get; set; }
        public DataTable ListaEmpleados { get; set; }
        public FrmEmpleadosGestion()
        {
            InitializeComponent();

            MiEmpleadoLocal = new Logica.Models.Empleado();
            ListaEmpleados = new DataTable();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MiEmpleadoLocal = new Logica.Models.Empleado();


            MiEmpleadoLocal.Cedula = txtCedula.Text.Trim();
            MiEmpleadoLocal.Nombre = txtNombre.Text.Trim();
            MiEmpleadoLocal.Apellidos = txtApellidos.Text.Trim();
            MiEmpleadoLocal.Correo = txtCorreo.Text.Trim();
            MiEmpleadoLocal.Direccion = txtDireccion.Text.Trim();
            MiEmpleadoLocal.Telefono = txtTelefono.Text.Trim();

            MiEmpleadoLocal.MiOcupacion.IDOcupacion = Convert.ToInt32(cboxOcupacion.SelectedValue);

            string mensaje = string.Format("Esta seguro de agregar el empleado : {0}?", MiEmpleadoLocal.Nombre);

            DialogResult respuesta = MessageBox.Show(mensaje, "???", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                bool Ok = MiEmpleadoLocal.Agregar();

                if (Ok)
                {
                    MessageBox.Show("Empleado agregado(a) correctamente", ":)", MessageBoxButtons.OK);

                    LimpiarTodo();
                    LlenarListaEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al guardar la empleado(a)", ":(", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        //Limpia el formulario
        private void LimpiarForm()
        {
            txtIDEmpleado.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cboxOcupacion.SelectedIndex = -1;

        }

        private void LimpiarTodo()
        {
            LimpiarForm();
            dgvLista.ClearSelection();
            MiEmpleadoLocal = new Logica.Models.Empleado();
            //ActivarAgregar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MiEmpleadoLocal.IDEmpleado = Convert.ToInt32(txtIDEmpleado.Text.Trim());
            MiEmpleadoLocal.Cedula = txtCedula.Text.Trim();
            MiEmpleadoLocal.Nombre = txtNombre.Text.Trim();
            MiEmpleadoLocal.Apellidos = txtApellidos.Text.Trim();
            MiEmpleadoLocal.Correo = txtCorreo.Text.Trim();
            MiEmpleadoLocal.Telefono = txtTelefono.Text.Trim();
            MiEmpleadoLocal.Direccion = txtDireccion.Text.Trim();

            MiEmpleadoLocal.MiOcupacion.IDOcupacion = Convert.ToInt32(cboxOcupacion.SelectedValue);

            DialogResult Respuesta = MessageBox.Show("¿Seguro de Modificar al Cliente", "???",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    if (MiEmpleadoLocal.Modificar())
                    {
                        MessageBox.Show("Cliente Modificado Correctamente!", ":)",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);


                        LlenarListaEmpleados();
                        LimpiarTodo();

                    }
                }
            
        }

        private void FrmEmpleadosGestion_Load(object sender, EventArgs e)
        {
            //metodo para llamar la lista de empleados
            LlenarListaEmpleados();

            //llena el combobox de ocupaciones 
            //del formulario empleados
            CargarRolesDeEmpleado();
        }

        //metodo para llamar la lista de empleados
        private void LlenarListaEmpleados()
        {
            ListaEmpleados = new DataTable();
            ListaEmpleados = MiEmpleadoLocal.Listar(txtBuscar.Text.Trim());

            dgvLista.DataSource = ListaEmpleados;
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 1)
            {



                DataGridViewRow MiFila = dgvLista.SelectedRows[0];

                int IDEmpleado = Convert.ToInt32(MiFila.Cells["CIDEmpleado"].Value);

                MiEmpleadoLocal = new Logica.Models.Empleado();

                MiEmpleadoLocal.IDEmpleado = IDEmpleado;


                //una vez tenemos el valor del IDCliente, se llama a la funcion 
                //de consultar por ID que entrega como retorno un objeto de tipo usuario
                //en este caso voy a reutilizar el objeto de usuario local
                //para cargar datos por medio de la funcion 
 

                //ESTE METODO de consultor RETORNA UN OBJETO de tipo Empleado
                MiEmpleadoLocal = MiEmpleadoLocal.ConsultarPorID();

                

                if (MiEmpleadoLocal != null && MiEmpleadoLocal.IDEmpleado > 0)
                {
                    //una vez me asegure que el objeto posee datos, entonces se procede a representar
                    //en pantalla
                    txtIDEmpleado.Text = MiEmpleadoLocal.IDEmpleado.ToString();
                    txtCedula.Text = MiEmpleadoLocal.Cedula.ToString();
                    txtNombre.Text = MiEmpleadoLocal.Nombre.ToString();
                    txtApellidos.Text = MiEmpleadoLocal.Apellidos.ToString();
                    txtCorreo.Text = MiEmpleadoLocal.Correo.ToString();
                    txtTelefono.Text = MiEmpleadoLocal.Telefono.ToString();
                    txtDireccion.Text = MiEmpleadoLocal.Direccion.ToString();
                    cboxOcupacion.SelectedValue = MiEmpleadoLocal.MiOcupacion.IDOcupacion;

                    //ActivarModificarEliminar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("Seguro de eliminar un empleado?", "???",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                if (MiEmpleadoLocal.Eliminar())
                {
                    MessageBox.Show("Empleado(a) eliminado(a) correctamente!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarTodo();
                    LlenarListaEmpleados();
                }
            }
        }



        private void CargarRolesDeEmpleado()
        {

            //paso 1 y 1.1 de secuencia usuario rol listar
            Logica.Models.Ocupacion MiOcupacion = new Logica.Models.Ocupacion();

            //paso 2 y 2.5
            DataTable dt = new DataTable();
            dt = MiOcupacion.Listar();

            //paso 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cboxOcupacion.ValueMember = "IDOcupacion";
                cboxOcupacion.DisplayMember = "DescripcionRol";
                cboxOcupacion.DataSource = dt;
                cboxOcupacion.SelectedIndex = -1;

            }

        }

    }
}
