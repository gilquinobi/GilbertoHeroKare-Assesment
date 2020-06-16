using GilbertoHeroKare.Services;
using System.Web.Mvc;

namespace GilbertoHeroKare.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHeroService _heroService;

        public HomeController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            var heroes = _heroService.GetAllHeroes();

            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}