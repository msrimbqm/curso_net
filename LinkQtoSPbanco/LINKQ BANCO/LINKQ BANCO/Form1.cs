using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINKQ_BANCO
{
    public partial class BtnEliminar : Form
    {



        // creo el objeto de la base de datos para acceder SQL
        DataClasses1DataContext ClienteLink = new DataClasses1DataContext();

        // funcion para listar en grid y que llamo al actualizar
        void listar()
        {
            dataGridView1.DataSource = ClienteLink.SPListar();
        }

        void vaciar()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";

        }

       

        public BtnEliminar()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Load(object sender, EventArgs e)
        {
            this.listar();
            CmbBuscar.SelectedIndex = 0;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        { // try intenta y casca, si salta va el catch y da mensaje alerta sin hacerlo finalmente
            try
            {
                    ClienteLink.SPInsertarCliente(txtIdCliente.Text, txtNombre.Text, txtApellidos.Text);
                    this.listar();
                    this.vaciar();
             } 
            catch
            {
                    MessageBox.Show("Error producido clave duplicada");
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ClienteLink.SPModificarCliente(txtIdCliente.Text, txtNombre.Text, txtApellidos.Text);
            this.listar();
            this.vaciar();
        }

        private void BtnEli_Click(object sender, EventArgs e)
        {
            ClienteLink.SPEliminarCliente(txtIdCliente.Text);
            this.listar();
            this.vaciar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            if (txtBuscar.Text != "")
            {


                if (CmbBuscar.SelectedItem.ToString() == "IDCliente")
                {
                    // busco por codigo id

                    dataGridView1.DataSource = ClienteLink.SPBuscarporId(txtBuscar.Text);
                }

                if (CmbBuscar.SelectedItem.ToString() == "Nombre")
                {
                    // busco por codigo id
                    dataGridView1.DataSource = ClienteLink.SPBuscarporNombre(txtBuscar.Text);
                }

                if (CmbBuscar.SelectedItem.ToString() == "Apellidos")
                {
                    // busco por codigo id
                    dataGridView1.DataSource = ClienteLink.SPBuscarporApellido(txtBuscar.Text);
                }
                txtBuscar.Text = "";

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listar();
        }
    }
}
