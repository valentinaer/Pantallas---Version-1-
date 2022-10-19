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
            int[] numerosdeTrackeo = {123, 456, 789};
            string numeroTrack = textBox1.Text;
            Console.WriteLine($"codigo de track: {numeroTrack}");
            mensaje += Usuario.PedirVacio("tracking", numeroTrack);
            mensaje += Usuario.PedirEntero("tracking", 0 ,1000, numeroTrack);

            if (mensaje != "")
            {
                MessageBox.Show(mensaje, "Errores");
            }
            //FALTA QUE SEA EFECTIVAMENTE UN NUMERO DE TRACKEO REAL
            else
            {
                //AGREGAR QUE MUESTRE LO QUE TIENE QUE HACER

                foreach (int i in numerosdeTrackeo)
                {
                    if (numerosdeTrackeo.Contains(int.Parse(numeroTrack)))
                    {
                        if (int.Parse(numeroTrack) == 123)
                        {
                            MessageBox.Show("Recibida", "Estado de servicio");
                        }
                        else if (int.Parse(numeroTrack) == 456)
                        {
                            MessageBox.Show("En Tránsito", "Estado de servicio");
                        }
                        else
                        {
                            MessageBox.Show("Cerrada", "Estado de servicio");
                        }
                    }
                }
            }  
        }
    }
}
