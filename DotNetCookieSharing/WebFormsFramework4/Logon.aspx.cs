using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;

namespace WebFormsFramework4
{
    public partial class Logon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Logon_Click(object sender, EventArgs e)
        {
            if ((UserEmail.Text == "alexc") &&
                    (UserPass.Text == "securepass"))
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, UserEmail.Text));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, UserEmail.Text));
                claims.Add(new Claim(ClaimTypes.Role, "Administrator"));

                // create the identity
                var identity = new ClaimsIdentity(claims, "Identity.Application");

                HttpContext.Current.GetOwinContext().Authentication.SignIn(new AuthenticationProperties()
                {
                    IsPersistent = Persist.Checked
                },
                identity);

                Response.Redirect("~/Default.aspx", false);
            }
            else
            {
                Msg.Text = "Invalid credentials. Please try again.";
            }
        }
    }
}