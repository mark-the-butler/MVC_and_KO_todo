using System.Collections.Generic;
using System.Web.Mvc;
using NUnit.Framework;
using TodoWithMVC_And_KO.Controllers;

namespace TodoWithMVC_And_KO.Tests
{
    [TestFixture]
    public class ToDoControllerTests
    {
        private ToDoController _homeController;

        [SetUp]
        public void SetUp()
        {
            _homeController = new ToDoController();
        }

        [Test]
        public void Index_Should_Return_Correct_View_With_Empty_List()
        {
            var result = _homeController.Index() as ViewResult;
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(result.ViewName, "Index");
                Assert.IsInstanceOf<List<string>>(result.Model);
                Assert.IsInstanceOf<ViewResult>(result);
            });
            
        }
    }
}