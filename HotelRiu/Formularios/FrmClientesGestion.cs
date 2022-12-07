using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HotelRiu.Formularios
{
    public partial class FrmClientesGestion : Form
    {

        public Logica.Models.Cliente MiClienteLocal { get; set; }
        public DataTable ListaClientes { get; set; }
        public FrmClientesGestion()
        {
            InitializeComponent();
            MiClienteLocal = new Logica.Models.Cliente();
            ListaClientes = new DataTable();
            
        }
        private void FrmClientesGestion_Load(object sender, EventArgs e)
        {
            //pre carga codigo una vez se inicia el formulario
            LlenarListaClientes();
            ActivarAgregar();

        }

        private void LlenarListaClientes()
        {
            ListaClientes = new DataTable();
            ListaClientes = MiClienteLocal.Listar(txtBuscar.Text.Trim());

            dgvLista.DataSource = ListaClientes;
        }


        //Agrega al nuevo Cliente
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //lo primero que se debe hacer es validar que los datos minimos necesario estan compeltos

            //luego, se procede a realizar las 3 validaciones que se indican por medio de los include (uses) en el
            //diagrama en el caso de uso extendido
            //y si las 3 validaciones son NEGATIVAS se tiene permiso para agregar el usuario

            if (validarCamposRequeridos())//los campos estan completos if its TRUE
            {
                //se crear un usuario local y se agrega los valos de los atributos
                MiClienteLocal = new Logica.Models.Cliente();

                MiClienteLocal.Cedula = txtCedula.Text.Trim();
                MiClienteLocal.Nombre = txtNombre.Text.Trim();
                MiClienteLocal.Apellidos = txtApellidos.Text.Trim();
                MiClienteLocal.Correo = txtCorreo.Text.Trim();
                MiClienteLocal.Telefono = txtTelefono.Text.Trim();
                MiClienteLocal.Direccion = txtDireccion.Text.Trim();
                

                //si las 3 validaciones son NEGATIVAS se tiene permiso para agregar el usuario
                bool CPorCedula = MiClienteLocal.ConsultarPorCedula();


                if (!CPorCedula)
                {
                    string Msg = string.Format("¿Esta Seguro de agregar al cliente: {0} {1} ?", MiClienteLocal.Nombre, MiClienteLocal.Apellidos);
                    DialogResult respuesta = MessageBox.Show(Msg, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        //si las tres validaciones son negativas agregamos el usuario
                        bool ok = MiClienteLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Cliente Agregado Correctamente!!!", " :", MessageBoxButtons.OK);
                            LimpiarForm();
                            LlenarListaClientes();
                        }
                        else
                        {
                            MessageBox.Show("Cliente No agregado", " :(", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    if (CPorCedula)
                    {
                        MessageBox.Show("Ya existe un cliente con la cédula digitada en el sistema", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }
        //metodo que valida los campos requerido
        private bool validarCamposRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(txtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(txtApellidos.Text.Trim()) &&
                !string.IsNullOrEmpty(txtCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(txtTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(txtDireccion.Text.Trim()))
            {
                R = true;
            }
            else
            {
                //se le informa al usuario qu validacion esta fallando
                //estas validaciones deben ser puntuales para informar al usuario que falla 

                if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de Validación!", MessageBoxButtons.OK);
                    txtNombre.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la cédula", "Error de Validación!", MessageBoxButtons.OK);
                    txtCedula.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtApellidos.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar los Apellidos", "Error de Validación!", MessageBoxButtons.OK);
                    txtApellidos.Focus();
                    return false;

                }
                if (string.IsNullOrEmpty(txtCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Correo", "Error de Validación!", MessageBoxButtons.OK);
                    txtCorreo.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el teléfono", "Error de Validación!", MessageBoxButtons.OK);
                    txtTelefono.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtDireccion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la Dirección", "Error de Validación!", MessageBoxButtons.OK);
                    txtDireccion.Focus();
                    return false;
                }
            }
            return R;
        }
        //Limpia el formulario
        private void LimpiarForm()
        {
            txtIDCliente.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

        }
        //Validaciones de Campos
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true, false);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true, false);
        }
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true, false);
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, false);
        }
        //validacion de ingreso de datos correo
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCorreo.Text.Trim()))
            {
                if (!Validaciones.IsValidEmail(txtCorreo.Text.Trim()))
                {
                    MessageBox.Show("Email ingresado no posee un formato correcto, debe llevar @ y el dominio correspondiente");
                 
                }
            }
        }
        //Limpiar Form
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }
        private void LimpiarTodo()
        {
            LimpiarForm();
            dgvLista.ClearSelection();
            MiClienteLocal = new Logica.Models.Cliente();
            ActivarAgregar();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) && txtBuscar.Text.Count() > 2)
            {
                LlenarListaClientes();
            }
            else if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                LlenarListaClientes();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //lo primero que se debe hacer es validar que los datos minimos necesario estan compeltos

            if (validarCamposRequeridos())//los campos estan completos if its TRUE
            {
                MiClienteLocal = new Logica.Models.Cliente();

                MiClienteLocal.IDCliente = Convert.ToInt32(txtIDCliente.Text.Trim());
                MiClienteLocal.Cedula = txtCedula.Text.Trim();
                MiClienteLocal.Nombre = txtNombre.Text.Trim();
                MiClienteLocal.Apellidos = txtApellidos.Text.Trim();      
                MiClienteLocal.Correo = txtCorreo.Text.Trim();
                MiClienteLocal.Telefono = txtTelefono.Text.Trim();
                MiClienteLocal.Direccion = txtDireccion.Text.Trim();
               

                if (MiClienteLocal.ConsultarPorID(MiClienteLocal.IDCliente))
                {
                    DialogResult Respuesta = MessageBox.Show("¿Seguro de Modificar al Cliente", "???",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Respuesta == DialogResult.Yes)
                    {
                        if (MiClienteLocal.Modificar())
                        {
                            MessageBox.Show("Cliente Modificado Correctamente!", ":)",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);


                            LlenarListaClientes();
                            LimpiarTodo();

                        }
                    }
                }
            }
        }
        private void ActivarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }
        private void ActivarModificarEliminar()
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MiClienteLocal = new Logica.Models.Cliente();
            MiClienteLocal.IDCliente = Convert.ToInt32(txtIDCliente.Text.Trim());

            if (MiClienteLocal.ConsultarPorID(MiClienteLocal.IDCliente))
            {
                DialogResult Respuesta = MessageBox.Show("¿Seguro de Eliminar al Cliente?", "???",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    MiClienteLocal.Eliminar();
                    
                    MessageBox.Show("Cliente Eliminado Correctamente!", ":)",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTodo();
                    LlenarListaClientes();
                }
            }
        }
        private void dgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvLista.ClearSelection();
        }
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando se seleciona un item de la lista se deben mostrar los datos en los 
            //campos del formulario. En este estado se puede cambair la info y actualizar
            //o eliminar un usuario

            if (dgvLista.SelectedRows.Count == 1)
            {



                DataGridViewRow MiFila = dgvLista.SelectedRows[0];

                int IDCliente = Convert.ToInt32(MiFila.Cells["CIDCliente"].Value);

                MiClienteLocal = new Logica.Models.Cliente();

                MiClienteLocal.IDCliente = IDCliente;

                //una vez tenemos el valor del IDCliente, se llama a la funcion 
                //de consultar por ID que entrega como retorno un objeto de tipo usuario
                //en este caso voy a reutilizar el objeto de usuario local
                //para cargar datos por medio de la funcion 

                MiClienteLocal = MiClienteLocal.ConsultarPorID();

                if (MiClienteLocal != null && MiClienteLocal.IDCliente > 0)
                {
                    //una vez me asegure que el objeto posee datos, entonces se procede a representar
                    //en pantalla
                    txtIDCliente.Text = MiClienteLocal.IDCliente.ToString();
                    txtCedula.Text = MiClienteLocal.Cedula.ToString();
                    txtNombre.Text = MiClienteLocal.Nombre.ToString();
                    txtApellidos.Text = MiClienteLocal.Apellidos.ToString();
                    txtCorreo.Text = MiClienteLocal.Correo.ToString();
                    txtTelefono.Text = MiClienteLocal.Telefono.ToString();
                    txtDireccion.Text = MiClienteLocal.Direccion.ToString();

                    ActivarModificarEliminar();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        
    }
}
