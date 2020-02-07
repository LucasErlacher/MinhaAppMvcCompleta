using DevIO.App.ViewModels;
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

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            modelErro.ErroCode = id;

            if (id == 500)
            {
                modelErro.Titulo = "Ocorreu um erro!";
                modelErro.Mensagem = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
            }

            else if (id == 404)
            {
                modelErro.Titulo = "Ops! Página não encontrada.";
                modelErro.Mensagem = "A página que está procurando não existe! <br />Em caso de dúvidas entre em contato com nosso suporte.";
            }

            else if (id == 500)
            {
                modelErro.Titulo = "Acesso Negado!";
                modelErro.Mensagem = "Você não tem permissão para fazer isso.";
            }

            return View("Error", modelErro);
        }
    }
}
