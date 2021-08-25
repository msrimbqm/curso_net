using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = DateTime.Today.ToString("d");
            //Label1.Text = "1";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Label1.Text);
            x++;
            Label1.Text = x.ToString();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {   int resultado = 0;
            int x1 = 0;
            int x2 = 0;

            if (Sumar.Checked)
            {
                x1=int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 + x2;
                Label4.Text = resultado.ToString();

            }

            if (Restar.Checked)
            {
                x1 = int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 - x2;
                Label4.Text = resultado.ToString();

            }
        }

        protected void btncalcular2_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int x1 = 0;
            int x2 = 0;

            if (DropDownList1.Items[0].Selected)
            {


                x1 = int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 + x2;
                Label4.Text = resultado.ToString();

            }

            if (DropDownList1.Items[1].Selected)
            {
                x1 = int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 - x2;
                Label4.Text = resultado.ToString();

            }


        }
    }
}