using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkQtoSP
{
    public partial class GridDatos : Form
    {
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public GridDatos()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarclientes();

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.Modificarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarclientes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(TxtNombre.Text);
            this.listarclientes();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
           GridDato.DataSource= ClienteLinq.Buscarcliente(TxtBuscar.Text);
           
        }

        void listarclientes()
        {
            GridDato.DataSource = ClienteLinq.ListarClientes();
        }

        private void GridDatos_Load(object sender, EventArgs e)
        {
            this.listarclientes();

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido1.Text = "";
            TxtApellido2.Text = "";
            TxtTelefono.Text = "";
        }
    }
}
