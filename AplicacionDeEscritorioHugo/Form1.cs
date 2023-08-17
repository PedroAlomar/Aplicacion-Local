namespace AplicacionDeEscritorioHugo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2.
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2.
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}