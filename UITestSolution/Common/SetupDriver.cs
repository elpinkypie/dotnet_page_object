using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UITestSolution.Common
{
    public class SetupDriver
    {
        public static IWebDriver GetChromeSettings()
        {
            var driver = new ChromeDriver();
//            driver.Manage().Window.FullScreen();
            return SetImplicitWait(driver);
        }

        public static IWebDriver SetImplicitWait(IWebDriver d)
        {
            d.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return d;
        }
    }
}