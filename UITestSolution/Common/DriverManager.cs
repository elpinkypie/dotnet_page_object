using System.Threading;
using OpenQA.Selenium;

namespace UITestSolution.Common
{
    public class DriverManager
    {
        /// <summary>
        /// thread safe parameter
        /// </summary>
        private static readonly ThreadLocal<IWebDriver> Driver = new ThreadLocal<IWebDriver>();
        
        /// <summary>
        /// initialisation of webdriver instance for current thread
        /// </summary>
        /// <param name="driver">ЭЭЭЭЭЭ receives ЭЭЭЭЭ current instance on webdriver ЭЭЭ</param>
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

        public static IJavaScriptExecutor JavaScriptExecutor()
        {
            return (IJavaScriptExecutor)Driver.Value;
        }
    }
}