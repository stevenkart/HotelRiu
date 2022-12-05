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
    public partial class FrmHabitaciones : Form
    {

        public Logica.Models.Habitacion MiHabitacionLocal { get; set; }
        public DataTable ListaHabitaciones { get; set; }

        public FrmHabitaciones()
        {
            InitializeComponent();
            MiHabitacionLocal = new Logica.Models.Habitacion();
            ListaHabitaciones = new DataTable();
        }

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            CargarEstadosDeHabitaciones();
            ActivarAgregar();
            LlenarListaHabitaciones();
        }
        private void CargarEstadosDeHabitaciones()
        {

            //paso 1 y 1.1 de secuencia usuario rol listar
            Logica.Models.Estado MiEstado = new Logica.Models.Estado();

            //paso 2 y 2.5
            DataTable dt = new DataTable();
            dt = MiEstado.ListarEstadosHabitaciones();

            //paso 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cBoxEstado.ValueMember = "Id";
                cBoxEstado.DisplayMember = "D";
                cBoxEstado.DataSource = dt;
                cBoxEstado.SelectedIndex = -1;

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //lo primero que se debe hacer es validar que los datos minimos necesario estan compeltos

            if (validarCamposRequeridos())
            {
                MiHabitacionLocal = new Logica.Models.Habitacion();


                MiHabitacionLocal.Precio = (float)Convert.ToDouble(txtPrecio.Text.Trim());
                MiHabitacionLocal.Cantidad_Cama = Convert.ToInt32(txtCamas.Text.Trim());
                if (checkbJacuzzi.Checked)
                {
                    MiHabitacionLocal.Jacuzzi = true;
                }
                else
                {
                    MiHabitacionLocal.Jacuzzi = false;
                }

                if (checkbMatrimonial.Checked)
                {
                    MiHabitacionLocal.Cama_Matrimonial = true;
                }
                else
                {
                    MiHabitacionLocal.Cama_Matrimonial = false;
                }

                if (checkbAC.Checked)
                {
                    MiHabitacionLocal.Aire_Acondicionado = true;
                }
                else
                {
                    MiHabitacionLocal.Aire_Acondicionado = false;
                }

                MiHabitacionLocal.MiEstado.IDEstado = Convert.ToInt32(cBoxEstado.SelectedValue);

                string mensaje = string.Format("Esta seguro de agregar La habitación?");

                DialogResult respuesta = MessageBox.Show(mensaje, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    bool Ok = MiHabitacionLocal.Agregar();

                    if (Ok)
                    {
                        MessageBox.Show("habitación agregada correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarTodo();
                        LlenarListaHabitaciones();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar la habitación", ":(", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //lo primero que se debe hacer es validar que los datos minimos necesario estan compeltos

            if (validarCamposRequeridos())
            {
                MiHabitacionLocal.IDHabitacion = Convert.ToInt32(txtIDHabitacion.Text.Trim());
                MiHabitacionLocal.Precio = (float)Convert.ToDouble(txtPrecio.Text.Trim());
                MiHabitacionLocal.Cantidad_Cama = Convert.ToInt32(txtCamas.Text.Trim());
                if (checkbJacuzzi.Checked)
                {
                    MiHabitacionLocal.Jacuzzi = true;
                }
                else
                {
                    MiHabitacionLocal.Jacuzzi = false;
                }

                if (checkbMatrimonial.Checked)
                {
                    MiHabitacionLocal.Cama_Matrimonial = true;
                }
                else
                {
                    MiHabitacionLocal.Cama_Matrimonial = false;
                }

                if (checkbAC.Checked)
                {
                    MiHabitacionLocal.Aire_Acondicionado = true;
                }
                else
                {
                    MiHabitacionLocal.Aire_Acondicionado = false;
                }

                MiHabitacionLocal.MiEstado.IDEstado = Convert.ToInt32(cBoxEstado.SelectedValue);

                DialogResult Respuesta = MessageBox.Show("¿Seguro de Modificar la Habitación?", "???",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    if (MiHabitacionLocal.Modificar())
                    {
                        MessageBox.Show("Habitación Modificada Correctamente!", ":)",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LlenarListaHabitaciones();
                        LimpiarTodo();

                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cBoxEstado.SelectedIndex == 0)
            {
                DialogResult Respuesta = MessageBox.Show("NO Es posible eliminar la habitación, ya que esta no esta disponible," +
                    "se encuentra ocupada por huespedes", "Alerta!",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult Respuesta = MessageBox.Show("Seguro de eliminar la habitación?", "???",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    if (MiHabitacionLocal.Eliminar())
                    {
                        MessageBox.Show("Habitación eliminada correctamente!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LlenarListaHabitaciones();
                        LimpiarTodo();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) && txtBuscar.Text.Count() > 0)
            {
                LlenarListaHabitaciones();
            }
            else if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                LlenarListaHabitaciones();
            }
           
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, false);
        }

        private void txtCamas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void LlenarListaHabitaciones()
        {
            ListaHabitaciones = new DataTable();
            ListaHabitaciones = MiHabitacionLocal.Listar(txtBuscar.Text.Trim());
            //ListaHabitaciones = MiHabitacionLocal.Listar();

            dgvLista.DataSource = ListaHabitaciones;
        }

        private void LimpiarForm()
        {
            txtIDHabitacion.Clear();
            checkbJacuzzi.Checked = false;
            txtPrecio.Clear();
            checkbMatrimonial.Checked = false;
            txtCamas.Clear();
            checkbAC.Checked = false;
            cBoxEstado.SelectedIndex = -1;
            ActivarAgregar();
        }

        private void LimpiarTodo()
        {
            LimpiarForm();
            dgvLista.ClearSelection();
            MiHabitacionLocal = new Logica.Models.Habitacion();

        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 1)
            {



                DataGridViewRow MiFila = dgvLista.SelectedRows[0];

                int IDHabitacion = Convert.ToInt32(MiFila.Cells["CIDHabitacion"].Value);

                MiHabitacionLocal = new Logica.Models.Habitacion();

                MiHabitacionLocal.IDHabitacion = IDHabitacion;


                //una vez tenemos el valor del IDHabitacion, se llama a la funcion 
                //de consultar por ID que entrega como retorno un objeto de tipo PAQUETE
                //en este caso voy a reutilizar el objeto de usuario local
                //para cargar datos por medio de la funcion 


                //ESTE METODO de consultor RETORNA UN OBJETO de tipo Empleado
                MiHabitacionLocal = MiHabitacionLocal.ConsultarPorID();



                if (MiHabitacionLocal != null && MiHabitacionLocal.IDHabitacion > 0)
                {
                    //una vez me asegure que el objeto posee datos, entonces
                    //se procede a representar
                    //en pantalla
                    txtIDHabitacion.Text = MiHabitacionLocal.IDHabitacion.ToString();
                    checkbJacuzzi.Checked = MiHabitacionLocal.Jacuzzi;
                    txtPrecio.Text = MiHabitacionLocal.Precio.ToString();
                    checkbMatrimonial.Checked = MiHabitacionLocal.Cama_Matrimonial;
                    txtCamas.Text = MiHabitacionLocal.Cantidad_Cama.ToString();
                    checkbAC.Checked = MiHabitacionLocal.Aire_Acondicionado;
                    cBoxEstado.SelectedValue = MiHabitacionLocal.MiEstado.IDEstado;

                    ActivarModificarEliminar();

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
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

        }

        private bool validarCamposRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtPrecio.Text.Trim()) &&
                !string.IsNullOrEmpty(txtCamas.Text.Trim()) &&
                cBoxEstado.SelectedIndex != -1)
            {
                R = true;
            }
            else
            {
                //estas validaciones deben ser puntuales para informar al usuario que falla 

                if (string.IsNullOrEmpty(txtPrecio.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Precio", "Error de Validación!", MessageBoxButtons.OK);
                    txtPrecio.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCamas.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la Cantidad de Camas", "Error de Validación!", MessageBoxButtons.OK);
                    txtCamas.Focus();
                    return false;
                }
                if (cBoxEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar un estado de la habitación", "Error de Validación!", MessageBoxButtons.OK);
                    txtPrecio.Focus();
                    return false;

                }
            }
            return R;
        }
    }
}
