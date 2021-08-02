using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLQ2Lambda
{
    public partial class txtapellido : Form
    {
        public txtapellido()
        {
            InitializeComponent();
        }

        DataClasses1DataContext bsa = new DataClasses1DataContext();

        private void txtapellido_Load(object sender, EventArgs e)
        {

            cargarGrid();
        }

        void reset()
        {

            txtid.Text = "";
            txtnombre.Text = "";
            txtape.Text = "";
            txtedad.Text = "";
            checkcasado.Checked = false;
            labbus.Text = "";
        }

        void cargarGrid()
        {
            var x = from p in bsa.Empleados select p;

            dataGridView1.DataSource = x;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // busqueda por nombre y busco y muestro en grid
           
            
            var x = from p in bsa.Empleados where txtbuscar.Text == p.Nombre select p;

            
            dataGridView1.DataSource = x;
            
            int cuenta = x.Count();
            labbus.Text = "Se han encontrado "+cuenta.ToString()+" registros";





        }


        private void btnalta_Click(object sender, EventArgs e)
        {

            Empleados MyEmpleado = new Empleados();
            MyEmpleado.Id = int.Parse(txtid.Text);
            MyEmpleado.Nombre = txtnombre.Text;
            MyEmpleado.Apellido = txtape.Text;
            MyEmpleado.Edad = int.Parse(txtedad.Text);
            MyEmpleado.Casado = checkcasado.Checked;

           
            try { 
            bsa.Empleados.InsertOnSubmit(MyEmpleado);
            bsa.SubmitChanges();
            cargarGrid();
                reset();
            




                }
        catch
                {
                MessageBox.Show("ERROR BASE DE DATOS");
                
                }



        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            Empleados MyEmpleado = bsa.Empleados.Single(p => p.Id == int.Parse(txtid.Text));
            MyEmpleado.Id = int.Parse(txtid.Text);
            MyEmpleado.Nombre = txtnombre.Text;
            MyEmpleado.Apellido = txtape.Text;
            MyEmpleado.Edad = int.Parse(txtedad.Text);
            MyEmpleado.Casado = checkcasado.Checked;
            try
            {

                bsa.SubmitChanges();
                cargarGrid();
                reset();
            }
            catch
            {
                MessageBox.Show("ERROR BASE DE DATOS");
            }

        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            Empleados MyEmpleado = bsa.Empleados.Single(x =>
            x.Id == int.Parse(txtid.Text));

            try
            {
                bsa.Empleados.DeleteOnSubmit(MyEmpleado);
                bsa.SubmitChanges();
                cargarGrid();
                reset();
            }

            catch
            {
                MessageBox.Show("ERROR BASE DE DATOS");
            }
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cargarGrid();
            labbus.Text = "";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            

           

        }
    }
}
