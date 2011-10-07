using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NUnit.Framework;
using TTFWebFormsToMvc.Web.Areas.Protected.Controllers;

namespace TTFWebFormsToMvc.Tests.Areas.Protected.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new HomeController();
            _controller.SetFakeControllerContext();
        }

        [Test]
        public void Default_should_put_ShowWelcomeMessage_in_the_ViewBag()
        {
            // arrange
            // act
            var result = (ViewResult)_controller.Default();

            // assert
            Assert.IsInstanceOf<Boolean>(result.ViewBag.ShowWelcomeMessage);
        }

        [Test]
        public void Default_should_return_ViewResult()
        {
            // arrange
            // act
            var result = _controller.Default();

            // assert
            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}
