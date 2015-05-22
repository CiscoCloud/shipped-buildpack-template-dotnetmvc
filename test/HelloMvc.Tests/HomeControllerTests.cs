using Microsoft.AspNet.Mvc;
using MvcSample.Web;
using MvcSample.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HelloMvc.Tests
{
    public class HomeControllerTests
    {
        private HomeController _homeController;
        public HomeControllerTests()
        {
            _homeController = new HomeController();
        }

        [Fact]
        public void IndexSetsUserModel()
        {
            var result = _homeController.Index() as ViewResult;
            var model = result.ViewData.Model as User;
            Assert.Null(model);
        }
    }
}
