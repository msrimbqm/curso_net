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
            
            
            // usar try, usar cach para sacar los if de los que falla o dar error generiCo OJOJOJOJO 
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
            // llamamos contexto entidadesy añadimos al objeto clientes
            ClientesEntity.Clientes.Add(Misclientes);
            // guardar nuevo registro base de dato
            ClientesEntity.SaveChanges();
            // refrescar dataGrid
            Cargargrid();


        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            // buscar por el dni y rellenar a los campos de texto
            
            string TextoDNI = txtDNI.Text;

            // con lambsa tengo qu estudiar hacerlo tipo funcionamiento like de sql 
            try
            {
                var BuscaCliente = ClientesEntity.Clientes.Where(x => x.DNI == TextoDNI).Single();


                txtNombres.Text = BuscaCliente.Nombre;
                txtApellidos.Text = BuscaCliente.Apellidos;
                txtTelefono.Text = BuscaCliente.Telefono;
                txtEmail.Text = BuscaCliente.Email;
                cbEstadocivil.Text = BuscaCliente.EstadoCivil;
                dateTimePicker1.Text = BuscaCliente.FechaNacimiento.ToString();
            }

            catch
            {
                //MessageBox.Show("ERROR NO EXISTE DNI O NO HAY ACCESO A BD");

            }

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            // poner try para evitar no exista dni 
           
           
            // variable guardar DNI q es clave
            string TextoDNI = txtDNI.Text;

            // comprobar existe registro

            bool existe = ClientesEntity.Clientes.Any(x => x.DNI == TextoDNI);
            LabAviso.Text = "";

            if (existe)

            {
                try {
                    // metodo lamba consigue un clinete por su DNI o se puede usar el de abajo Entity

                    var deleteCliente = ClientesEntity.Clientes.Where(c => c.DNI == TextoDNI).Single();

                    // metodo con linq para conseguir un cliente por DNI
                    //Clientes MyCliente =(From c in ClientesEntity.Clientes where c.DNI == TextoDNI select c).Single();
                    // contains en linkq seria como like en sql

                    // borramos el cliente indicado
                    ClientesEntity.Clientes.Remove(deleteCliente);
                    ClientesEntity.SaveChanges();
                    Cargargrid();
                }

                catch {

                    LabAviso.Text = "ERROR DE BASE DATOS";
                       }

            }else
            {
                // No existe DNI
                LabAviso.Text = "ERROR NO EXISTE DNI";
            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            string TextoDNI = txtDNI.Text;
            bool existe = ClientesEntity.Clientes.Any(x => x.DNI == TextoDNI);
            LabAviso.Text = "";

            if (existe)

            {
                try
                {
                    // Mediante LINQ OBTENEMOS ESE CLIENTE
                    Clientes MyCliente = (from c in ClientesEntity.Clientes where c.DNI == TextoDNI select c).Single();

                    // atributos de mycliente objeto
                    MyCliente.Nombre = txtNombres.Text;
                    MyCliente.Apellidos = txtApellidos.Text;
                    MyCliente.Email = txtEmail.Text;
                    MyCliente.EstadoCivil = cbEstadocivil.Text;
                    MyCliente.FechaNacimiento = dateTimePicker1.Value;
                    MyCliente.Telefono = txtTelefono.Text;
                    // añadirlo base de datos
                    ClientesEntity.SaveChanges();
                    Cargargrid();
                }
                catch
                {

                    LabAviso.Text = "ERROR DE BASE DATOS";

                }
            }
            else
            {
                LabAviso.Text = "ERROR NO EXISTE DNI";
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // posicionarse primero

           

            // con lambsa tengo qu estudiar hacerlo tipo funcionamiento like de sql 
            var BuscaCliente = ClientesEntity.Clientes.First();

            txtDNI.Text = BuscaCliente.DNI;
            txtNombres.Text = BuscaCliente.Nombre;
            txtApellidos.Text = BuscaCliente.Apellidos;
            txtTelefono.Text = BuscaCliente.Telefono;
            txtEmail.Text = BuscaCliente.Email;
            cbEstadocivil.Text = BuscaCliente.EstadoCivil;
            dateTimePicker1.Text = BuscaCliente.FechaNacimiento.ToString();
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];





        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // posicionarse ultimo



            // con lambsa tengo qu estudiar hacerlo tipo funcionamiento like de sql 
           
            var BuscaCliente = ClientesEntity.Clientes.ToList().Last();

            txtDNI.Text = BuscaCliente.DNI;
            txtNombres.Text = BuscaCliente.Nombre;
            txtApellidos.Text = BuscaCliente.Apellidos;
            txtTelefono.Text = BuscaCliente.Telefono;
            txtEmail.Text = BuscaCliente.Email;
            cbEstadocivil.Text = BuscaCliente.EstadoCivil;
            dateTimePicker1.Text = BuscaCliente.FechaNacimiento.ToString();
            int xx = dataGridView1.RowCount;
            dataGridView1.CurrentCell = dataGridView1.Rows[xx-1].Cells[0];
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // declaramos variable indicar la fila anteior
            int anterior = dataGridView1.CurrentRow.Index - 1;
                  
            
            if (anterior >=0)
                {
                // desplazamos a la anterior
                dataGridView1.CurrentCell = dataGridView1.Rows[anterior].Cells[dataGridView1.CurrentCell.ColumnIndex];
                // cargamos el text box
                txtDNI.Text = dataGridView1.Rows[anterior].Cells[0].Value.ToString();
                txtNombres.Text = dataGridView1.Rows[anterior].Cells[1].Value.ToString();
                txtApellidos.Text = dataGridView1.Rows[anterior].Cells[2].Value.ToString();
                cbEstadocivil.Text = dataGridView1.Rows[anterior].Cells[5].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[anterior].Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[anterior].Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[anterior].Cells[6].Value.ToString();

            }


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            // declaramos variable indicar la fila anteior
            int siguiente = dataGridView1.CurrentRow.Index + 1;
            int k = dataGridView1.RowCount;
    

            if (siguiente < k)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[siguiente].Cells[dataGridView1.CurrentCell.ColumnIndex];
                // cargamos el text box
                txtDNI.Text = dataGridView1.Rows[siguiente].Cells[0].Value.ToString();
                txtNombres.Text = dataGridView1.Rows[siguiente].Cells[1].Value.ToString();
                txtApellidos.Text = dataGridView1.Rows[siguiente].Cells[2].Value.ToString();
                cbEstadocivil.Text = dataGridView1.Rows[siguiente].Cells[5].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[siguiente].Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[siguiente].Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[siguiente].Cells[6].Value.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // cargar datos alcambiar
            int siguiente = dataGridView1.CurrentRow.Index;
            txtDNI.Text = dataGridView1.Rows[siguiente].Cells[0].Value.ToString();
            txtNombres.Text = dataGridView1.Rows[siguiente].Cells[1].Value.ToString();
            txtApellidos.Text = dataGridView1.Rows[siguiente].Cells[2].Value.ToString();
            cbEstadocivil.Text = dataGridView1.Rows[siguiente].Cells[5].Value.ToString();
            txtTelefono.Text = dataGridView1.Rows[siguiente].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[siguiente].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[siguiente].Cells[6].Value.ToString();
        }
    }
}
