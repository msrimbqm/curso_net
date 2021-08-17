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

namespace EntityFrameWorkWPF1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ESTO SALE EN EXPLORADODOR EN .TT .CS ABRIENDO
        BDEntityEntities DBEntityes = new BDEntityEntities();
        public static DataGrid ControlDatagrid;
                

        public MainWindow()
        {
            InitializeComponent();
            // cargamos el data grid apuntando a la tabla de profesores
            MyDG.ItemsSource = DBEntityes.Profesores.ToList();
            ControlDatagrid = MyDG;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // boton llamar a cuadro insertar
            Window2 VInsertar = new Window2();
            VInsertar.ShowDialog();


           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // boton de modificar
            int id = (MyDG.SelectedItem as Profesores).id;
            Window1 Vcambiar = new Window1(id);
            Vcambiar.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id = (MyDG.SelectedItem as Profesores).id;
            var deleteProfe = DBEntityes.Profesores.Where(m => m.id == id).Single();
            DBEntityes.Profesores.Remove(deleteProfe);
            DBEntityes.SaveChanges();
            ControlDatagrid.ItemsSource = DBEntityes.Profesores.ToList();               

        }
    }
}
