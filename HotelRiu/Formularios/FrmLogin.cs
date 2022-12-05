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
        Logica.Models.Usuario MiUsuario;
        public FrmLogin()
        {
            InitializeComponent();
            MiUsuario = new Logica.Models.Usuario();
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
            if (!string.IsNullOrEmpty(txtNombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(txtContrasennia.Text.Trim()))
            {
                string u = txtNombreUsuario.Text.Trim();
                string p = txtContrasennia.Text.Trim();

                int IdLoginOK = MiUsuario.ValidarLogin(u, p);

                if (IdLoginOK > 0)
                {
                    FrmPrincipalMDI MiFormPrincipal = new FrmPrincipalMDI();
                    MiFormPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error validación",
                        MessageBoxButtons.OK);
                }

            }
            
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
