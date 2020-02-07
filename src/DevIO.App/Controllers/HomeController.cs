using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevIO.App.Controllers
{
    public class HomeController : BaseController
    {
        private readonly INotificador _notificador;
        private readonly ILogger<HomeController> _logger;

        public HomeController(INotificador notificador,
                              ILogger<HomeController> logger) : base(notificador)
        {
            _notificador = notificador;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(null);
        }
    }
}
