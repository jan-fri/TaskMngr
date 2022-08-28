using Microsoft.AspNetCore.Mvc;

namespace TaskMngrApp.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
