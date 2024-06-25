namespace merge_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_message_Click(object sender, EventArgs e)
        {
            string texto = "Fabio";
            MessageBox.Show("Bem-vindo ao GitHUB");
            MessageBox.Show("Olá desenvolvedor " + texto);
            MessageBox.Show("mais um texto");
        }
    }
}