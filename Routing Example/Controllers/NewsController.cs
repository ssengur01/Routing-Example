using Microsoft.AspNetCore.Mvc;

namespace Routing_Example.Controllers
{
    public class NewsController: Controller
    {

        public IActionResult Haberler()
        {
            return View();
        }
    }
}

