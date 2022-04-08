using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationNew.Clases;

namespace WebApplicationNew
{
    public partial class About : Page
    {
        List<Forma2D> diagrama = new List<Forma2D>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Cookies["userInfo"]==null) Response.Redirect("Default.aspx");
            //else Response.Redirect("Default.aspx");
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button12.Enabled = true;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            if (checkbox.SelectedItem==Rectangulo2)
            {
                diagrama.Add(new Rectangulo(20, 20));
            }
            //diagrama.Add()
        }
    }
}