using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace alumnos
{
    public partial class Form1 : Form
    {

        DataClasses1DataContext AlumnoLink = new DataClasses1DataContext(); // este es para acceso a procesos almacenados en la base SQL

        private SqlConnection conexion = new SqlConnection("server=ASATA405\\SQLEXPRESSMARCOS;Initial Catalog=GESTIONALU;Persist Security info=True;User Id=sa;PassWord=1234"); // esta onexexion ado inyeccion

        void listar()
        {
            dataGridView1.DataSource = AlumnoLink.listar();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            conexion.Open();

           // int c =( int.Parse(AlumnoLink.APcontardni(txtDNI.Text)));
            //MessageBox.Show(c.ToString());


            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string turno = cbTurno.SelectedItem.ToString();
            string sexo = cbSexo.SelectedItem.ToString();
            string especialidad = cbEspecialidad.SelectedItem.ToString();
            string modulo = cbModulo.SelectedItem.ToString();
            int repetidor;
            // datos en sql bit, debe ser 0 o 1 como entero
            if (chekRepetidor.Checked) { repetidor = 1; } else { repetidor = 0; }

            string cadena = "insert into Alumnos (nombre, DNI,Turno,Sexo,Especialidad,Modulo,repetidor)" + " values ('" + nombre + "','" + dni + "','" + turno + "','" + sexo + "','" + especialidad + "','" + modulo + "'," + repetidor +");";
              //MessageBox.Show(cadena);           
         
                SqlCommand comando = new SqlCommand(cadena, conexion); // genera objeto para crear comando sql
            try
            {
                comando.ExecuteNonQuery(); // ejecuta comando sql
                MessageBox.Show("Los datos se guardaron correctamente");
                txtDNI.Text = "";
                txtNombre.Text = "";
                cbEspecialidad.SelectedItem = null;
                cbModulo.SelectedItem = null;
                cbSexo.SelectedItem = null;
                cbTurno.SelectedItem = null;

                this.listar();
            }
            catch
            {
                MessageBox.Show("Error acceso base de datos");
            }

            conexion.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            // compruebo que dni tiene algo para borrar
            if (txtDNI.Text!="")

              {
                string cadena = "delete from Alumnos where DNI=" + txtDNI.Text;

                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    txtDNI.Text = "";

                    MessageBox.Show("Elemento Borrado");
                }
                else
                {
                    MessageBox.Show("No existe un articulo con ese codigo");
                }

              }
            else
              {
                    MessageBox.Show("Debe introducir un DNI");
              }


            this.listar();
            conexion.Close();   
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            // meto un dni y resto campos y modifico
            conexion.Open();
            // compruebo que dni tiene algo para 
            if (txtDNI.Text != "") 
            {
                
                string dni = txtDNI.Text;
                string nombre = txtNombre.Text;
                string turno = cbTurno.SelectedItem.ToString();
                string sexo = cbSexo.SelectedItem.ToString();
                string especialidad = cbEspecialidad.SelectedItem.ToString();
                string modulo = cbModulo.SelectedItem.ToString();
                int repetidor;
            // datos en sql bit, debe ser 0 o 1 como entero
                if (chekRepetidor.Checked) { repetidor = 1; } else { repetidor = 0; }


                string cadena = "update Alumnos set dni='" + dni + "', nombre='" + nombre + "', turno='" + turno + "', sexo='" + sexo + "', especialidad='" + especialidad + "',  modulo='" + modulo + "', repetidor=" + repetidor + " where DNI='" + dni+"'";

                MessageBox.Show(cadena);
                
                
                
                
                
                //string cadena = "update Personas set nombre='" + nombre + "',edad=" + edad + " where id=" + id;

                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    txtDNI.Text = "";

                    MessageBox.Show("Elemento Modificado");
                    txtDNI.Text = "";
                    txtNombre.Text = "";
                    cbEspecialidad.SelectedItem = null;
                    cbModulo.SelectedItem = null;
                    cbSexo.SelectedItem = null;
                    cbTurno.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("No existe un articulo con ese codigo");
                }

            }
            else
            {
                MessageBox.Show("Debe introducir un DNI");
            }

            this.listar();
            conexion.Close();



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusCodigo.Text!="") 
            {
                dataGridView1.DataSource = AlumnoLink.APbuscarcodigo(int.Parse(txtBusCodigo.Text));
                txtBusCodigo.Text = "";
               
            }
            else
            { MessageBox.Show("Debe introducir datos para la busqueda"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            if (txtBusDNI.Text != "")
            {
                dataGridView1.DataSource = AlumnoLink.APbuscardni(txtBusDNI.Text);
                txtBusDNI.Text = "";

            }
            else
            { MessageBox.Show("Debe introducir datos para la busqueda"); }

        }
        

    }
}
