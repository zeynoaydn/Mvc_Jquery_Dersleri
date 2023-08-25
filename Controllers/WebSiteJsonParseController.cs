using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jquery_Dersleri.Controllers
{
    public class WebSiteJsonParseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
