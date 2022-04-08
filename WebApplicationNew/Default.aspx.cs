using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationNew.Clases;
using WebApplicationNew.DAL;

namespace WebApplicationNew
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "") return;
            User usuarioQueSeIntentaInsertar = new User(TextBox1.Text, "default", TextBox2.Text);
            DALUser usuarioDAL = new DALUser();

            if (usuarioDAL.findUser(usuarioQueSeIntentaInsertar) != null)
            {
                HttpCookie userInfo = new HttpCookie("userInfo");
                userInfo["mail"] = TextBox1.Text;
                userInfo["password"] = TextBox2.Text;
                userInfo.Expires.Add(new TimeSpan(0, 1, 0));
                Response.Cookies.Add(userInfo);
                Response.Redirect("About.aspx");
            }
 
            else Response.Write("<script>alert('Incorrect credentials')</script>");
        }
    }
}