using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuestionarioASP
{
    public partial class _default : System.Web.UI.Page
    {
        int Aciertos=0;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if (RadioButton1.Checked) Aciertos++;
            if (RadioButton4.Checked) Aciertos++;
            if (RadioButton7.Checked) Aciertos++;

            Label1.Text = "El Numero de aciertos es: " + Aciertos.ToString();
            Aciertos = 0;
            if (IsValid) Response.Redirect("AccesoPermitido.aspx");

            
            {


            
            }


        }
    }
}