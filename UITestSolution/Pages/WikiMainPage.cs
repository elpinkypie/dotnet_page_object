using OpenQA.Selenium;
using UITestSolution.Common;

namespace UITestSolution.Pages
{
    /// <summary>
    /// standard page class sample
    /// </summary>
    public class WikiMainPage:BasePage
    {
        // для объявления переменной класса: модификатор доступа, тип переменной (класс, которому она соответствует), имя переменной
        // объявляем переменную типа By и присваиваем ей значение
        private By contentsLocator = By.Id("n-contents");
        
 
        //any DOM element will have return type as IWebElement 
        private IWebElement contents = base.Driver.FindElement(By.Id("n-contents"));
        
        /// <summary>
        /// opens Wiki main page
        /// </summary>
        public void OpenGoogle()
        {
            Driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
        }
        
    }
}