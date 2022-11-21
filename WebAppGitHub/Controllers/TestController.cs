using Microsoft.AspNetCore.Mvc;

namespace WebAppGitHub.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
