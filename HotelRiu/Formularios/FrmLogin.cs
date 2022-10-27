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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierra completamente la app
            Application.Exit();
        }

        private void btnVerPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasennia.UseSystemPasswordChar = false;
        }
        private void btnVerPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasennia.UseSystemPasswordChar = true;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //TODO: se debe validar el ingreso del usuario
            //si la validacion es correcta permitiria dejar ingresar al usuario al sistema principal 
            Globales.MiformPrincipal.Show();
            this.Hide();
        }

        
    }
}
