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

        void cargarGrid()
        {
            var cargargrid = from p in bsa.Empleados select p;
           
            dataGridView1.DataSource = cargarGrid;

        }

        private void btnalta_Click(object sender, EventArgs e)
        {

            Empleados MyEmpleado = new Empleados();
            MyEmpleado.Id = int.Parse(txtid.Text);
            MyEmpleado.Nombre = txtnombre.Text;
            MyEmpleado.Apellido = txtapellido.Text;
            MyEmpleado.Edad = int.Parse(txtedad.Text);

            if (checkcasado.Checked==true) MyEmpleado.Casado = 1 else MyEmpleado.Casado = 0

            bsa.Empleados.InsertOnSubmit(MyEmpleado);
            bsa.SubmitChanges();
            cargarGrid();



        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            Empleados MyEmpleado = bsa.Empleados.Single(p => p.Id == txtid.Text.ToString());
            MyEmpleado.Id = int.Parse(txtid.Text);
            MyEmpleado.Nombre = txtnombre.Text;
            MyEmpleado.Apellido = txtapellido.Text;
            MyEmpleado.Edad = int.Parse(txtedad.Text);
            bsa.SubmitChanges();
            cargarGrid();

        }
    }
}
