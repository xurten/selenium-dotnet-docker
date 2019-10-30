using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject.Pages
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

        public BasePage Click(By selector, int timeout = 30000)
        {
            MouseHelper.Click(driver, selector, timeout);
            return this;
        }

    }
}
