using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPNET4SQL
{
    public partial class alta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            //string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            try
            {

                string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ToString();

                SqlConnection conexion = new SqlConnection(s);

                conexion.Open();
                SqlCommand comando = new SqlCommand("insert into usuarios (nombre,clave, mail) values ('" + this.txtNombre.Text + "','" + txtClave.Text + "','" + txtMail.Text + "')", conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                labelresultado.Text = "DATO AGREGADO CORRECTAMENTEA LA BASE DE DATOS";
            }
            catch
            {
                labelresultado.Text = "ERROR ACCCESO BASE DE DATOS ,NO SE AGREGARON DATOS";

            }




        }
    }
}