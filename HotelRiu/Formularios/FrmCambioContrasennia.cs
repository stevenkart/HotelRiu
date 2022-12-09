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
    public partial class FrmCambioContrasennia : Form
    {
        Logica.Models.Usuario MiUsuario;

        public FrmCambioContrasennia()
        {
            InitializeComponent();
            MiUsuario = new Logica.Models.Usuario();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosVacios())
            {
                if (txtContrasennia.Text.Trim() == txtConfirm.Text.Trim())
                {
                    if (MiUsuario.ResetearContrasennia(txtUser.Text.Trim(), Convert.ToInt32(txtCode.Text.Trim()),
                        txtContrasennia.Text.Trim()))
                    {
                        string msj = "Las Contrasenia del usuario " + txtUser.Text.Trim() + " se ha actualizado correctamente!";
                        MessageBox.Show(msj, " :)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();

                        FrmLogin frmLogin = new FrmLogin();
                        frmLogin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, la contrasenia no pudo ser cambiada," +
                            " favor validar los datos ingresados.", " :(",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
                else
                {
                    MessageBox.Show("Las Contrasenia no coinciden, favor validar los datos ingresados.", " :(",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDatosVacios()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtUser.Text.Trim()) &&
                !string.IsNullOrEmpty(txtCode.Text.Trim()) &&
                !string.IsNullOrEmpty(txtContrasennia.Text.Trim()) &&
                !string.IsNullOrEmpty(txtConfirm.Text.Trim()))             
            {
                R = true;
            }
            else
            {
                //estas validaciones deben ser puntuales para informar al usuario que falla 

                if (string.IsNullOrEmpty(txtUser.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre usuario", "Error de Validación!", MessageBoxButtons.OK);
                    txtUser.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCode.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el código enviado a su correo", "Error de Validación!", MessageBoxButtons.OK);
                    txtCode.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la contraseña nueva", "Error de Validación!", MessageBoxButtons.OK);
                    txtContrasennia.Focus();
                    return false;

                }
                if (string.IsNullOrEmpty(txtConfirm.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la confirmación de la nueva contraseña", "Error de Validación!", MessageBoxButtons.OK);
                    txtConfirm.Focus();
                    return false;
                }
            }
            return R;


        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }


        private void Limpiar()
        {
            txtUser.Clear();
            txtCode.Clear();
            txtConfirm.Clear();
            txtContrasennia.Clear();
            MiUsuario = new Logica.Models.Usuario();
        }


    }
}
