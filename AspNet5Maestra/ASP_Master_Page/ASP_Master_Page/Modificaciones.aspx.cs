using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP_Master_Page
{
    public partial class Modificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // deber cargar los datos en los textbox del id seleccionado

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["simulacroSQLConnectionString"].ToString();

            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre,pellido1,apellido2,ciudad,categoria from cliente where id ='" + DropDownList1.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();



            if (registro.Read())
            {
                // encontro el registro
                txtNombre.Text = registro["nombre"].ToString();
                txtApellido.Text = registro["pellido1"].ToString();
                txtApellido2.Text = registro["apellido2"].ToString();
                txtCiudad.Text = registro["ciudad"].ToString();
                txtCategoria.Text = registro["categoria"].ToString();

            }            

       
            else
                LabelResultado.Text = "ERROR";
                 conexion.Close();
        }

        protected void btnModi_Click(object sender, EventArgs e)
        {


            try
            {

                string s = System.Configuration.ConfigurationManager.ConnectionStrings["simulacroSQLConnectionString"].ToString();
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                string cadena = "update cliente set nombre='" + txtNombre.Text + "',pellido1='" + txtApellido.Text + "',apellido2='" + txtApellido2.Text + "',ciudad='" + txtCiudad.Text + "',categoria='" + txtCategoria.Text + "' where id='" + this.DropDownList1.Text + "'";
                LabelResultado.Text = cadena;


                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1) LabelResultado.Text = "Datos Modificados";
                else LabelResultado.Text = "No existe usuario";

                conexion.Close();
            }

            catch
            {
                LabelResultado.Text = "ERROR";
            }
        }



}
    }
