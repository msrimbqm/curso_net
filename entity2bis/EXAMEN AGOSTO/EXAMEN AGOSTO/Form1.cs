using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_AGOSTO
{
    public partial class Form1 : Form

    {
        // añadimos contexto de entidades de clientes
        BDEntity2Entities ClientesEntity = new BDEntity2Entities();

        public Form1()
        {
            InitializeComponent();
            // llamamos al evento cargar Grid
            Cargargrid();
        }

        //Definimos un evento para cargar GRid
        public void Cargargrid()
        {
            dataGridView1.DataSource = ClientesEntity.Clientes.ToList();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            Clientes Misclientes = new Clientes()

            {
                DNI = txtDNI.Text,
                Nombre = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                EstadoCivil = cbEstadocivil.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                FechaNacimiento = dateTimePicker1.Value

            };
            ClientesEntity.Clientes.Add(Misclientes);
            ClientesEntity.SaveChanges();
            Cargargrid();



        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string TextoDNI = txtDNI.Text;
            var deleteCliente = ClientesEntity.Clientes.Where(c => c.DNI == TextoDNI).Single();
            ClientesEntity.Clientes.Remove(deleteCliente);
            ClientesEntity.SaveChanges();
            Cargargrid();


        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            string TextoDNI = txtDNI.Text;

            Clientes MyCliente = (from c in ClientesEntity.Clientes where c.DNI == TextoDNI select c).Single();
            MyCliente.Nombre = txtNombres.Text;
            MyCliente.Apellidos = txtApellidos.Text;
            MyCliente.Email = txtEmail.Text;
            MyCliente.EstadoCivil = cbEstadocivil.Text;
            MyCliente.FechaNacimiento = dateTimePicker1.Value;
            MyCliente.Telefono = txtTelefono.Text;

            ClientesEntity.SaveChanges();
            Cargargrid();

        }
    }
}
