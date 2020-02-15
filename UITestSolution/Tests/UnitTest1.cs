using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using UITestSolution.Pages;

namespace UITestSolution
{
    public class Tests: BaseTest
    {
        #region MyRegion
        #endregion
        
        [Test]
        public void Test1()
        {
            var page = new PageOne();
            page.OpenGoogle();
            Assert.Pass();
        }
    }
}
