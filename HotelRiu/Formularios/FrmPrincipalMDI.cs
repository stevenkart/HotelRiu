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
    public partial class FrmPrincipalMDI : Form
    {
        public Logica.Models.Empleado MiEmpleadoLocal { get; set; }
        public Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public Logica.Models.Ocupacion MiOcupacionLocal { get; set; }
        public FrmPrincipalMDI()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            MiEmpleadoLocal = new Logica.Models.Empleado();
            MiOcupacionLocal = new Logica.Models.Ocupacion();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //en el caso del form de gestión de usuarios es necesario establecerlo 
            // en variables globales

            //si queremos que un formulario se muestre solo una vez deberiamos 
            // de verificar que este visible o no, y en caso de que lo este se reinstancia de nuevo y se muestra

            // el simbolo ! indica negacion, niega una condicion logica
            if (!Globales.MiFormMantUsuarios.Visible)
            {
                Globales.MiFormMantUsuarios = new FrmUsuariosGestion();
                Globales.MiFormMantUsuarios.Show();
            }

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Globales.MiformPrincipal.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            */
            lblUsuarioLogueado.Text = null;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void ocupacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.MiFormMantOcupaciones = new FrmOcupacionesGestion();
            Globales.MiFormMantOcupaciones.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.MiFormMantEmpleados = new FrmEmpleadosGestion();
            Globales.MiFormMantEmpleados.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.MiFormMantClientes = new FrmClientesGestion();
            Globales.MiFormMantClientes.Show();
        }

        private void hospedajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.MiFormMantHospedajes= new FrmHospedajesGestion();
            Globales.MiFormMantHospedajes.Show();
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.MiFormMantHabitaciones = new FrmHabitaciones();
            Globales.MiFormMantHabitaciones.Show();
        }

        private void paquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Globales.MiFormMantPaquetes = new FrmPaquetesGestion();
            Globales.MiFormMantPaquetes.Show();
        }

        private void metodosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.MiFormMantMetodoPago = new FrmMetodoPagoGestion();
            Globales.MiFormMantMetodoPago.Show();
        }

        private void FrmPrincipalMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globales.MiFormFacturacion = new FrmFacturacion();
            Globales.MiFormFacturacion.Show();
        }

        private void reimpresiónDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteFactura frmReporte = new FrmReporteFactura();
            frmReporte.ShowDialog();
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            //asignar al label de fecha y hora el valor en formato extendido de la fecha 
            // y ademas la hora

            string fecha = DateTime.Now.Date.ToLongDateString();
            string hora = DateTime.Now.ToLongTimeString();

            lblFechaHora.Text = fecha + " / " + hora;
        }

        private void FrmPrincipalMDI_Load(object sender, EventArgs e)
        {

            int ID = Globales.MiUsuarioGlobal.IDUsuario;
            MiUsuarioLocal = new Logica.Models.Usuario();

            MiUsuarioLocal.IDUsuario = ID;
            MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID();

            //---------------------------------------------------------------------------**//
            int IDEmpleado = MiUsuarioLocal.MiEmpleado.IDEmpleado;
            MiEmpleadoLocal = new Logica.Models.Empleado();

            MiEmpleadoLocal.IDEmpleado = IDEmpleado;
            MiEmpleadoLocal = MiEmpleadoLocal.ConsultarPorID();

            //---------------------------------------------------------------------------**//
            int IDOcupacion = MiEmpleadoLocal.MiOcupacion.IDOcupacion;
            MiOcupacionLocal = new Logica.Models.Ocupacion();

            MiOcupacionLocal.IDOcupacion = IDOcupacion;
            MiOcupacionLocal = MiOcupacionLocal.ConsultarPorID();


            //mostrar usuario logueado
            string InfoUsuario = string.Format("{0} ({1})",
                MiUsuarioLocal.NombreUsuario.ToString(),
                MiOcupacionLocal.DescripcionRol.ToString());
            lblUsuarioLogueado.Text = InfoUsuario;
            InfoUsuario = null;

            //se debe filtrar las opciones de acceso a menu segun el rol que se tenga
            int valor = MiOcupacionLocal.IDOcupacion;
            switch (valor)
            {
                case 1:
                    
                    //seria tipo Cajero
              
                    mnuUsuarios.Visible = false;
                    mnuEmpleados.Visible = false;
                    mnuOcupaciones.Visible = false;
                    
                    mnuPaquetes.Visible = false;
                    mnuMetodosDePago.Visible = false;
       

                    break;
                case 2:
                    //No hace falta ocultar opciones ya que es admin

                    break;
            }

            tmrFechaHora.Enabled = true;
        }

        private void mnuAcercaDeTool_Click(object sender, EventArgs e)
        {
            string msj = "Proyecto Final Programación 5  \n\n" +
                "Alumnos: Robert Chaves P. & Steven Carrillo J. \n\n" +
                "Tema: Sistema Facturación - Hospedajes Hotel Riu \n\n" +
                "Prof.: Allan Delgado Chavarria \n\n" +
                " 'III Cuatrimestre 2022' \n\n";
            MessageBox.Show(msj, "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
