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
            var nameField = driver.FindElement(By.Id("username"));
            nameField.Clear();
            nameField.SendKeys(userName);
            return this;
        }

        public LoginPage SetUserPassword(string userPassword)
        {
            var passwordField = driver.FindElement(By.Id("password"));
            passwordField.Clear();
            passwordField.SendKeys(userPassword);
            return this;
        }


        public SecurePage ClickLogin()
        {
            driver.FindElement(By.XPath("//button[@class='radius']"))
                .Click();
            return new SecurePage(driver);
        }
    }
}
