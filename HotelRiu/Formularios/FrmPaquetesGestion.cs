using Logica.Models;
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
    public partial class FrmPaquetesGestion : Form
    {

        public Logica.Models.Paquete MiPaqueteLocal { get; set; }
        public DataTable ListaPaquetes { get; set; }
        public FrmPaquetesGestion()
        {
            InitializeComponent();
            MiPaqueteLocal = new Logica.Models.Paquete();
            ListaPaquetes = new DataTable();
        }

        private void FrmPaquetesGestion_Load(object sender, EventArgs e)
        {
            LlenarListaPaquetes();
            ActivarAgregar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //lo primero que se debe hacer es validar que los datos minimos necesario estan compeltos

            if (validarCamposRequeridos())
            {
                MiPaqueteLocal = new Logica.Models.Paquete();

                MiPaqueteLocal.Nombre = txtNombre.Text.Trim();
                MiPaqueteLocal.Descripcion = txtDescripcion.Text.Trim();
                if (checkBoxGastronomia.Checked)
                {
                    MiPaqueteLocal.Gastronomia = true;
                }
                else
                {
                    MiPaqueteLocal.Gastronomia = false;
                }

                if (checkBoxSpa.Checked)
                {
                    MiPaqueteLocal.ServicioSpa = true;
                }
                else
                {
                    MiPaqueteLocal.ServicioSpa = false;
                }

                if (checkBoxTour.Checked)
                {
                    MiPaqueteLocal.Tour4x4 = true;
                }
                else
                {
                    MiPaqueteLocal.Tour4x4 = false;
                }

                MiPaqueteLocal.Precio = (float)Convert.ToDouble(txtPrecio.Text.Trim());

                string mensaje = string.Format("Esta seguro de agregar el Paquete : {0}?", MiPaqueteLocal.Nombre);

                DialogResult respuesta = MessageBox.Show(mensaje, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    bool Ok = MiPaqueteLocal.Agregar();

                    if (Ok)
                    {
                        MessageBox.Show("Paquete agregado(a) correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarTodo();
                        LlenarListaPaquetes();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el paquete", ":(", MessageBoxButtons.OK);
                    }
                }
            }    
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //lo primero que se debe hacer es validar que los datos minimos necesario estan compeltos

            if (validarCamposRequeridos())
            {
                MiPaqueteLocal.IDPaquete = Convert.ToInt32(txtIDPaquete.Text.Trim());
                MiPaqueteLocal.Nombre = txtNombre.Text.Trim();
                MiPaqueteLocal.Descripcion = txtDescripcion.Text.Trim();
                if (checkBoxGastronomia.Checked)
                {
                    MiPaqueteLocal.Gastronomia = true;
                }
                else
                {
                    MiPaqueteLocal.Gastronomia = false;
                }

                if (checkBoxSpa.Checked)
                {
                    MiPaqueteLocal.ServicioSpa = true;
                }
                else
                {
                    MiPaqueteLocal.ServicioSpa = false;
                }

                if (checkBoxTour.Checked)
                {
                    MiPaqueteLocal.Tour4x4 = true;
                }
                else
                {
                    MiPaqueteLocal.Tour4x4 = false;
                }

                MiPaqueteLocal.Precio = (float)Convert.ToDouble(txtPrecio.Text.Trim());

                DialogResult Respuesta = MessageBox.Show("¿Seguro de Modificar al Paquete", "???",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    if (MiPaqueteLocal.Modificar())
                    {
                        MessageBox.Show("Paquete Modificado Correctamente!", ":)",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LlenarListaPaquetes();
                        LimpiarTodo();

                    }
                }
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            DialogResult Respuesta = MessageBox.Show("Seguro de eliminar el paquete?", "???",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                if (MiPaqueteLocal.Eliminar())
                {
                    MessageBox.Show("Paquete eliminado correctamente!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LlenarListaPaquetes();
                    LimpiarTodo();
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
        private void LimpiarForm()
        {
            txtIDPaquete.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            checkBoxGastronomia.Checked = false;
            checkBoxSpa.Checked = false;
            checkBoxTour.Checked = false;
            txtPrecio.Clear();
        }

        private void LimpiarTodo()
        {
            LimpiarForm();
            dgvLista.ClearSelection();
            MiPaqueteLocal = new Logica.Models.Paquete();
            ActivarAgregar();
        }

        private void LlenarListaPaquetes()
        {
            ListaPaquetes = new DataTable();
            ListaPaquetes = MiPaqueteLocal.Listar(txtBuscar.Text.Trim());

            dgvLista.DataSource = ListaPaquetes;
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 1)
            {



                DataGridViewRow MiFila = dgvLista.SelectedRows[0];

                int IDPaquete = Convert.ToInt32(MiFila.Cells["CIDPaquete"].Value);

                MiPaqueteLocal = new Logica.Models.Paquete();

                MiPaqueteLocal.IDPaquete = IDPaquete;


                //una vez tenemos el valor del IDPaquete, se llama a la funcion 
                //de consultar por ID que entrega como retorno un objeto de tipo PAQUETE
                //en este caso voy a reutilizar el objeto de usuario local
                //para cargar datos por medio de la funcion 


                //ESTE METODO de consultor RETORNA UN OBJETO de tipo Empleado
                MiPaqueteLocal = MiPaqueteLocal.ConsultarPorID();



                if (MiPaqueteLocal != null && MiPaqueteLocal.IDPaquete > 0)
                {
                    //una vez me asegure que el objeto posee datos, entonces
                    //se procede a representar
                    //en pantalla
                    txtIDPaquete.Text = MiPaqueteLocal.IDPaquete.ToString();
                    txtNombre.Text = MiPaqueteLocal.Nombre.ToString();
                    txtDescripcion.Text = MiPaqueteLocal.Descripcion.ToString();
                    checkBoxGastronomia.Checked = MiPaqueteLocal.Gastronomia;
                    checkBoxSpa.Checked = MiPaqueteLocal.ServicioSpa;
                    checkBoxTour.Checked = MiPaqueteLocal.Tour4x4;
                    txtPrecio.Text = MiPaqueteLocal.Precio.ToString();
                   
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, false);
        }

        //metodo que valida los campos requerido
        private bool validarCamposRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(txtDescripcion.Text.Trim()) &&
                !string.IsNullOrEmpty(txtPrecio.Text.Trim()))
            {
                R = true;
            }
            else
            {
                //estas validaciones deben ser puntuales para informar al usuario que falla 

                if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de Validación!", MessageBoxButtons.OK);
                    txtNombre.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la Descripcion", "Error de Validación!", MessageBoxButtons.OK);
                    txtDescripcion.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtPrecio.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Precio", "Error de Validación!", MessageBoxButtons.OK);
                    txtPrecio.Focus();
                    return false;

                }

            }    
            return R;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) && txtBuscar.Text.Count() > 0)
            {
                LlenarListaPaquetes();
            }
            else if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                LlenarListaPaquetes();
            }
        }
    }
}
