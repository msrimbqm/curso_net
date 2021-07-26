using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace InyeccionSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection conexion = new SqlConnection("server=ASATA405\\SQLEXPRESSMARCOS;Initial Catalog=EJERCICIOSCLASE;Persist Security info=True;User Id=sa;PassWord=1234");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = txtIdInsertar.Text;
            string nombre = txtNombreInsertar.Text;
            string edad = txtEdadInsertar.Text;
            string cadena = "insert into Personas(id, nombre, edad)" + "values (" + iden + ",'" + nombre + "'," + edad + ")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
                txtEdadInsertar.Text = "";
                txtNombreInsertar.Text = "";
                txtIdInsertar.Text = "";
            }
            catch
            {
                MessageBox.Show("Error grabar datos");
            }
                
                               
             conexion.Close();

        }

        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string id = txtIdEliminar.Text;
            string cadena = "select id, nombre, edad from Personas where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            try {
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    LabNombre.Content = registro["nombre"].ToString();
                    LabEdad.Content = registro["edad"].ToString();
                    btnBorrar.IsEnabled = true;
                }
                else 
                {

                    MessageBox.Show("No existe articulo con el codigo ingresado");
                    
                }

            } // del try

            catch
            {
                MessageBox.Show("Error producido al acceder base de datos");
            }
            conexion.Close();
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = txtIdEliminar.Text;
            string cadena = "delete from Personas where id=" + iden;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1) {
                LabNombre.Content = "";
                LabEdad.Content = "";
                MessageBox.Show("Articulo Borrado");
            } else
            {
                MessageBox.Show("No existe un articulo con ese codigo");
            }
            conexion.Close();
            btnBorrar.IsEnabled = false;
            txtIdEliminar.Text = "";
            



            

                               
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string id = txtIdModificar.Text;
            string cadena = "select id, nombre, edad from Personas where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtNombreModificar.Text= registro["nombre"].ToString();
                    txtEdadModificar.Text= registro["edad"].ToString();
                    BtnModificar.IsEnabled = true;
                }
                else
                {

                    MessageBox.Show("No existe articulo con el codigo ingresado");

                }

            } // del try

            catch
            {
                MessageBox.Show("Error producido al acceder base de datos");
            }
            conexion.Close();
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();

            string id = txtIdModificar.Text;
            string nombre = txtNombreModificar.Text;
            string edad = txtEdadModificar.Text;

            string cadena = "update Personas set nombre='" + nombre + "',edad=" + edad + " where id=" + id;
            //MessageBox.Show(cadena);


                           

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            //MessageBox.Show(cant.ToString());
            if (cant == 1)
            {
                txtEdadModificar.Text = "";
                txtNombreModificar.Text = "";
                txtIdModificar.Text = "";

                
                MessageBox.Show("Articulo Modificado");
            }
            else
            {
                MessageBox.Show("No existe un articulo con ese codigo");
            }
            conexion.Close();
            BtnModificar.IsEnabled = false;
        }
    }

}
