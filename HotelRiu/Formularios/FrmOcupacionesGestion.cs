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
    public partial class FrmOcupacionesGestion : Form
    {

        private Logica.Models.Ocupacion MiOcupacionLocal { get; set; }

        private DataTable ListaOcupaciones { get; set; }

        public FrmOcupacionesGestion()
        {
            InitializeComponent();

            MiOcupacionLocal = new Logica.Models.Ocupacion();

            ListaOcupaciones = new DataTable();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCamposRequeridos())
            {
                MiOcupacionLocal = new Logica.Models.Ocupacion();
                string d = txtNombreOcupacion.Text.Trim();
                int existe = MiOcupacionLocal.ConsultarPorOcupacion(d);

                if (existe == 0)
                {

                    MiOcupacionLocal.DescripcionRol = txtNombreOcupacion.Text.Trim();

                    string mensaje = string.Format("Esta seguro de agregar ocupacion : {0}?", MiOcupacionLocal.DescripcionRol);

                    DialogResult respuesta = MessageBox.Show(mensaje, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool Ok = MiOcupacionLocal.Agregar();

                        if (Ok)
                        {
                            MessageBox.Show("Ocupacion agregada correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarTodo();
                            LlenarListaOcupaciones();
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar la ocupacion", ":(", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocupacion Ya ha sido agregada anteriormente, " +
                        "no puedes agregar mas de ese tipo", ":(", MessageBoxButtons.OK);

                }
            }
        }

        //funcion para el boton limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        //metodo para limpiar los inputs del formulario
        //esta asociado al metodo del boton limpiar del formulario
        private void LimpiarFormulario()
        {
            txtIDOcupacion.Clear();
            txtNombreOcupacion.Clear();
        }

        private void LimpiarTodo()
        {
            LimpiarFormulario();
            ActivarAgregar();
            DgvListaOcupaciones.ClearSelection();
            MiOcupacionLocal = new Logica.Models.Ocupacion();
        }

        private void FrmOcupacionesGestion_Load(object sender, EventArgs e)
        {
            LlenarListaOcupaciones();
            ActivarAgregar();
        }

        private void LlenarListaOcupaciones()
        {
            ListaOcupaciones = new DataTable();

            ListaOcupaciones = MiOcupacionLocal.Listar(txtBuscar.Text.Trim());

            DgvListaOcupaciones.DataSource = ListaOcupaciones;
        }

        private void DgvListaOcupaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvListaOcupaciones.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaOcupaciones.SelectedRows[0];

                int IdOcupacion = Convert.ToInt32(MiFila.Cells["CIDOcupacion"].Value);

                MiOcupacionLocal = new Logica.Models.Ocupacion();

                MiOcupacionLocal.IDOcupacion = IdOcupacion;

                MiOcupacionLocal = MiOcupacionLocal.ConsultarPorID();

                if (MiOcupacionLocal != null && MiOcupacionLocal.IDOcupacion > 0)
                {
                    txtIDOcupacion.Text = MiOcupacionLocal.IDOcupacion.ToString();
                    txtNombreOcupacion.Text = MiOcupacionLocal.DescripcionRol;
                    ActivarModificarEliminar();
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (validarCamposRequeridos())
            {
                MiOcupacionLocal = new Logica.Models.Ocupacion();
                string d = txtNombreOcupacion.Text.Trim();
                int existe = MiOcupacionLocal.ConsultarPorOcupacion(d);

                if (existe == 1)
                {
                    DialogResult Respuesta = MessageBox.Show("Seguro de modificar la ocupacion?", "???",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                    if (Respuesta == DialogResult.Yes)
                    {
                        if (MiOcupacionLocal.Modificar())
                        {
                            MessageBox.Show("Ocupacion modificada correctamente!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarTodo();
                            LlenarListaOcupaciones();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocupacion no pudo ser modificada!, " +
                        "ya hay una con esa descripcion", ":(",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("Seguro de eliminar la ocupacion?", "???",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (Respuesta == DialogResult.Yes)
            {
                if (MiOcupacionLocal.Eliminar())
                {
                    MessageBox.Show("Ocupacion eliminada correctamente!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarTodo();
                    LlenarListaOcupaciones();
                }
                else
                {
                    MessageBox.Show("Ocupacion no pudo ser eliminada!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) &&
                txtBuscar.Text.Count() > 2)
            {
                LlenarListaOcupaciones();
            }
            else if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                LlenarListaOcupaciones();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private bool validarCamposRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtNombreOcupacion.Text.Trim()))
            {
                R = true;
            }
            else
            {
                //estas validaciones deben ser puntuales para informar al usuario que falla 

                if (string.IsNullOrEmpty(txtNombreOcupacion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Nombre de Ocupación", "Error de Validación!", MessageBoxButtons.OK);
                    txtNombreOcupacion.Focus();
                    return false;
                }
             
            }
            return R;
        }
    }
}
