using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial_N2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                HttpCookie cookie1 = new HttpCookie("contraseña", TextBox4.Text);
                Response.Cookies.Add(cookie1);
                this.Session["usuario"] = this.TextBox2.Text;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Usuario creado con éxito.'); window.location.href='/Index.aspx';", true);
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}