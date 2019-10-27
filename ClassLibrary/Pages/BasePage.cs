using OpenQA.Selenium;

namespace ClassLibrary.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
