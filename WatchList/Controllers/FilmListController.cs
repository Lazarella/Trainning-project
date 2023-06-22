using Microsoft.AspNetCore.Mvc;

namespace WatchList.Controllers
{
    public class FilmListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
