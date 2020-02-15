using UITestSolution.Common;

namespace UITestSolution.Pages
{
    public class PageOne:BasePage
    {
        public void OpenGoogle()
        {
            Driver.Navigate().GoToUrl("https://google.com");
        }
    }
}