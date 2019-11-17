using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NUnitTestProject.AutomationLibrary.Helpers
{
    public static class KeyboardHelper
    {
        public static void SendKeys(IWebDriver driver, By selector, string message, int timeout = 30000)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(ExpectedConditions.ElementIsVisible(selector));
            var textElement = driver.FindElement(selector);
            textElement.Clear();
            textElement.SendKeys(message);
        }
    }
}
