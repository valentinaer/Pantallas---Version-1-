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
            new MenuPrincipal().ShowDialog();
            
        }
    }
}