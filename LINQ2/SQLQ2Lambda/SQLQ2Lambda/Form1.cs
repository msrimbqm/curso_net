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
            
            // here. conteins
          

            dataGridView1.DataSource = x;
            
            int cuenta = x.Count();
            labbus.Text = "Se han encontrado "+cuenta.ToString()+" registros";





        }


        private void btnalta_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados MyEmpleado = new Empleados();
            MyEmpleado.Id = int.Parse(txtid.Text);
            MyEmpleado.Nombre = txtnombre.Text;
            MyEmpleado.Apellido = txtape.Text;
            MyEmpleado.Edad = int.Parse(txtedad.Text);
            MyEmpleado.Casado = checkcasado.Checked;
                 
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
            try
            { 
            Empleados MyEmpleado = bsa.Empleados.Single(p => p.Id == int.Parse(txtid.Text));
            MyEmpleado.Id = int.Parse(txtid.Text);
            MyEmpleado.Nombre = txtnombre.Text;
            MyEmpleado.Apellido = txtape.Text;
            MyEmpleado.Edad = int.Parse(txtedad.Text);
            MyEmpleado.Casado = checkcasado.Checked;
            
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
            try
            {

            
            Empleados MyEmpleado = bsa.Empleados.Single(x =>
            x.Id == int.Parse(txtid.Text));

            
            
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
            // al seleccionar una fila meterla el campo  de texto
            
            
                int fila = 0;
            // Voy comprobar que no da null el actual
                DataGridViewRow xx = dataGridView1.CurrentRow;
                if (xx != null)
                    {

                        fila = dataGridView1.CurrentRow.Index;

                        txtid.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                        txtnombre.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                        txtape.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                        txtedad.Text = dataGridView1.Rows[fila].Cells[3].Value.ToString();


                if (dataGridView1.Rows[fila].Cells[4].Value.ToString() == "True")

                        checkcasado.Checked = true;
                else
                        checkcasado.Checked = false;


                }

        }
    }
}
