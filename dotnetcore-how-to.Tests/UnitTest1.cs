using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetcore_how_to.Controllers;
using System.Linq;

namespace dotnetcore_how_to.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new ValuesController();

            var result = controller.Get();

            Assert.AreEqual(2, result.Count());
        }
    }
}
