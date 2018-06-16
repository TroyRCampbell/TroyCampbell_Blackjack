using System.Web.Mvc;

using TroyCampbell_Blackjack.Models;
using TroyCampbell_Blackjack.Services;

namespace TroyCampbell_Blackjack.Controllers
{
    public class HomeController : Controller
    {
        private IGameService gameService;

        public HomeController(IGameService gameService)
        {
            this.gameService = gameService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StartNewGame(int numberOfDecks = 1, int numberOfPlayers = 1)
        {
            Game game = this.gameService.CreateGame(numberOfDecks, numberOfPlayers);

            return View("Index", game);
        }
    }
}