using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUI.Controllers
{
    public class AdminLayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
