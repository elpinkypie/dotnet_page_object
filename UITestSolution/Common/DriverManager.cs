using System.Threading;
using OpenQA.Selenium;

namespace UITestSolution.Common
{
    public class DriverManager
    {
        private static readonly ThreadLocal<IWebDriver> Driver = new ThreadLocal<IWebDriver>();

        public static void Init(IWebDriver driver)
        {
            Driver.Value = driver;
        }
        
        public static IWebDriver GetDriver()
        {
            return Driver.Value;
        }

        public static void CloseDriver()
        {
            Driver.Value.Quit();
        }
    }
}