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

        private void FrmEmpleadosGestion_Load(object sender, EventArgs e)
        {
            //metodo para llamar la lista de empleados
            LlenarListaEmpleados();

            //llena el combobox de ocupaciones 
            //del formulario empleados
            CargarRolesDeEmpleado();
            CargarEstadosDeEmpleado();

            ActivarAgregar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCamposRequeridos())
            {
                MiEmpleadoLocal = new Logica.Models.Empleado();

                MiEmpleadoLocal.Cedula = txtCedula.Text.Trim();
                MiEmpleadoLocal.Nombre = txtNombre.Text.Trim();
                MiEmpleadoLocal.Apellidos = txtApellidos.Text.Trim();
                MiEmpleadoLocal.Correo = txtCorreo.Text.Trim();
                MiEmpleadoLocal.Direccion = txtDireccion.Text.Trim();
                MiEmpleadoLocal.Telefono = txtTelefono.Text.Trim();
                MiEmpleadoLocal.MiEstado.IDEstado = Convert.ToInt32(cboxEstado.SelectedValue);
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
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarCamposRequeridos())
            {
                MiEmpleadoLocal.IDEmpleado = Convert.ToInt32(txtIDEmpleado.Text.Trim());
                MiEmpleadoLocal.Cedula = txtCedula.Text.Trim();
                MiEmpleadoLocal.Nombre = txtNombre.Text.Trim();
                MiEmpleadoLocal.Apellidos = txtApellidos.Text.Trim();
                MiEmpleadoLocal.Correo = txtCorreo.Text.Trim();
                MiEmpleadoLocal.Telefono = txtTelefono.Text.Trim();
                MiEmpleadoLocal.Direccion = txtDireccion.Text.Trim();
                MiEmpleadoLocal.MiEstado.IDEstado = Convert.ToInt32(cboxEstado.SelectedValue);
                MiEmpleadoLocal.MiOcupacion.IDOcupacion = Convert.ToInt32(cboxOcupacion.SelectedValue);

                DialogResult Respuesta = MessageBox.Show("¿Seguro de Modificar al Empleado", "???",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    if (MiEmpleadoLocal.Modificar())
                    {
                        MessageBox.Show("Empleado Modificado Correctamente!", ":)",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);


                        LlenarListaEmpleados();
                        LimpiarTodo();

                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //modificar haria el eliminado logico ya que se indica si
            //se activa o no el empleado y automaticamente bloquearia el usuario si se inactiva el empleado
            /*
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
            */
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            cboxEstado.SelectedIndex = -1;

        }

        private void LimpiarTodo()
        {
            LimpiarForm();
            dgvLista.ClearSelection();
            MiEmpleadoLocal = new Logica.Models.Empleado();
            ActivarAgregar();
        }



        //metodo para llamar la lista de empleados
        private void LlenarListaEmpleados()
        {
            ListaEmpleados = new DataTable();
            ListaEmpleados = MiEmpleadoLocal.Listar(chEstado.Checked, txtBuscar.Text.Trim());

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
                    cboxEstado.SelectedValue = MiEmpleadoLocal.MiEstado.IDEstado;
                    ActivarModificarEliminar();
                    btnEliminar.Enabled = false;
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
                cboxOcupacion.ValueMember = "Id";
                cboxOcupacion.DisplayMember = "D";
                cboxOcupacion.DataSource = dt;
                cboxOcupacion.SelectedIndex = -1;

            }

        }

        private void CargarEstadosDeEmpleado()
        {

            //paso 1 y 1.1 de secuencia usuario rol listar
            Logica.Models.Estado MiEstado = new Logica.Models.Estado();

            //paso 2 y 2.5
            DataTable dt = new DataTable();
            dt = MiEstado.ListarEstadosUsuarios();

            //paso 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cboxEstado.ValueMember = "Id";
                cboxEstado.DisplayMember = "D";
                cboxEstado.DataSource = dt;
                cboxEstado.SelectedIndex = -1;

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
            btnEliminar.Enabled = false; // todo se haria en el modificar, si se va a eliminar el usuario ahi se inactiva 
            btnModificar.Enabled = true;

        }

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
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void chEstado_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaEmpleados();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) && txtBuscar.Text.Count() > 2)
            {
                LlenarListaEmpleados();
            }
            else if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                LlenarListaEmpleados();
            }
        }


        private bool validarCamposRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(txtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(txtApellidos.Text.Trim()) &&
                !string.IsNullOrEmpty(txtCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(txtDireccion.Text.Trim()) &&
                !string.IsNullOrEmpty(txtTelefono.Text.Trim()) &&
                cboxEstado.SelectedIndex != -1 &&
                cboxOcupacion.SelectedIndex != -1)
            {
                R = true;
            }
            else
            {
                //estas validaciones deben ser puntuales para informar al usuario que falla 

                if (string.IsNullOrEmpty(txtCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la Identificación", "Error de Validación!", MessageBoxButtons.OK);
                    txtCedula.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Nombre", "Error de Validación!", MessageBoxButtons.OK);
                    txtNombre.Focus();
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
                    MessageBox.Show("Debe digitar el correo", "Error de Validación!", MessageBoxButtons.OK);
                    txtCorreo.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtDireccion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la dirección", "Error de Validación!", MessageBoxButtons.OK);
                    txtDireccion.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el teléfono", "Error de Validación!", MessageBoxButtons.OK);
                    txtTelefono.Focus();
                    return false;
                }
                if (cboxEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar un estado del Empleado", "Error de Validación!", MessageBoxButtons.OK);
                    cboxEstado.Focus();
                    return false;

                }
                if (cboxOcupacion.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar u´na Ocupación del Empleado", "Error de Validación!", MessageBoxButtons.OK);
                    cboxOcupacion.Focus();
                    return false;

                }
            }
            return R;
        }
    }
}
