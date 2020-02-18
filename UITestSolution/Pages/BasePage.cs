using OpenQA.Selenium;
using UITestSolution.Common;

namespace UITestSolution.Pages
{
    public class BasePage
    {
        /// <summary>
        /// 
        /// </summary>
        protected IWebDriver Driver;
        protected BasePage() => Driver = DriverManager.GetDriver();
    }
}