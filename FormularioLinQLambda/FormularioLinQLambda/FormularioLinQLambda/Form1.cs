using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLinQLambda
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext nortwind2 = new DataClasses1DataContext();
        private void BtnGuardar_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();
        }

        void cargarCombo()
        {
            var cargaCombo = from p in nortwind2.Products
                select p.ProductName;
            CbNombreProd.DataSource = cargaCombo;                  
        
        }


        void cargarGrid()
        {
            var cargarGrid = from p in nortwind2.Products select p;
            dataGridView1.DataSource = cargarGrid;
                    
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Products MyProduct = new Products();
            MyProduct.ProductName = TxtProd.Text;
            MyProduct.UnitPrice = int.Parse(TxtPrec.Text);
            MyProduct.UnitsInStock = short.Parse(TxtStock.Text);
            MyProduct.CategoryID = int.Parse(TxtCat.Text);
            nortwind2.Products.InsertOnSubmit(MyProduct);
            nortwind2.SubmitChanges();
            cargarGrid();

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(CbNombreProd.SelectedItem.ToString());
            Products MyProducto = nortwind2.Products.Single(p =>
            p.ProductName == CbNombreProd.SelectedItem.ToString());
            MyProducto.ProductName = CbNombreProd.SelectedItem.ToString();
            MyProducto.UnitPrice = int.Parse(TxtPrec.Text);
            MyProducto.UnitsInStock = short.Parse(TxtStock.Text);
            MyProducto.CategoryID = int.Parse(TxtCat.Text);
            nortwind2.SubmitChanges();
            cargarGrid();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Products MyProduct = nortwind2.Products.Single(p =>
            p.ProductName == CbNombreProd.SelectedItem.ToString());
            nortwind2.Products.DeleteOnSubmit(MyProduct);
            nortwind2.SubmitChanges();
            cargarCombo();
            cargarGrid();
        }
    }





}
