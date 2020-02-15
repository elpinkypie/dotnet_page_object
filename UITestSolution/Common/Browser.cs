using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UITestSolution.Common
{
    public class Browser
    {
        private readonly string _browser = "Chrome";

        public IWebDriver Build()
        {
            switch (_browser)
            {
                case "Chrome":
                    return SetupDriver.GetChromeSettings();
                case "Firefox":
                    throw new NotImplementedException();
                default: 
                    return SetupDriver.GetChromeSettings();
            }
        }
    }
}

