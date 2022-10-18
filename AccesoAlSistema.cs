using System.Net;

namespace grupoB_TP
{
    public partial class AccesoAlSistema : Form
    {
        public AccesoAlSistema()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string mensaje="";
                        
            string DNI = txtIngresarDNI.Text;
            string Contraseña = txtContraseña.Text;
            //Validamos que esten Vacios

            mensaje = Usuario.PedirVacio("DNI", DNI) + "/n";
            mensaje += Usuario.PedirVacio("Contraseña", Contraseña) + "/n";

            if (DNI.Length != 8)
            {
                mensaje += "El DNI está incompleto debe tener 8 caracteres";
            }
            if (Contraseña.Length >30)
            {
                mensaje += "La contraseña debe tener como máximo 30 caracteres";
            }


            mensaje += Usuario.PedirEntero("DNI", 0, 99999999, DNI) +"/n";
            if(mensaje !="" )
            {
                MessageBox.Show(mensaje);
            }
            
            else if (DNI == "12345678" && Contraseña == "1234")
            {
                this.Hide();
                MessageBox.Show("Bienvenido/a " + DNI);
                new MenuPrincipal().ShowDialog();

            }
            /*
            else
            
                try
                {
                    int dni = int.Parse(txtIngresarDNI.Text);
                    if (dni < 0 || dni > 99999999)
                    {
                        MessageBox.Show("DNI incorrecto");
                    }
                    else
                    {
                        //if the user is in the database, the system will show a message
                        if (txtIngresarDNI.Text == "12345678" && txtContraseña.Text == "1234")
                        {
                            //hide initializecomponent
                            this.Hide();
                            MessageBox.Show("Bienvenido/a " + txtIngresarDNI.Text);
                            new MenuPrincipal().ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("DNI incorrecto");
                }
            }

            */
        }


        /*
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (IsNullOrEmpty.(txtIngresarDNI.Text))
            {


            }

        }
        */
    }
}