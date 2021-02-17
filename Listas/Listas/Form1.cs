using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form1 : Form
    {
        DatosAlumno _datos;

        public Form1()
        {
            InitializeComponent();
            _datos = new DatosAlumno();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.Nombre = textBox1.Text;
            a.Telefono = textBox2.Text;
            a.Direccion = textBox3.Text;

            _datos.Agregar(a);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _datos.Alumnos;

            comboBox1.DataSource = null;
            comboBox1.DataSource = _datos.Alumnos;
            comboBox1.DisplayMember = "Nombre";

            listBox1.DataSource = null;
            listBox1.DataSource = _datos.Alumnos;
            listBox1.DisplayMember = "Nombre";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
