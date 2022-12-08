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
    public partial class FrmFacturacion : Form
    {
        //Objetos locales
        public Logica.Models.Factura MiFacturaLocal { get; set; }
        public Logica.Models.Cliente MiClienteLocal { get; set; }
        public DataTable DtListaHospedaje { get; set; }

        public FrmFacturacion()
        {
            InitializeComponent();
            MiFacturaLocal = new Logica.Models.Factura();
            MiClienteLocal = new Logica.Models.Cliente();

            DtListaHospedaje = new DataTable();
            DtListaHospedaje = MiFacturaLocal.CargarEsquemaListaDetalle();
            
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            
            LlenarComBoTiposFactura();
            Limpiar();
        }

        private void LlenarComBoTiposFactura()
        {
            DataTable dt = new DataTable();

            dt = MiFacturaLocal.MiMetodoPago.Lista();

            if (dt != null && dt.Rows.Count > 0)
            {
                cboxMetodo.ValueMember = "ID";
                cboxMetodo.DisplayMember = "D";

                cboxMetodo.DataSource = dt;

                cboxMetodo.SelectedIndex = -1;
            }
        }
        private void Limpiar()
        {
            txtClienteID.Clear();
            lblNombre.Text = String.Empty;
            lblApellidos.Text = String.Empty;
            lblCedula.Text = String.Empty;
            lblTelefono.Text = String.Empty;
            lblCorreo.Text = String.Empty;
            txtDireccion.Clear();
            cboxMetodo.SelectedIndex = -1;

            txtSubTotal.Text = "0";
            txtImpuestos.Text = "0";
            txtTotal.Text = "0";

            DtListaHospedaje = MiFacturaLocal.CargarEsquemaListaDetalle();

            dgvLista.DataSource = DtListaHospedaje;

        }

        private void mnuAgregarHospedaje_Click(object sender, EventArgs e)
        {

            Form FormBuscarHospedaje = new FrmHospedajeBuscar();

            DialogResult resp = FormBuscarHospedaje.ShowDialog();

            if (resp == DialogResult.OK)
            {
                if (DtListaHospedaje.Rows.Count > 0)
                {
                    dgvLista.DataSource = DtListaHospedaje;
                    dgvLista.SelectAll();
                    //dgvLista.ClearSelection();

                    Totalizar();
                    mnuAgregarHospedaje.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la fila", "Error Inesperado", MessageBoxButtons.OK);
                }
            }
        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtClienteID.Text.Trim()) > 0)
            {
                MiClienteLocal = new Logica.Models.Cliente();

                MiClienteLocal.IDCliente = Convert.ToInt32(txtClienteID.Text.Trim());

                //una vez tenemos el valor del IDCliente, se llama a la funcion 
                //de consultar por ID que entrega como retorno un objeto de tipo cliente
                //en este caso voy a reutilizar el objeto de cliente local
                //para cargar datos por medio de la funcion 

                MiClienteLocal = MiClienteLocal.ConsultarPorID();

                if (MiClienteLocal != null && MiClienteLocal.IDCliente > 0)
                {
                    //una vez me asegure que el objeto posee datos, entonces se procede a representar
                    //en pantalla
                    lblNombre.Text = MiClienteLocal.Nombre.ToString();
                    lblCedula.Text = MiClienteLocal.Cedula.ToString();
                    lblApellidos.Text = MiClienteLocal.Apellidos.ToString();
                    lblCorreo.Text = MiClienteLocal.Correo.ToString();
                    lblTelefono.Text = MiClienteLocal.Telefono.ToString();
                    txtDireccion.Text = MiClienteLocal.Direccion.ToString();
                }
            }
            else
            {
                lblNombre.Text = ".";
                lblCedula.Text = ".";
                lblApellidos.Text = ".";
                lblCorreo.Text = ".";
                lblTelefono.Text = ".";
                txtDireccion.Text = ".";
            }
            
        }

        private void mnuModificarHospedaje_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void mnuQuitarDatos_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void Totalizar()
        {
            MiFacturaLocal.SubTotal = 0;
            MiFacturaLocal.Iva = 0;
            MiFacturaLocal.Total = 0;

            if (DtListaHospedaje.Rows.Count > 0)
            {
                foreach (DataRow item in DtListaHospedaje.Rows)
                {
                    //el += lo que hace es sumar al valor anterior un valor adicional
                    // sería lo mismo que hacer: SubTotal = Subtotal + algo
                    MiFacturaLocal.SubTotal += (float)Convert.ToDouble(item["Total"]);
                    MiFacturaLocal.Iva = (MiFacturaLocal.SubTotal * (float)Convert.ToDouble(0.13));
                    MiFacturaLocal.Total += MiFacturaLocal.SubTotal + MiFacturaLocal.Iva;
                }
            }

            txtSubTotal.Text = string.Format("{0:N2}", MiFacturaLocal.SubTotal);
            txtImpuestos.Text = string.Format("{0:N2}", MiFacturaLocal.Iva);
            txtTotal.Text = string.Format("{0:N2}", MiFacturaLocal.Total);
        }

        private bool ValidarFactura()
        {
            bool R = false;

            if (cboxMetodo.SelectedIndex > -1 &&
                DtListaHospedaje.Rows.Count > 0)
            {
                R = true;
            }

            //TODO: validar casos contrarios con el else

            return R;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //validar requerimientos mínimos 
            if (ValidarFactura())
            {
                DataGridViewRow MiFila = dgvLista.SelectedRows[0];
                int IDHospedaje = Convert.ToInt32(MiFila.Cells["CIDHospedaje"].Value);

                string mensaje = string.Format("Esta seguro de procesar la factura de la reservacion: # {0}?", IDHospedaje);

                DialogResult respuesta = MessageBox.Show(mensaje, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    

                    //cuando tenemos una estructura de encabezado-detalle 
                    //como la factura, primero debemos agreagar el encabezado
                    //en su tabla respectiva y obtener el ID que se genera 
                    //en el PK. 
                    //Luego usando ese ID se recorre la lista del detalle 
                    //y se hace el insert en la tabla de detalle con FK = ID

                    MiFacturaLocal.MiMetodoPago.IDMetodoPago = Convert.ToInt32(cboxMetodo.SelectedValue);
                    //como el nombre del clientes o el nombre del tipo de factura no son necesarios para hacer el Insert
                    //se pueden omitir en este punto. 

                    MiFacturaLocal.MiUsuario.IDUsuario = Globales.MiUsuarioGlobal.IDUsuario;

                    MiFacturaLocal.MiHospedaje.IDHospedaje = IDHospedaje;


                    if (MiFacturaLocal.Agregar() > 0)
                    {

                        MessageBox.Show("Factura procesada correctamente!", ":)", MessageBoxButtons.OK);

                        //TODO: Presentar gráficamente un reporte de la factura en formato POS (punto de venta) 

                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show("Factura NO fue procesada correctamente!", "Error en Transaccion :( ",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("Factura NO puede ser procesada correctamente!, " +
                    "Hospedaje no agregado o Metodo de pago no seleccionado", "Error en Transaccion :( ",
                                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
