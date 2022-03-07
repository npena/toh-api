using toh_api.Controllers;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;

namespace toh_api_test
{
    [TestClass]
    public class TourOfHeroesControllerTest
    {
        [TestMethod]
        public void Ctor_IsNotNull()
        {
            var logger = Mock.Of<ILogger<TourOfHeroesController>>();
            var controller = new TourOfHeroesController(logger);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        public void Get_IsNotNull()
        {
            var logger = Mock.Of<ILogger<TourOfHeroesController>>();
            var controller = new TourOfHeroesController(logger);

            var result = controller.Get();
            Assert.IsNotNull(result);
        }
    }
}