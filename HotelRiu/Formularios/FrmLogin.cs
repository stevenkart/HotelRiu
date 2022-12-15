using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            //Limpiar Globales para buscar el nuevo login del usuario y refrescar info
            Globales.MiUsuarioGlobal.IDUsuario = 0;
            Globales.MiUsuarioGlobal.NombreUsuario = null;
            Globales.MiUsuarioGlobal.Contrasenia = null;
            Globales.MiUsuarioGlobal.MiEmpleado.IDEmpleado = 0;


            if (!string.IsNullOrEmpty(txtNombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(txtContrasennia.Text.Trim()))
            {
                string u = txtNombreUsuario.Text.Trim();
                string p = txtContrasennia.Text.Trim();

                int IdLoginOK = Globales.MiUsuarioGlobal.ValidarLogin(u, p);

                if (IdLoginOK > 0)
                {
                    //hay permiso de ingresar al sistema
                    Globales.MiUsuarioGlobal.IDUsuario = IdLoginOK;

                    Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ConsultarPorID();
                    Globales.MiformPrincipal = new Formularios.FrmPrincipalMDI();
                    Globales.MiformPrincipal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error validación",
                        MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Usuario y Contraseña no pueden estar vacios", "Error validación",
                       MessageBoxButtons.OK);
            }
            
        }

        
        /*
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Globales.MiformPrincipal.Show();
            this.Hide();

        }
        */

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {    
            FrmRecuperarContrasennia frmRecuperarContrasennia = new FrmRecuperarContrasennia();
            frmRecuperarContrasennia.Show();
            this.Hide();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            FrmCambioContrasennia rrmCambioContrasennia = new FrmCambioContrasennia();
            rrmCambioContrasennia.Show();
            this.Hide();
        }
    }
}
