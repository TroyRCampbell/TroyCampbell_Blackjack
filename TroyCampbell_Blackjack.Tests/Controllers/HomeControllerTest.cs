using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

using TroyCampbell_Blackjack.Controllers;
using TroyCampbell_Blackjack.Services;

namespace TroyCampbell_Blackjack.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var gameService = Substitute.For<IGameService>();
            HomeController controller = new HomeController(gameService);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
