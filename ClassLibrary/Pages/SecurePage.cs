using OpenQA.Selenium;

namespace ClassLibrary.Pages
{
    public class SecurePage : BasePage
    {
        public SecurePage(IWebDriver driver) : base(driver)
        {

        }

        public SecurePage GetHeadingTwoText(out string headingText)
        {
            var headingElement = driver.FindElement(By.TagName("h2"));
            headingText = headingElement.Text.Trim();
            return this;
        }

        public SecurePage GetAlertText(out string alertText)
        {
            var alertElement = driver.FindElement(By.Id("flash"));
            alertText = alertElement.Text.Trim();
            return this;
        }
    }
}
