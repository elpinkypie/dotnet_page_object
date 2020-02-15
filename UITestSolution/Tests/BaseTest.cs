using NUnit.Framework;
using UITestSolution.Common;

namespace UITestSolution
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            var browser = new Browser();
            DriverManager.Init(browser.Build());
        }

        [TearDown]
        public void Teardown()
        {
            DriverManager.CloseDriver();
        }
    }
}