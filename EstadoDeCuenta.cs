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
    public partial class EstadoDeCuenta : Form
    {
        public EstadoDeCuenta()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void EstadoDeCuenta_Load(object sender, EventArgs e)
        {
            lblNombreCliente.Text = "------";
            lblCuit.Text = "25-20452018-5";
            lblFecha.Text = "14/10/2022";
            lblNroFactura.Text = "16-0461";
            lblEstado.Text = "Pago";
            lblTotalFactura.Text = "$875,99";
            lblSaldoTotal.Text = "$0,00";
            lblFechaActual.Text = Convert.ToString(DateTime.Now);

        }
    }
}
