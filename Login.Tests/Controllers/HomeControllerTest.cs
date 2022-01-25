using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Login.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Discount_Calculator.Tests;
using Login.Controllers;
using Login.Entity;

namespace Discount_Calculator.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private simpleDbEntities simpleDbEntities = new simpleDbEntities();
        private User_DB user_DB = new User_DB();      
        private UserModel userModel;
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Login()
        {
           
            // Arrange
            HomeController controller = new HomeController();
            var user = new User_DB()
            {
                userName = "test1",
                UserId = 1,
                Password = "test1"
            };
            user_DB.userName = "tes1";
            user_DB.Password = "test1";
            // Act

            ActionResult result = controller.Login(userModel);
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
