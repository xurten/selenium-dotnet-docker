using NUnit.Framework;
using NUnitTestProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

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
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            chromeOptions.AddArguments("--no-sandbox");
            chromeOptions.AddArguments("--disable-dev-shm-usage");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
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