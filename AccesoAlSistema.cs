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

            // user must enter a DNI as interger in between 0 and 99999999
            // pasword must exist in the database
            // if the user is not in the database, the system will show a message

            if (txtIngresarDNI.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
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