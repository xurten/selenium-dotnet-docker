using OpenQA.Selenium;

namespace NUnitTestProject.Pages
{
    public class LoginPage : BasePage
    {
        private const string LoginPageUrl = "https://the-internet.herokuapp.com/login";
        public static string UserName = "tomsmith";
        public static string UserPassword = "SuperSecretPassword!";

        public LoginPage(IWebDriver driver) : base(driver)
        {
            driver.Url = LoginPageUrl;
        }

        public LoginPage SetUserName(string userName)
        {
            SendKeys(By.Id("username"), userName);
            return this;
        }

        public LoginPage SetUserPassword(string userPassword)
        {
            SendKeys(By.Id("password"), userPassword);
            return this;
        }

        public SecurePage ClickLogin()
        {
            Click(By.XPath("//button[@class='radius']"));
            return new SecurePage(driver);
        }
    }
}
