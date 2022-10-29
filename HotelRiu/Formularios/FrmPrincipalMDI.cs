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
            Globales.MiformPrincipal.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
