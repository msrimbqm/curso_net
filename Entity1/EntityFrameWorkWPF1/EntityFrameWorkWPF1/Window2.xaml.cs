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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window

    {
        BDEntityEntities DbEntityes = new BDEntityEntities();


        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // int idulti = MyDataGrid.Items.Count+1;
            Profesores MyProfe = new Profesores()
            {

               id=int.Parse(TxtId.Text), 
                                  
               Nombre =TxtNombre.Text, 
               Especialidad =cmbEspec.Text

            };
            DbEntityes.Profesores.Add(MyProfe);
            DbEntityes.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = DbEntityes.Profesores.ToList();
            this.Hide();



        }
    }
}
