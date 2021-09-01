using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPNET4SQL
{
    public partial class modificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre, clave, mail from usuarios where nombre ='" + this.txtNombreUsuario.Text + "'", conexion);

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtClave.Text = registro["clave"].ToString();
                txtMail.Text = registro["mail"].ToString();
                            }
            else

            
                this.Resultado.Text = "No existe un usuario con ese nombre";
                conexion.Close();

           


        }

        protected void btnModi_Click(object sender, EventArgs e)
        {
            try
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ToString();
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();

                SqlCommand comando = new SqlCommand("update usuarios set " + "clave='" + txtClave.Text + "',mail='" + this.txtMail.Text + "'" + " where nombre='" + this.txtNombreUsuario.Text + "'", conexion);
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1) this.Resultado.Text = "Datos Modificados";
                else this.Resultado.Text = "No existe usuario";

                conexion.Close();
            }
            catch
            {
                Resultado.Text = "ERROR DE BASE DE DATOS";
            }
                    




        }
    }
}