using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using log4net;
using NUnitTestProject.AutomationLibrary.Helpers;
using NUnitTestProject.AutomationLibrary.Loggers;

namespace NUnitTestProject.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Logger logger;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            logger = new Logger();
        }

        public BasePage Click(By selector, int timeout = 30000)
        {
            MouseHelper.Click(driver, selector, timeout);
            logger.LogInfo($"Click event with selector {selector}");
            return this;
        }

        public BasePage SendKeys(By selector, string message)
        {
            KeyboardHelper.SendKeys(driver, selector, message);
            logger.LogInfo($"Click event with selector {selector}");
            return this;
        }
    }   
}
