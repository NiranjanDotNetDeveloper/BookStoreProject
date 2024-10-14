using Microsoft.AspNetCore.Mvc;

namespace PersonUI.Controllers
{
    [Route("[controller]/[action]")]
    public class PersonController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
