using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesCore.Pages
{
    public class SecureModel : PageModel
    {
        public string UserName { get; set; }

        public void OnGet()
        {
            var user = HttpContext.User;
            UserName = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
        }
    }
}