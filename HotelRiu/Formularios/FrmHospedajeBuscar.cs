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
    public partial class FrmHospedajeBuscar : Form
    {

        DataTable DtLista { get; set; }
        Logica.Models.Hospedaje MiHospedajeLocal { get; set; }

        public FrmHospedajeBuscar()
        {
            InitializeComponent();
            DtLista = new DataTable();

            MiHospedajeLocal = new Logica.Models.Hospedaje();
        }

        private void LlenarLista()
        {
            DtLista = new DataTable();
            DtLista = MiHospedajeLocal.ListarPendientes(txtBuscar.Text.Trim(), true);

            dgvListaHospedajes.DataSource = DtLista;
        }

        private void FrmHospedajeBuscar_Load(object sender, EventArgs e)
        {
            LlenarLista();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Count() > 0 || string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                LlenarLista();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvListaHospedajes.SelectedRows.Count == 1)
            {
                DataGridViewRow FilaSelected = dgvListaHospedajes.SelectedRows[0];
                int IdCliente = Convert.ToInt32(FilaSelected.Cells["CIDCliente"].Value);
                Globales.MiFormFacturacion.txtClienteID.Text = Convert.ToString(IdCliente);

                DataRow NuevaFilaEnFacturacion = Globales.MiFormFacturacion.DtListaHospedaje.NewRow();

                NuevaFilaEnFacturacion["IDHospedaje"] = Convert.ToInt32(FilaSelected.Cells["CIDHospedaje"].Value);
                NuevaFilaEnFacturacion["Cant_ninos"] = Convert.ToInt32(FilaSelected.Cells["CCant_ninos"].Value);
                NuevaFilaEnFacturacion["Cant_adultos"] = Convert.ToInt32(FilaSelected.Cells["CCant_adultos"].Value);
                NuevaFilaEnFacturacion["DiasHospedaje"] = Convert.ToInt32(FilaSelected.Cells["CDiasHospedaje"].Value);
                NuevaFilaEnFacturacion["FechaEntrada"] = Convert.ToDateTime(FilaSelected.Cells["CFechaEntrada"].Value);
                NuevaFilaEnFacturacion["FechaSalida"] = Convert.ToDateTime(FilaSelected.Cells["CFechaSalida"].Value);
                NuevaFilaEnFacturacion["Total"] = (float) Convert.ToDouble(FilaSelected.Cells["CTotal"].Value);
                NuevaFilaEnFacturacion["IDPaquete"] = Convert.ToInt32(FilaSelected.Cells["CIDPaquete"].Value);
                NuevaFilaEnFacturacion["IDHabitacion"] = Convert.ToInt32(FilaSelected.Cells["CIDHabitacion"].Value);
                NuevaFilaEnFacturacion["IDCliente"] = Convert.ToInt32(FilaSelected.Cells["CIDCliente"].Value);
                NuevaFilaEnFacturacion["IDEstado"] = Convert.ToInt32(FilaSelected.Cells["CIDEstado"].Value);

                Globales.MiFormFacturacion.DtListaHospedaje.Rows.Add(NuevaFilaEnFacturacion);

                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
