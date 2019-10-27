using ClassLibrary.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject
{
    public class LoginPageTests
    {
        private IWebDriver driver;
        private const string successAlertMessage = "You logged into a secure area!";
        private const string headingMessage = "Secure Area";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void CheckLoginProcess()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage
                .SetUserName(LoginPage.UserName)
                .SetUserPassword(LoginPage.UserPassword)
                .ClickLogin()
                .GetHeadingTwoText(out var headingText)
                .GetAlertText(out var alertText);

            Assert.AreEqual(headingMessage, headingText);
            Assert.IsTrue(alertText.Contains(successAlertMessage));
        }
    }
}