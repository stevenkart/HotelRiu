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
        public FrmPrincipalMDI()
        {
            InitializeComponent();
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
    }
}
