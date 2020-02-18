using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using UITestSolution.Pages;

namespace UITestSolution
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Tests: BaseTest
    {
        #region MyRegion
        #endregion
        
        [Test]
        public void Test1()
        {
            var page = new WikiMainPage();
            page.OpenGoogle();
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            var page = new WikiMainPage();
            page.OpenGoogle();
            Assert.Pass();
        }
    }
}
