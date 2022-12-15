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
    public partial class FrmReporteFactHospedaje : Form
    {
        public Logica.Models.Hospedaje MiHospedajeLocal { get; set; }
        public FrmReporteFactHospedaje()
        {
            InitializeComponent();
            MiHospedajeLocal = new Logica.Models.Hospedaje();
        }

        private void FrmReporteFactHospedaje_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
