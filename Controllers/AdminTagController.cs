using Microsoft.AspNetCore.Mvc;

namespace TecheyBlog.Controllers
{
    public class AdminTagController : Controller
    {

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
