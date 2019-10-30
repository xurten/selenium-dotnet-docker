using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
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
;           logger.LogInfo($"Click event with selector {selector} took {GetActionTime(() => MouseHelper.Click(driver, selector, timeout))}");
            return this;
        }

        private long GetActionTime(Action action)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            action();
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public BasePage SendKeys(By selector, string message)
        {
            logger.LogInfo($"Sendkeys event with selector {selector} took {GetActionTime(() => KeyboardHelper.SendKeys(driver, selector, message))} ms");
            return this;
        }
    }   
}
