using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace ASP_Master_Page
{
    public partial class altas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            // boton de añadir

            try
            {

                string s = System.Configuration.ConfigurationManager.ConnectionStrings["simulacroSQLConnectionString"].ToString();

                SqlConnection conexion = new SqlConnection(s);


                string orden = "insert into cliente (id,nombre,pellido1,apellido2,ciudad,categoria) values ('" + txtId.Text + "','" + txtNombre.Text + "','" + txtApellido.Text+ "','" +txtApellido2.Text+"','"+txtCiudad.Text+"','"+txtCategoria.Text+ "')";
                LabelResultado.Text = orden;

                conexion.Open();
               
                SqlCommand comando = new SqlCommand(orden, conexion);

                comando.ExecuteNonQuery();
                conexion.Close();
                LabelResultado.Text = "DATO AGREGADO CORRECTAMENTEA LA BASE DE DATOS";
            }
            catch
            {
                LabelResultado.Text = "ERROR ACCCESO BASE DE DATOS ,NO SE AGREGARON DATOS";

            }







        }
    }
}