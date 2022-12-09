using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRiu.Formularios
{
    public partial class FrmRecuperarContrasennia : Form
    {


        Logica.Models.Usuario MiUsuario;

        public FrmRecuperarContrasennia()
        {
            InitializeComponent();
            MiUsuario = new Logica.Models.Usuario();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void Limpiar()
        {
            txtUser.Clear();
            MiUsuario = new Logica.Models.Usuario();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void FrmRecuperarContrasennia_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            MiUsuario = new Logica.Models.Usuario();

            MiUsuario.NombreUsuario = txtUser.Text.Trim();

            MiUsuario = MiUsuario.ConsultarPorNombreUsuario();

            if (MiUsuario != null && MiUsuario.IDUsuario > 0)
            {
                //una vez me asegure que el objeto posee datos, entonces se procede
                // a generar un codigo y luego enviarselo por medio de correo al usuario

                Random r = new Random();
                int randNum = r.Next(1000000);
                string code = randNum.ToString("D6");

                if (MiUsuario.EnviarCodigoRecuperacion(code))
                {
                    string Error = "";
                    string mensaje = string.Format("Reciba un cordial saludo de parte de Hotel Riu. \n\n" +
                        "Su Código de Recuperación para la contraseña es el: {0}", code);
                    StringBuilder MensajeBuilder = new StringBuilder();
                    MensajeBuilder.Append(mensaje);
                    EnviarCorreo(MensajeBuilder, DateTime.Now, "hotelesriu@riu.com",
                        MiUsuario.MiEmpleado.Correo, "Código de Recuperación de Contraseña", out Error);

                    FrmCambioContrasennia frmCambioContrasennia = new FrmCambioContrasennia();
                    frmCambioContrasennia.Show();
                    Limpiar(); 
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("No se pudo generar el codigo de recuperacion al usuario \n\n" +
                  "por favor intenta nuevamente, o informa a gerencia sobre el inconveniente presentado.", " :(", 
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se obtuvo respuesta por parte de la Base de datos, de la \n\n" +
                    "Informacion del usuario ingresado.", ' :(', MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void EnviarCorreo(StringBuilder Mensaje, DateTime
          FechaEnvio, string De, string Para, string Asunto, out string Error)
        {
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("Este Correo ha sido enviado el dia {0:dd/MM/yyyy} a las " +
                    "{0:HH:mm:ss} Hrs:  \n\n", FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject = Asunto;
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.mailtrap.io");
                smtp.Port = 2525;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("fa9bb21372400d", "13bf96a95ff30b");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Correo Enviado Satisfactoriamente, por favor verificalo!";
                MessageBox.Show(Error, " :) ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Error = "Error" + ex.Message;
                MessageBox.Show(Error, " :) ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void FrmRecuperarContrasennia_Load(object sender, EventArgs e)
        {

        }
    }
}

