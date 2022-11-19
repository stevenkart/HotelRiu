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

            MiOcupacionLocal = new Logica.Models.Ocupacion();

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

        //funcion para el boton limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
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
            DgvListaOcupaciones.ClearSelection();
            MiOcupacionLocal = new Logica.Models.Ocupacion();
        }

        private void FrmOcupacionesGestion_Load(object sender, EventArgs e)
        {
            LlenarListaOcupaciones();
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
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            MiOcupacionLocal.DescripcionRol = txtNombreOcupacion.Text.Trim();

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
    }
}
