using Microsoft.AspNetCore.Mvc;

namespace RazorPagesCore.Controllers
{
    public class LogonController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("http://localhost:49905/Logon.aspx");
        }
    }
}