using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace LINKQ3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext bsa = new DataClasses1DataContext();

        private void label5_Click(object sender, EventArgs e)
        {

        }
        void cargarGrid()
        {
            var x = from p in bsa.Pacientes select p;

            dataGridView1.DataSource = x;

        }


        void reset()
        {

            txtInscripcion.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtNumeroSS.Text = "";
            rdHombre.Checked = true;
            rdMujer.Checked = false;
            datepfecha.Value = DateTime.Now;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInscripcion.Text != "" && txtNombre.Text != "" && txtApellidos.Text != "" && txtDireccion.Text != "")
                {


                    // creo una instancia de tipo paciente
                    Pacientes MyPaciente = new Pacientes();

                    MyPaciente.Inscripcion = int.Parse(txtInscripcion.Text);
                    MyPaciente.Nombre = txtNombre.Text;
                    MyPaciente.Apellidos = txtApellidos.Text;
                    MyPaciente.Direccion = txtDireccion.Text;
                    MyPaciente.NumeroSS = txtNumeroSS.Text;

                    if (rdHombre.Checked == true)
                    { MyPaciente.Sexo = true; }
                    else
                    { MyPaciente.Sexo = false; }

                    MyPaciente.fecha = datepfecha.Value;

                    // Inserto en la base de datos
                    bsa.Pacientes.InsertOnSubmit(MyPaciente);
                    bsa.SubmitChanges();
                    cargarGrid();
                    labelsalida.Text = "REGISTRO AGREGADO";
                    reset();
                                                  
                } // del if

            }
            catch
            {
                MessageBox.Show("ERROR BASE DE DATOS");

            }





        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelsalida.Text = "";
            txtInscripcion.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtNumeroSS.Text = "";
            rdHombre.Checked = true;
            rdMujer.Checked = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtInscripcion.Text != "" && txtNombre.Text != "" && txtApellidos.Text != "" && txtDireccion.Text != "")
            {
                try
                {



                    Pacientes MyPaciente = bsa.Pacientes.Single(p => p.Inscripcion == int.Parse(txtInscripcion.Text));


                    MyPaciente.Inscripcion = int.Parse(txtInscripcion.Text);
                    MyPaciente.Nombre = txtNombre.Text;
                    MyPaciente.Apellidos = txtApellidos.Text;
                    MyPaciente.Direccion = txtDireccion.Text;
                    MyPaciente.NumeroSS = txtNumeroSS.Text;
                    MyPaciente.fecha = datepfecha.Value;

                    if (rdHombre.Checked == true)
                    { MyPaciente.Sexo = true; }
                    else
                    { MyPaciente.Sexo = false; }


                    bsa.SubmitChanges();
                    cargarGrid();
                    reset();
                    labelsalida.Text = "REGISTRO MODIFICADO";


                }
                catch
                {
                    MessageBox.Show("ERROR BASE DE DATOS");
                }


            }



        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (txtInscripcion.Text != "")
            {
                try
                {

                    Pacientes MyPaciente = bsa.Pacientes.Single(x =>
                     x.Inscripcion== int.Parse(txtInscripcion.Text));
                    bsa.Pacientes.DeleteOnSubmit(MyPaciente);
                    bsa.SubmitChanges();
                    cargarGrid();
                    reset();
                    labelsalida.Text = "REGISTRO BORRADO";
                }

                catch
                {
                    MessageBox.Show("ERROR BASE DE DATOS");
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
