using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen250821
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbNombreProducto.SelectedItem = null;
        }

        // Definimos contexto de clases 
        DataClasses1DataContext bsa = new DataClasses1DataContext();

        void cargarGrid()
        {
            // carga datos grid
            
            var x = from p in bsa.PRODUCTOS select p;
            dataGridView1.DataSource = x;
        }

        void cargarCombo()
        {
            // carga datos del combo - nombre productos
            var cargar = from p in bsa.PRODUCTOS
                              select p.NombreProducto;
            cmbNombreProducto.DataSource = cargar;
            // 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // carga los datos de la BD en el Grid y en el combo los nombres
            cargarGrid();
            cargarCombo();
            // pone sin seleccio el combo hasta que se utilize
            cmbNombreProducto.SelectedItem = null;


        }

        private void limpiartextos()
        { // limpia los textbox de caracteres

            txtNombreProducto.Text = "";
            txtPrecioUd.Text = "";
            txtUnidadesStock.Text = "";
            txtBuscar.Text = "";
                    
        }


        bool existe(string p1)
        {
            // funcion pedida que busca en la base de datos y retorna true o false segun exista o no
            bool v1;
            v1 = bsa.PRODUCTOS.Any(x => x.NombreProducto == p1);
            return v1;                         
        
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            // añade un nuevo producto debe comprobar que no existe ya ese articulo y que rellenasmos los tres campos y las excepciones con try catch
            if (!existe(txtNombreProducto.Text) && (txtNombreProducto.Text != ""))

            {
                try
                {
                    PRODUCTOS MyProducto = new PRODUCTOS();

                    MyProducto.NombreProducto = txtNombreProducto.Text;
                    MyProducto.PrecioUnidad = Decimal.Parse(txtPrecioUd.Text);
                    MyProducto.UnidadStock = int.Parse(txtUnidadesStock.Text);


                    bsa.PRODUCTOS.InsertOnSubmit(MyProducto);
                    bsa.SubmitChanges();
                    cargarGrid();
                    cargarCombo();
                    limpiartextos();
                    cmbNombreProducto.SelectedItem = null;


                }
                catch
                {
                    // compruebo si algun campo vacio o error generico
                    if ((txtNombreProducto.Text == "") || (txtPrecioUd.Text == "") || (txtUnidadesStock.Text == ""))
                        MessageBox.Show("INTRODUZCA TODOS LOS CAMPOS DEL PRODUCTO");
                    else
                        MessageBox.Show("ERROR BASE DE DATOS");
                 }

            } else
            {
                MessageBox.Show("NOMBRE DE PRODUCTO YA EXISTENTE O NOMBRE VACIO DEL PRODUCTO");
            }



        }


            

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // modificar el precio unidad y unidades stock del producto seleccionado en el combobox

            try
            {

                // linq lambda selecciona el registro a modificar

                PRODUCTOS MyProducto = bsa.PRODUCTOS.Single(p => p.NombreProducto == cmbNombreProducto.SelectedItem.ToString());

                MyProducto.PrecioUnidad = Decimal.Parse(txtPrecioUd.Text);
                MyProducto.UnidadStock = int.Parse(txtUnidadesStock.Text);

                bsa.SubmitChanges();
                cargarGrid();
                cargarCombo();
                limpiartextos();
                cmbNombreProducto.SelectedItem = null;
                txtNombreProducto.BackColor = Color.White;
            }
            catch
            {

                // compruebo si algun campo vacio o error generico
                if ( (txtPrecioUd.Text == "") || (txtUnidadesStock.Text == ""))
                    MessageBox.Show("INTRODUZCA TODOS LOS CAMPOS PRECIO UNIDAD Y STOCK DEL PRODUCTO SELECCIONADO");
                else
                    MessageBox.Show("ERROR BASE DE DATOS");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // BORRA EL ELEMENTO SELECCIONADO CON TRY PARA CONTROLAR ERRORES EN LA BASE DE DATOS
            if (cmbNombreProducto.SelectedItem != null)
            {
                // solo intenta borrar si hay algo seleccinado


                try
                {

                    PRODUCTOS MyProducto = bsa.PRODUCTOS.Single(p => p.NombreProducto == cmbNombreProducto.SelectedItem.ToString());
                    bsa.PRODUCTOS.DeleteOnSubmit(MyProducto);
                    bsa.SubmitChanges();
                    cargarGrid();
                    cargarCombo();
                    limpiartextos();
                    txtNombreProducto.Enabled = true;
                    txtNombreProducto.BackColor = Color.White;
                    cmbNombreProducto.SelectedItem = null;

                }
                catch
                {

                    MessageBox.Show("ERROR BASE DE DATOS");
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN ELEMENTO PARA BORRAR");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // filtra el grid por el nombre busqeda contenida en campo de texto, no puede se vacio

            if (txtBuscar.Text!="")
            {

                

                var x = from p in bsa.PRODUCTOS where p.NombreProducto.Contains(txtBuscar.Text) select p;
                               
               
                dataGridView1.DataSource = x;

            }else
            {
                MessageBox.Show("NOMBRE DE PRODUCTO VACIO O  NO EXISTENTE EN LA BASE DE DATOS  ");
            }

        }

        private void cmbNombreProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // evento al cambiar el combo, al hacerlo rellena los datos del producto en los campos de texto
            PRODUCTOS MyProducto = bsa.PRODUCTOS.Single(p => p.NombreProducto == cmbNombreProducto.SelectedItem.ToString());
            
            txtNombreProducto.Text = MyProducto.NombreProducto;
            txtPrecioUd.Text = MyProducto.PrecioUnidad.ToString();
            txtUnidadesStock.Text = MyProducto.UnidadStock.ToString();
            txtNombreProducto.Enabled = false;
            txtNombreProducto.BackColor = Color.LightGray;
            var x = from p in bsa.PRODUCTOS where p.NombreProducto==txtNombreProducto.Text select p;

            dataGridView1.DataSource = x;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // resetea la busqueda estado original
            
            cargarGrid();
            cargarCombo();
            limpiartextos();
            txtNombreProducto.Enabled = true;
            txtNombreProducto.BackColor = Color.White;
            cmbNombreProducto.SelectedItem = null;


        }
    }
}
