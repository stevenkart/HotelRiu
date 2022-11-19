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
    public partial class FrmUsuariosGestion : Form
    {
        public Logica.Models.Usuario MiUsuarioLocal { get; set; }
        public DataTable ListaUsuarios { get; set; }
        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            LlenarListaUsuarios();

            CargarNombresDeEmpleado();
        }


        //esta informacion se va a almacenar
        //en un ComboBox para asignarlo a un
        //usuario
        private void CargarNombresDeEmpleado()
        {

            //paso 1 y 1.1 de secuencia usuario rol listar
            Logica.Models.Empleado MiEmpleado = new Logica.Models.Empleado();

            //paso 2 y 2.5
            DataTable dt = new DataTable();
            dt = MiEmpleado.ListarEmpleadoSinUsuario();

            //paso 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cboxEmpleado.ValueMember = "IDEmpleado";
                cboxEmpleado.DisplayMember = "Nombre";
                cboxEmpleado.DataSource = dt;
                cboxEmpleado.SelectedIndex = -1;

            }

        }

        //metodo para llamar la lista de usuarios
        private void LlenarListaUsuarios()
        {
            ListaUsuarios = new DataTable();
            ListaUsuarios = MiUsuarioLocal.Listar(txtBuscar.Text.Trim());

            dgvLista.DataSource = ListaUsuarios;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            txtIDUsuario.Clear();
            txtNombreUsuario.Clear();
            txtContrasenia.Clear();
            cboxEmpleado.SelectedIndex = -1;
        }

        private void LimpiarTodo()
        {
            LimpiarForm();
            dgvLista.ClearSelection();
            MiUsuarioLocal = new Logica.Models.Usuario();
            //ActivarAgregar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MiUsuarioLocal = new Logica.Models.Usuario();


            MiUsuarioLocal.NombreUsuario = txtNombreUsuario.Text.Trim();
            MiUsuarioLocal.Contrasenia = txtContrasenia.Text.Trim();

            MiUsuarioLocal.MiEmpleado.IDEmpleado = Convert.ToInt32(cboxEmpleado.SelectedValue);

            string mensaje = string.Format("Esta seguro de agregar el usuario : {0}?", MiUsuarioLocal.NombreUsuario);

            DialogResult respuesta = MessageBox.Show(mensaje, "???", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                bool Ok = MiUsuarioLocal.Agregar();

                if (Ok)
                {
                    MessageBox.Show("Empleado usuario correctamente", ":)", MessageBoxButtons.OK);

                    // limpia todo cuando se ejecuta
                    LimpiarTodo();

                    // llena o recarga el combobox con datos
                    // solo empleados sin asignar usuario
                    CargarNombresDeEmpleado();


                    // llena el data grid de informacion
                    LlenarListaUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al guardar la empleado(a)", ":(", MessageBoxButtons.OK);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MiUsuarioLocal.IDUsuario = Convert.ToInt32(txtIDUsuario.Text.Trim());
            MiUsuarioLocal.NombreUsuario = txtNombreUsuario.Text.Trim();
            MiUsuarioLocal.Contrasenia = txtContrasenia.Text.Trim();

            MessageBox.Show(MiUsuarioLocal.Contrasenia);

            DialogResult Respuesta = MessageBox.Show("¿Seguro de Modificar al Usuario", "???",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                if (MiUsuarioLocal.Modificar())
                {
                    MessageBox.Show("Usuario Modificado Correctamente!", ":)",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    LlenarListaUsuarios();
                    LimpiarTodo();

                }
            }
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 1)
            {



                DataGridViewRow MiFila = dgvLista.SelectedRows[0];

                int IDUsuario = Convert.ToInt32(MiFila.Cells["CIDUsuario"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.IDUsuario = IDUsuario;


                //una vez tenemos el valor del IDCliente, se llama a la funcion 
                //de consultar por ID que entrega como retorno un objeto de tipo usuario
                //en este caso voy a reutilizar el objeto de usuario local
                //para cargar datos por medio de la funcion 


                //ESTE METODO de consultor RETORNA UN OBJETO de tipo Empleado
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID();



                if (MiUsuarioLocal != null && MiUsuarioLocal.IDUsuario > 0)
                {
                    //una vez me asegure que el objeto posee datos, entonces se procede a representar
                    //en pantalla
                    txtIDUsuario.Text = MiUsuarioLocal.IDUsuario.ToString();
                    txtNombreUsuario.Text = MiUsuarioLocal.NombreUsuario.ToString();
                    //txtContrasenia.Text = MiUsuarioLocal.Contrasenia.ToString();

                    cboxEmpleado.SelectedValue = MiUsuarioLocal.MiEmpleado.IDEmpleado;



                    //ActivarModificarEliminar();
                }
            }
        }

        
    }
}
