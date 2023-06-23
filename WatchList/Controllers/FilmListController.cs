using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WatchList.Data;
using WatchList.Models;

namespace WatchList.Controllers
{
    public class FilmListController : Controller
    {
        private readonly ApplicationDbContext _contexte;
        private readonly UserManager<MyUser> _administrator;
        public FilmListController(ApplicationDbContext contexte,
            UserManager<MyUser>administrator)
        {
            _contexte = contexte;
            _administrator = administrator;
        }

        private Task<MyUser>GetCurrentUserAsync() =>
            _administrator.GetUserAsync(HttpContext.User);

        [HttpGet]
        public async Task<string> GetCurrentUser()
        {
            MyUser myUser = await GetCurrentUserAsync();
            return myUser?.Id;
        }
       /* public IActionResult Index()
        {
            return View();
        }*/
    public async Task<IActionResult> Index()
    {
        var Id = await GetCurrentUserAsync();
            var filmsUser = _contexte.FilmUsers.Where(x => x.User == Id);
            var modele = filmsUser.Select(x => new ModeleVueFilm
            {
                IdFilm = x.IdFilm,
                Title = x.Film.Title,
                releaseDate = x.Film.releaseDate,
                Seen = x.Seen,
                InList = true,
                Note = x.Note
            }).ToList();

            return View(modele);
    }
    }
}
