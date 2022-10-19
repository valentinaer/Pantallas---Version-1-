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
        public string DNI = "";
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string mensaje="";
            

            DNI = txtIngresarDNI.Text;
            string Contraseña = txtContraseña.Text;
            
            //Validamos que esten Vacios (Flujo 1)

            mensaje = Usuario.PedirVacio("DNI", DNI);
            mensaje += Usuario.PedirVacio("Contraseña", Contraseña);
            if (mensaje != "")
            {
                MessageBox.Show(mensaje,"Errores");
            }
            //Validamos DNI debe tener 8 caracteres (Flujo 2)
            else if (DNI.Length != 8)
            {
                MessageBox.Show("El DNI está incompleto debe tener 8 caracteres", "Errores");
               
            }
            //La contraseña excede los 30 caracteres (Flujo )
            else if (Contraseña.Length >30)
            {
                MessageBox.Show("La contraseña debe tener como máximo 30 caracteres","Errores");
            }
            else if (DNI == "12345678" && Contraseña == "1234") //Con Saldo
            {
                this.Hide();
                MessageBox.Show("Bienvenido/a " + DNI);
                new MenuPrincipal().ShowDialog();
            }
            else if (DNI == "87654321" && Contraseña == "1234") //Sin Saldo
            {
                this.Hide();
                MessageBox.Show("Bienvenido/a " + DNI);
                new MenuPrincipal().ShowDialog();
            }     
            else if (DNI == "12345678" && Contraseña == "1234")
            {
                this.Hide();
                MessageBox.Show("Bienvenido/a " + DNI);
                new MenuPrincipal().ShowDialog();
            }

            Usuario.DNI = DNI;
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