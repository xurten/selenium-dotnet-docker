using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NUnitTestProject.AutomationLibrary.Helpers
{
    public class MouseHelper
    {
        public static void Click(IWebDriver driver, By selector, int timeout)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(ExpectedConditions.ElementIsVisible(selector));
            wait.Until(ExpectedConditions.ElementToBeClickable(selector));
            driver.FindElement(selector)
                .Click();
        }
    }
}