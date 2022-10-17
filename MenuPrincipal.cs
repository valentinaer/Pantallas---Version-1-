using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupoB_TP
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (rboSolicitarServicioNacional.Checked)
            {
                this.Hide();
                new SolicitudDeServicioNacional().ShowDialog();
            }
            if (rboSolicitarServicioInternacional.Checked)
            {
                this.Hide();
                new SolicitudDeServicioInternacional().ShowDialog();
            }
            if (rboConsultarEstadoDeServicio.Checked)
            {
                this.Hide();
                new EstadoDeServicio().ShowDialog();
            }
            if (rboConsultarEstadoDeCuenta.Checked)
            {
                this.Hide();
                new EstadoDeCuenta().ShowDialog();
            }
        }
    }
}
