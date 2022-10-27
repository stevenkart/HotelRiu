using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRiu
{
    public class Globales
    {

        //los objetos seran accesible en su totalidad por la aplicacion ademas 
        //esta clase se instancia automaticamente

        //el form principal se puede invocar desde cualquier lugar 
        //(login en nuestro caso)

        public static Form MiformPrincipal = new Formularios.FrmPrincipalMDI();

        public static Formularios.FrmUsuariosGestion MiFormMantUsuarios = new Formularios.FrmUsuariosGestion();

    }
}
