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
using System.Windows.Shapes;

namespace EntityFrameWorkWPF1
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        BDEntityEntities DBEntityes = new BDEntityEntities();
        int id;

        public Window1(int IdPProfesor)
        {
            InitializeComponent();
            id = IdPProfesor;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profesores MyProfe = (from m in DBEntityes.Profesores where m.id == id select m).Single();
            MyProfe.Nombre = TxtNombre.Text;
            MyProfe.Especialidad = cmbEspec.Text;
            DBEntityes.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = DBEntityes.Profesores.ToList();
            this.Hide();

           
            
        }
    }
}
