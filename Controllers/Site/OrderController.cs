using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Site
{
    public class OrderController : Controller
    {
        [Route("/order")]
        public IActionResult Index()
        {
            return View("~/Views/Site/Order/Index.cshtml");
        }
    }
}
