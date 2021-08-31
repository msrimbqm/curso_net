using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet3_validacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)

        {

            labelfinal.Text = CheckBox1.Checked.ToString();
            if (CheckBox1.Checked == false) labelfinal.Text = "Debe aceptar las condiones"; else labelfinal.Text = "";

            if ((IsValid) && (CheckBox1.Checked==true)) Response.Redirect("AccesoPermitido.aspx");
        }
    }
}