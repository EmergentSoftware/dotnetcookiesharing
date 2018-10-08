using System;
using System.Web.Security;
using System.Web.UI;

namespace WebFormsFramework4
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Welcome.Text = "Hello, " + Context.User.Identity.Name;
        }

        protected void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }
    }
}