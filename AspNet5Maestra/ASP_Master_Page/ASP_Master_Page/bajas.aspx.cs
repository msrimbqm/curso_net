using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP_Master_Page
{
    public partial class bajas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            // borrar ese id

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["simulacroSQLConnectionString"].ToString();

            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from cliente where id ='" + DropDownList1.Text+ "'", conexion);
            int cantidad = comando.ExecuteNonQuery();

            GridView1.DataBind();

            
            if (cantidad == 1) this.Resultado.Text = "Se  borro el cliente";
            else
                this.Resultado.Text = "No existe un usuario con ese Id";
            
            conexion.Close();






        }
    }
}