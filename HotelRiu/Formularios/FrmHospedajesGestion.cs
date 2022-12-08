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
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelRiu.Formularios
{
    public partial class FrmHospedajesGestion : Form
    {
        public Logica.Models.Hospedaje MiHospedajeLocal { get; set; }
        public DataTable ListaHospedajes { get; set; }

        public FrmHospedajesGestion()
        {
            InitializeComponent();
            MiHospedajeLocal = new Logica.Models.Hospedaje();
            ListaHospedajes = new DataTable();
        }

        private void FrmHospedajesGestion_Load(object sender, EventArgs e)
        {
           
            calcularDias();
            CargarListaClientes();
            CargarListaHabitaciones();
            CargarListaPaquetes();
            ActivarAgregar();
            cboxHabitacion.Enabled = false;
            btnFacturar.Enabled = false;
            LlenarListaHospedajes();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCamposRequeridos())
            {
                MiHospedajeLocal = new Logica.Models.Hospedaje();


                MiHospedajeLocal.Cant_Ninos = Convert.ToInt32(txtCantNinos.Text.Trim());
                MiHospedajeLocal.Cant_Adultos = Convert.ToInt32(txtCantAdultos.Text.Trim());
                MiHospedajeLocal.DiasHospedaje = Convert.ToInt32(txtDiasHospedaje.Text.Trim());
                MiHospedajeLocal.FechaEntrada = Convert.ToDateTime(dateEntrada.Text);
                MiHospedajeLocal.FechaSalida = Convert.ToDateTime(dateSalida.Text);
                MiHospedajeLocal.Total = (float)Convert.ToDouble(txtTotal.Text.Trim());

                MiHospedajeLocal.MiPaquete.IDPaquete = Convert.ToInt32(cboxPaquete.SelectedValue);
                MiHospedajeLocal.MiHabitacion.IDHabitacion = Convert.ToInt32(cboxHabitacion.SelectedValue);
                MiHospedajeLocal.MiCliente.IDCliente = Convert.ToInt32(cboxCliente.SelectedValue);

                string mensaje = string.Format("Esta seguro de agregar la reservación?");

                DialogResult respuesta = MessageBox.Show(mensaje, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    bool Ok = MiHospedajeLocal.Agregar();

                    if (Ok)
                    {
                        MessageBox.Show("Hospedaje agregado correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarTodo();
                        LlenarListaHospedajes();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el hospedaje", ":(", MessageBoxButtons.OK);
                    }
                }
            }
        }
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarCamposRequeridosSinHabitacion())
            {
                MiHospedajeLocal = new Logica.Models.Hospedaje();

                
                MiHospedajeLocal.Cant_Ninos = Convert.ToInt32(txtCantNinos.Text.Trim());
                MiHospedajeLocal.Cant_Adultos = Convert.ToInt32(txtCantAdultos.Text.Trim());
                MiHospedajeLocal.DiasHospedaje = Convert.ToInt32(txtDiasHospedaje.Text.Trim());
                MiHospedajeLocal.FechaEntrada = Convert.ToDateTime(dateEntrada.Text);
                MiHospedajeLocal.FechaSalida = Convert.ToDateTime(dateSalida.Text);
                MiHospedajeLocal.Total = (float)Convert.ToDouble(txtTotal.Text.Trim());
                MiHospedajeLocal.MiPaquete.IDPaquete = Convert.ToInt32(cboxPaquete.SelectedValue);
                MiHospedajeLocal.MiCliente.IDCliente = Convert.ToInt32(cboxCliente.SelectedValue);
                

                MiHospedajeLocal.MiHabitacion.IDHabitacion = Convert.ToInt32(cboxHabitacion.SelectedValue);
                if (MiHospedajeLocal.MiHabitacion.IDHabitacion <= 0)
                {
                    MiHospedajeLocal.MiHabitacion.IDHabitacion = Convert.ToInt32(txtIDHabitacionTemporal.Text);
                }
                

                MiHospedajeLocal.IDHospedaje = Convert.ToInt32(txtIDHospedaje.Text.Trim());
                string mensaje = string.Format("Esta seguro de modificar la reservación?");

                DialogResult respuesta = MessageBox.Show(mensaje, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    bool Ok = MiHospedajeLocal.Modificar();

              
                    MessageBox.Show("Reservación modificada correctamente", ":)", MessageBoxButtons.OK);

                    LimpiarTodo();
                    LlenarListaHospedajes();
                  
                    /*else
                    {
                        MessageBox.Show("Error al modificar la reservación", ":(", MessageBoxButtons.OK);
                    }*/
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarCamposRequeridosSinHabitacion())
            {
                MiHospedajeLocal = new Logica.Models.Hospedaje();


                
                MiHospedajeLocal.MiHabitacion.IDHabitacion = Convert.ToInt32(cboxHabitacion.SelectedValue);

                MiHospedajeLocal.IDHospedaje = Convert.ToInt32(txtIDHospedaje.Text.Trim());
                string mensaje = string.Format("Esta seguro de Cancerlar la reservación?");

                DialogResult respuesta = MessageBox.Show(mensaje, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    bool Ok = MiHospedajeLocal.Eliminar();

                    if (Ok)
                    {
                        MessageBox.Show("Reservación Cancelada correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarTodo();
                        LlenarListaHospedajes();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la reservación", ":(", MessageBoxButtons.OK);
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

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Globales.MiFormFacturacion = new FrmFacturacion();
            Globales.MiFormFacturacion.Show();
            this.Hide();
        }

        private void txtCantNinos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void txtCantAdultos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void txtDiasHospedaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, false);
        }

        private void LimpiarForm()
        {
            txtIDHospedaje.Clear();
            txtCantNinos.Text = 0.ToString();
            txtCantAdultos.Text = 0.ToString();
            txtDiasHospedaje.Clear();
            dateEntrada.DataBindings.Clear();
            dateSalida.DataBindings.Clear();
            txtEstado.Text = "Pendiente";
            cboxPaquete.SelectedIndex = -1;
            cboxHabitacion.SelectedIndex = -1;
            cboxCliente.SelectedIndex = -1;
            txtTotal.Text = 0.ToString();
            btnFacturar.Enabled = false;
        }

        private void LimpiarTodo()
        {
            LimpiarForm();
            cboxPaquete.Enabled = true;
            cboxHabitacion.Enabled = false;
            cboxHabitacion.DataSource = null;
            cboxHabitacion.Items.Clear();
            cboxHabitacion.SelectedIndex = -1;
            dgvListaHospedajes.ClearSelection();  
            
            CargarListaClientes();
            CargarListaHabitaciones();
            CargarListaPaquetes();
            
            Logica.Models.Paquete MiPaquete = new Logica.Models.Paquete();
            Logica.Models.Habitacion MiHabitacion = new Logica.Models.Habitacion();
            MiPaquete = new Logica.Models.Paquete();
            MiHabitacion = new Logica.Models.Habitacion();

            ActivarAgregar();
            LlenarListaHospedajes();


        }

        private void CargarListaClientes()
        {

            //paso 1 y 1.1 de secuencia usuario rol listar
            Logica.Models.Cliente MiCliente = new Logica.Models.Cliente();

            //paso 2 y 2.5
            DataTable dt = new DataTable();
            //dt = MiCliente.ListarClientes(cboxCliente.Text.Trim());
            dt = MiCliente.ListarClientes();

            //paso 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cboxCliente.ValueMember = "Id";
                cboxCliente.DisplayMember = "D";
                cboxCliente.DataSource = dt;
                cboxCliente.SelectedIndex = -1;

            }

        }

        private void CargarListaHabitaciones()
        {

            //paso 1 y 1.1 de secuencia usuario rol listar
            Logica.Models.Habitacion MiHabitacion = new Logica.Models.Habitacion();

            //paso 2 y 2.5
            DataTable dt = new DataTable();
            //dt = MiHabitacion.ListarHabitaciones(cboxHabitacion.Text.Trim());
            dt = MiHabitacion.ListarHabitaciones();

            //paso 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cboxHabitacion.ValueMember = "Id";
                cboxHabitacion.DisplayMember = "D";
                cboxHabitacion.DataSource = dt;
                cboxHabitacion.SelectedIndex = -1;
            }
        }

        private void CargarListaPaquetes()
        {

            //paso 1 y 1.1 de secuencia usuario rol listar
            Logica.Models.Paquete MiPaquete = new Logica.Models.Paquete();

            //paso 2 y 2.5
            DataTable dt = new DataTable();
            //dt = MiPaquete.ListarPaquetes(cboxPaquete.Text.Trim());
            dt = MiPaquete.ListarPaquetes();
            //paso 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cboxPaquete.ValueMember = "Id";
                cboxPaquete.DisplayMember = "D";
                cboxPaquete.DataSource = dt;
                cboxPaquete.SelectedIndex = -1;
            }

        }


        private void calcularDias()
        {
            int R = 0;

            DateTime fechaEntrada = Convert.ToDateTime(dateEntrada.Text);
            DateTime fechaSalida = Convert.ToDateTime(dateSalida.Text);
            TimeSpan tiempo = fechaSalida.Subtract(fechaEntrada);
            R = Convert.ToInt32(tiempo.Days);
            if (R == 0)
            {
                txtDiasHospedaje.Text = Convert.ToString(1);
            }
            else
            {
                if (R >= 0)
                {
                    txtDiasHospedaje.Text = Convert.ToString(R);
                }
                else
                {
                    MessageBox.Show("La fecha entrada no puede ser superior a la fecha salida",
                                        "Error en Calculo Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiasHospedaje.Text = Convert.ToString(-1);
                }
            }
        }

        private void dateSalida_Leave(object sender, EventArgs e)
        {
            calcularDias(); 
        }

        private void dateEntrada_Leave(object sender, EventArgs e)
        {
            calcularDias();
        }

        private void cboxPaquete_Leave(object sender, EventArgs e)
        {
            
            Logica.Models.Paquete MiPaquete = new Logica.Models.Paquete();
            int IDPaquete = Convert.ToInt32(cboxPaquete.SelectedValue);

            if (IDPaquete > 0)
            {
                cboxPaquete.Enabled = false;
                cboxHabitacion.Enabled = true;
            }

        }

        private float calcularTotalHabitacion()
        {
            float total = 0;

            Logica.Models.Habitacion MiHabitacion = new Logica.Models.Habitacion();
            int IDHabitacion = Convert.ToInt32(cboxHabitacion.SelectedValue);


            MiHabitacion = new Logica.Models.Habitacion();
            MiHabitacion.IDHabitacion = IDHabitacion;
            MiHabitacion = MiHabitacion.PrecioHabitacion();

            if ((float)Convert.ToDouble(MiHabitacion.Precio) <= 0)
            {
                MiHabitacion.IDHabitacion = Convert.ToInt32(txtIDHabitacionTemporal.Text);
                MiHabitacion = MiHabitacion.PrecioHabitacion();
            }

            total = (float)Convert.ToDouble(MiHabitacion.Precio);


            return total;
        }

        private float calcularTotalPaquete()
        {
            float total = 0;

            Logica.Models.Paquete MiPaquete = new Logica.Models.Paquete();
            int IDPaquete = Convert.ToInt32(cboxPaquete.SelectedValue);


            MiPaquete = new Logica.Models.Paquete();
            MiPaquete.IDPaquete = IDPaquete;
            MiPaquete = MiPaquete.PrecioPaquete();

            total = (float)Convert.ToDouble(MiPaquete.Precio);


            return total;
        }


        private void calculatTotal(float precioPaquete, float precioHabitacion)
        {
           
            txtTotal.Text = (precioPaquete + precioHabitacion).ToString();
            
        }

        private bool validarCamposRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtCantNinos.Text.Trim()) &&
                (Convert.ToInt32(txtCantNinos.Text) >= 0) &&
                !string.IsNullOrEmpty(txtCantAdultos.Text.Trim()) &&
                (Convert.ToInt32(txtCantAdultos.Text) > 0) &&
                !string.IsNullOrEmpty(txtDiasHospedaje.Text.Trim()) &&
                (Convert.ToInt32(txtDiasHospedaje.Text) > 0) &&
                !string.IsNullOrEmpty(dateEntrada.Text.Trim()) &&
                !string.IsNullOrEmpty(dateSalida.Text.Trim()) &&
                cboxPaquete.SelectedIndex != -1 &&
                cboxHabitacion.SelectedIndex != -1 &&
                cboxCliente.SelectedIndex != -1)
            {
                R = true;
            }
            else
            {
                //estas validaciones deben ser puntuales para informar al usuario que falla 

                if (string.IsNullOrEmpty(txtCantNinos.Text.Trim()) || (Convert.ToInt32(txtCantNinos.Text) < 0))
                {
                    MessageBox.Show("Debe digitar la catidad de niños o indicar 0", "Error de Validación!",
                        MessageBoxButtons.OK);
                    txtCantNinos.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCantAdultos.Text.Trim()) || (Convert.ToInt32(txtCantAdultos.Text) < 1))
                {
                    MessageBox.Show("Debe digitar la Cantidad de adultos, como minimo 1 indicar", "Error de Validación!",
                        MessageBoxButtons.OK);
                    txtCantAdultos.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtDiasHospedaje.Text.Trim()) || (Convert.ToInt32(txtDiasHospedaje.Text) < 1))
                {
                    MessageBox.Show("Debe seleccionar con las fechas, un valor de al menos 1 día para el hospedaje ",
                        "Error de Validación!", MessageBoxButtons.OK);
                    txtDiasHospedaje.Focus();
                    return false;
                }
                if (cboxPaquete.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar un item de la habitación", "Error de Validación!", MessageBoxButtons.OK);
                    cboxPaquete.Focus();
                    return false;
                }
                if (cboxHabitacion.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar un item de la habitación", "Error de Validación!", MessageBoxButtons.OK);
                    cboxHabitacion.Focus();
                    return false;
                }
                if (cboxCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar un item de la habitación", "Error de Validación!", MessageBoxButtons.OK);
                    cboxCliente.Focus();
                    return false;
                }
            }
            return R;
        }

        private bool validarCamposRequeridosSinHabitacion()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtCantNinos.Text.Trim()) &&
                (Convert.ToInt32(txtCantNinos.Text) >= 0) &&
                !string.IsNullOrEmpty(txtCantAdultos.Text.Trim()) &&
                (Convert.ToInt32(txtCantAdultos.Text) > 0) &&
                !string.IsNullOrEmpty(txtDiasHospedaje.Text.Trim()) &&
                (Convert.ToInt32(txtDiasHospedaje.Text) > 0) &&
                !string.IsNullOrEmpty(dateEntrada.Text.Trim()) &&
                !string.IsNullOrEmpty(dateSalida.Text.Trim()) &&
                cboxPaquete.SelectedIndex != -1 &&
                cboxCliente.SelectedIndex != -1)
            {
                R = true;
            }
            else
            {
                //estas validaciones deben ser puntuales para informar al usuario que falla 

                if (string.IsNullOrEmpty(txtCantNinos.Text.Trim()) || (Convert.ToInt32(txtCantNinos.Text) < 0))
                {
                    MessageBox.Show("Debe digitar la catidad de niños o indicar 0", "Error de Validación!",
                        MessageBoxButtons.OK);
                    txtCantNinos.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCantAdultos.Text.Trim()) || (Convert.ToInt32(txtCantAdultos.Text) < 1))
                {
                    MessageBox.Show("Debe digitar la Cantidad de adultos, como minimo 1 indicar", "Error de Validación!",
                        MessageBoxButtons.OK);
                    txtCantAdultos.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtDiasHospedaje.Text.Trim()) || (Convert.ToInt32(txtDiasHospedaje.Text) < 1))
                {
                    MessageBox.Show("Debe seleccionar con las fechas, un valor de al menos 1 día para el hospedaje ",
                        "Error de Validación!", MessageBoxButtons.OK);
                    txtDiasHospedaje.Focus();
                    return false;
                }
                if (cboxPaquete.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar un item de la habitación", "Error de Validación!", MessageBoxButtons.OK);
                    cboxPaquete.Focus();
                    return false;
                }
                if (cboxCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar un item de la habitación", "Error de Validación!", MessageBoxButtons.OK);
                    cboxCliente.Focus();
                    return false;
                }
            }
            return R;
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
            btnEliminar.Enabled = true; // todo se haria en el modificar, si se va a eliminar el usuario ahi se inactiva 
            btnModificar.Enabled = true;

        }

        private void cboxHabitacion_Leave_1(object sender, EventArgs e)
        {
            Logica.Models.Habitacion MiHabitacion = new Logica.Models.Habitacion();
            int IDHabitacion = Convert.ToInt32(cboxHabitacion.SelectedValue);

            if (IDHabitacion > 0)
            {

                cboxHabitacion.Enabled = false;
            }
            else
            {
                if (Convert.ToUInt32(txtIDHabitacionTemporal.Text) > 0)
                {
                    cboxHabitacion.Enabled = false;
                }
            }

            calculatTotal(calcularTotalPaquete(), calcularTotalHabitacion());
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaHospedajes.SelectedRows.Count == 1)
            {
                LimpiarForm();

                DataGridViewRow MiFila = dgvListaHospedajes.SelectedRows[0];

                int idHospedaje = Convert.ToInt32(MiFila.Cells["CIDHospedaje"].Value);

                MiHospedajeLocal = new Logica.Models.Hospedaje();

                MiHospedajeLocal.IDHospedaje = idHospedaje;

                MiHospedajeLocal = MiHospedajeLocal.ConsultarPorID();

                if (MiHospedajeLocal != null && MiHospedajeLocal.IDHospedaje > 0)
                {
                    txtIDHospedaje.Text = MiHospedajeLocal.IDHospedaje.ToString();
                    txtCantNinos.Text = MiHospedajeLocal.Cant_Ninos.ToString();
                    txtCantAdultos.Text = MiHospedajeLocal.Cant_Adultos.ToString();
                    txtDiasHospedaje.Text = MiHospedajeLocal.DiasHospedaje.ToString();
                    dateEntrada.Text = MiHospedajeLocal.FechaEntrada.ToString();
                    dateSalida.Text = MiHospedajeLocal.FechaSalida.ToString();
                    txtTotal.Text = MiHospedajeLocal.Total.ToString();
                    cboxPaquete.SelectedValue = MiHospedajeLocal.MiPaquete.IDPaquete;
                    cboxHabitacion.SelectedValue = MiHospedajeLocal.MiHabitacion.IDHabitacion;
                    txtIDHabitacionTemporal.Text = MiHospedajeLocal.MiHabitacion.IDHabitacion.ToString();
                    cboxCliente.SelectedValue = MiHospedajeLocal.MiCliente.IDCliente;
                    btnFacturar.Enabled = true;
                    ActivarModificarEliminar();

                    if (MiHospedajeLocal.MiEstado.IDEstado == 7)
                    {
                        txtEstado.Text = "Cancelado";
                        btnModificar.Enabled = false;
                        btnFacturar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                    if (MiHospedajeLocal.MiEstado.IDEstado == 6)
                    {
                        txtEstado.Text = "Procesado";
                        btnModificar.Enabled = false;
                        btnFacturar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                }
            }
        }

        private void LlenarListaHospedajes()
        {
            ListaHospedajes = new DataTable();
            ListaHospedajes = MiHospedajeLocal.Listar(txtBuscar.Text.Trim(), chCancelados.Checked);

            dgvListaHospedajes.DataSource = ListaHospedajes;

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) && txtBuscar.Text.Count() > 0)
            {
                LlenarListaHospedajes();
            }
            else if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                LlenarListaHospedajes();
            }
        }

        private void chCancelados_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaHospedajes();
        }
    }

}
