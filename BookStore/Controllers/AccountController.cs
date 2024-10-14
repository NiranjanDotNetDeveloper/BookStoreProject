using Microsoft.AspNetCore.Mvc;

namespace PersonUI.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
