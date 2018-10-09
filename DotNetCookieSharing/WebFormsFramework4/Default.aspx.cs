using System;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;

namespace WebFormsFramework4
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.GetOwinContext().Authentication.User.Identity.IsAuthenticated)
            {
                Welcome.Text = $"Hello {HttpContext.Current.GetOwinContext().Authentication.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value}";
            }
        }

        protected void Signout_Click(object sender, EventArgs e)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("~/Logon.aspx", false);
        }
    }
}