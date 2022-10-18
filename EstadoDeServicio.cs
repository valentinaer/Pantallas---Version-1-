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
    public partial class EstadoDeServicio : Form
    {
        public EstadoDeServicio()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            string numeroTrack = textBox1.Text;
            Console.WriteLine($"codigo de track: {numeroTrack}");
            mensaje += Usuario.PedirVacio("Numero de tracking", numeroTrack);
            mensaje += Usuario.PedirEntero("Numero de tracking", 0, 1000, numeroTrack);
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }
            else
            {

            }
        }
    }
}
