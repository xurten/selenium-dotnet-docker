using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ClassLibrary.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

    }
}
