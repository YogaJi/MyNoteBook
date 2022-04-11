using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Intergration_test
{
    [TestClass]
    public class Intergrationtest
    {
        private IWebDriver _webDriver;

        [TestInitialize]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new EdgeConfig());
            _webDriver = new EdgeDriver();
        }

        [TestMethod]
        public void TestMethod1()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/");
            Assert.IsTrue(_webDriver.Title.Contains("Home Page"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/");
            var input = _webDriver.FindElement(By.CssSelector("input[name='q']"));
            input.SendKeys("Hello");
            input.Submit();

        }
        [TestCleanup]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}
