using Microsoft.AspNetCore.Mvc;

namespace StudentPortal.Web.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
