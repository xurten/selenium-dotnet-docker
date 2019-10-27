using OpenQA.Selenium;

namespace ClassLibrary.Pages
{
    public class LoginPage : BasePage
    {
        private const string LoginPageUrl = "https://the-internet.herokuapp.com/login";

        public LoginPage(IWebDriver driver) : base(driver)
        {
            driver.Url = LoginPageUrl;
        }
    }
}
