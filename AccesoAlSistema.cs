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
            string mensaje;
                        
            string DNI = txtIngresarDNI.Text;
            //Validamos que esten Vacios
            if (txtIngresarDNI.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
            }

            if (txtIngresarDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI está incompleto debe tener 8 caracteres");
            }
            mensaje = Usuario.PedirVacio("DNI", txtIngresarDNI.Text) +"/n";
            mensaje += Usuario.PedirVacio("Contraseña", txtContraseña.Text)+ "/n";
            mensaje += Usuario.PedirLongitudFija("DNI", 8, txtIngresarDNI.Text) +"/n";
            mensaje += Usuario.PedirEntero("DNI", 0, 99999999)+"/n";

            /*
            else
            {
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