using System;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionDeEscritorioHugo2
{
    public partial class Form2 : Form
    {
        private string txtPredet1 = "1° AÑO";
        private string txtPredet2 = "2° AÑO";
        private string txtPredet3 = "3° AÑO";
        private string txtPredet4 = "4° AÑO";
        private string txtPredet5 = "5° AÑO";
        private string txtPredet6 = "6° AÑO";
        private string txtPredetEx = "EX-ALUMNOS";


        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "Buscar por DNI o NOMBRE y APELLIDO del alumno";

            //Barra de busqueda
            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;


            //ComboBoxes de Años
            //Primer año
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add(txtPredet1);
            comboBox1.SelectedIndex = 0;
            comboBox1.Click += ComboBox1_Click;
            //Segundo Año
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Add(txtPredet2);
            comboBox2.SelectedIndex = 0;
            comboBox2.Click += ComboBox2_Click;
            //Tercer Año
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Items.Add(txtPredet3);
            comboBox3.SelectedIndex = 0;
            comboBox3.Click += ComboBox3_Click;
            //Cuarto Año
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.Items.Add(txtPredet4);
            comboBox4.SelectedIndex = 0;
            comboBox4.Click += ComboBox4_Click;
            //Quinto Año
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.Items.Add(txtPredet5);
            comboBox5.SelectedIndex = 0;
            comboBox5.Click += ComboBox5_Click;
            //Sexto Año
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.Items.Add(txtPredet6);
            comboBox6.SelectedIndex = 0;
            comboBox6.Click += ComboBox6_Click;
            //Ex-Alumnos
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.Items.Add(txtPredetEx);
            comboBox7.SelectedIndex = 0;
            comboBox7.Click += ComboBox7_Click;
        }

        //PrimerAñoLista
        private void ComboBox1_Click(object sender, EventArgs e)
        {
            //Limpia el texto predeterminado cuando el usuario hace click en el combobox
            if (comboBox1.Text == txtPredet1)
            {
                comboBox1.Items.RemoveAt(0);
                comboBox1.SelectedIndex = -1; //Deja el cb vacio
            }
        }
        //SegundoAñoLista
        private void ComboBox2_Click(object sender, EventArgs e)
        {
            //Limpia el texto predeterminado cuando el usuario hace click en el combobox
            if (comboBox2.Text == txtPredet2)
            {
                comboBox2.Items.RemoveAt(0);
                comboBox2.SelectedIndex = -1; //Deja el cb vacio
            }
        }
        //TercerAñoLista
        private void ComboBox3_Click(object sender, EventArgs e)
        {
            //Limpia el texto predeterminado cuando el usuario hace click en el combobox
            if (comboBox3.Text == txtPredet3)
            {
                comboBox3.Items.RemoveAt(0);
                comboBox3.SelectedIndex = -1; //Deja el cb vacio
            }
        }
        //CuartoAñoLista
        private void ComboBox4_Click(object sender, EventArgs e)
        {
            //Limpia el texto predeterminado cuando el usuario hace click en el combobox
            if (comboBox4.Text == txtPredet4)
            {
                comboBox4.Items.RemoveAt(0);
                comboBox4.SelectedIndex = -1; //Deja el cb vacio
            }
        }
        //QuintoAñoLista
        private void ComboBox5_Click(object sender, EventArgs e)
        {
            //Limpia el texto predeterminado cuando el usuario hace click en el combobox
            if (comboBox5.Text == txtPredet5)
            {
                comboBox5.Items.RemoveAt(0);
                comboBox5.SelectedIndex = -1; //Deja el cb vacio
            }
        }
        //SextoAñoLista
        private void ComboBox6_Click(object sender, EventArgs e)
        {
            //Limpia el texto predeterminado cuando el usuario hace click en el combobox
            if (comboBox6.Text == txtPredet6)
            {
                comboBox6.Items.RemoveAt(0);
                comboBox6.SelectedIndex = -1; //Deja el cb vacio
            }
        }
        //EX-ALUMNOSLista
        private void ComboBox7_Click(object sender, EventArgs e)
        {
            //Limpia el texto predeterminado cuando el usuario hace click en el combobox
            if (comboBox7.Text == txtPredetEx)
            {
                comboBox7.Items.RemoveAt(0);
                comboBox7.SelectedIndex = -1; //Deja el cb vacio
            }
        }


        private void TextBox1_Enter(object sender, EventArgs e)
        {
            // Limpiar el texto del TextBox cuando el usuario hace clic en él
            if (textBox1.Text == "Buscar por DNI o NOMBRE y APELLIDO del alumno")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText; // Opcional, para restaurar el color predeterminado del texto
            }
        }
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            // Restaurar el texto predeterminado si el usuario no ha ingresado nada
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Buscar por DNI o NOMBRE y APELLIDO del alumno";
                textBox1.ForeColor = SystemColors.GrayText; // Opcional, para mostrar el texto predeterminado en un color diferente
            }
        }

        private void btnInicioEstudiantes_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2.
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

