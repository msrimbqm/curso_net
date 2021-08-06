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

namespace Ejercicio_Filtros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        // inicalizamos la clase de contexto
        // siempope en la clase mainwindow para WPF

        datosjuevesdatacontexDataContext filtros = new datosjuevesdatacontexDataContext();



        public MainWindow()
        {
            /// <summary>
            /// Inicializar Formulario y cargamos Grid con TODOS LOS DATOS
            /// </summary>
            InitializeComponent();
            cargarGrid();
            DatePicker1.SelectedDate = DateTime.Now;
            DatePicker2.SelectedDate = DateTime.Now;
            DatePicker3.SelectedDate = DateTime.Now;
            DatePicker4.SelectedDate = DateTime.Now;

        }



        void cargarGrid()
        {
            // metodo con linq para cargar el DataGrid
            var listagrid= from f in filtros.datos select f;
            DGV1.ItemsSource = listagrid;

        }

        void cargarGridCurso()
        {
            // aqui filtramos los registros del curso seleccionado en el campo
            String curso = ComboBox1.Text;
            var listagrid = from f in filtros.datos where f.Curso == curso select f;
            DGV1.ItemsSource = listagrid;


        }

        void cargarGridNombre(String cadena)
        {
            // metodo linq para filtrar por el nombre, y curso ojo contais es los mismo que LIKE en SQL

            String curso = ComboBox1.Text;
            var listagrid = from f in filtros.datos where f.Curso == curso && f.Nombre.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;

        }

        void cargarGridApellido(String cadena)
        {
           // filtro por apellido, like es containst
            String curso = ComboBox1.Text;
            var listagrid = from f in filtros.datos where f.Curso == curso && f.Apellidos.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;


        }



        void cargarGridApellidoNombre(String cadena, string cadena2)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datos
                            where f.Curso == curso && f.Nombre.Contains(cadena)
            && f.Apellidos.Contains(cadena2)
                            select f;
            DGV1.ItemsSource = listagrid;
        }


        void cargarGridFechas(DateTime f1, DateTime f2)
        {
            string curso = ComboBox1.Text;

            var listagrid = from f in filtros.datos
                            where  f.Fecha_Insc>=f1 && f.Fecha_Insc<=f2
                            select f;
            DGV1.ItemsSource = listagrid;
        }

        void cargarGridFechasC(DateTime f1, DateTime f2)
        {
            string curso = ComboBox1.Text;

            var listagrid = from f in filtros.datos
                            where  f.Fecha_Cont >= f1 && f.Fecha_Cont<= f2
                            select f;
            DGV1.ItemsSource = listagrid;
        }


        void cargarGridFechas4(DateTime f1, DateTime f2, DateTime f3, DateTime f4)
        {
            string curso = ComboBox1.Text;

            var listagrid = from f in filtros.datos
                            where  f.Fecha_Insc >= f1 && f.Fecha_Insc <= f2  && f.Fecha_Cont>= f1 && f.Fecha_Cont<= f2
                            select f;
            DGV1.ItemsSource = listagrid;
        }


        /// <summary>
        /// Habilitar y deshabilit Check de las fechas
        /// </summary>
        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = true;

        }

        private void CheckBox1_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = false;

        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = true;
        }

        private void CheckBox2_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = false;

        }

        private void CheckBox4_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = true;
        }

        private void CheckBox4_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = false;

        }

        private void CheckBox5_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = true;
        }

        private void CheckBox5_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = false;

        }

        /// <summary>
        ///Deshabilita instructores
        /// </summary>

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = true;
            CheckBox5.IsEnabled = true;
        }

        private void CheckBox3_UnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = false;
            CheckBox5.IsEnabled = false;

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "" & TextBox2.Text != "")
                cargarGridApellidoNombre(TextBox1.Text, TextBox2.Text);
            else if (TextBox1.Text != "" && TextBox2.Text == "")
                cargarGridNombre(TextBox1.Text);
            else if (TextBox1.Text == "" & TextBox2.Text != "")
                cargarGridApellido(TextBox2.Text);
            else
                cargarGridCurso();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        


            if (CheckBox1.IsEnabled == true && CheckBox2.IsEnabled == true && CheckBox3.IsChecked == false)
                //filtra por fechas de arriba
                {
                
                cargarGridFechas(DatePicker1.DisplayDate, DatePicker2.DisplayDate); 
                }

            
               // filtra por fecha de abajo
                if (CheckBox4.IsChecked== true && CheckBox5.IsChecked == true && CheckBox1.IsChecked== false && CheckBox2.IsChecked == false)
                {
                  
                cargarGridFechasC(DatePicker3.DisplayDate, DatePicker4.DisplayDate);
                
            }
                
                
                // caso filtrado por las cuatro fechas

                 if (CheckBox4.IsChecked == true && CheckBox5.IsChecked== true && CheckBox1.IsChecked == true && CheckBox2.IsChecked == true)
                    {
                        cargarGridFechas4(DatePicker1.DisplayDate, DatePicker2.DisplayDate, DatePicker3.DisplayDate, DatePicker4.DisplayDate);
               
                    }

        






        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cargarGrid();
            DatePicker1.SelectedDate = DateTime.Now;
            DatePicker2.SelectedDate = DateTime.Now;
            DatePicker3.SelectedDate = DateTime.Now;
            DatePicker4.SelectedDate = DateTime.Now;
            TextBox1.Text = "";
            TextBox2.Text = "";
            

        }
    }





}
