using Microsoft.AspNetCore.Mvc;

namespace HelloDevopsGit.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
